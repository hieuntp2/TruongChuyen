using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class PlayGameForm : Form
    {
        
        struct ClientInfo
        {
            public Socket socket;   //Socket of the client
            public string strName;  //Name by which the user logged into the chat room
        }
        List<clientViewObject> listviewclient;

        byte[] byteData = new byte[1024];


        private Question thisQuesion = new Question();
        public PlayGameForm()
        {
            InitializeComponent();
            AccessForm.clientList = new ArrayList();
            try
            {

                AccessForm.ServerSocket.BeginAccept(new AsyncCallback(OnAccept), null);
                listviewclient = new List<clientViewObject>();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "server",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        int timeCount  = 0;
        private int questionID = 0;
        private void PlayGameForm_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            thisQuesion = AccessForm.MyQuestions.Questions[questionID];
            lblQuest.Text = thisQuesion.Quest;
            btnA.Text = thisQuesion.AnswerA;
            btnB.Text = thisQuesion.AnswerB;
            btnC.Text = thisQuesion.AnswerC;
            btnD.Text = thisQuesion.AnswerD;
            lblQuestNumber.Text = thisQuesion.ID;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCount++;
            int myValue = 100-(timeCount*100/(Int32.Parse(thisQuesion.Time)*100));
            progressBar1.Value = myValue;
            if (myValue == 0)
            {
                ShowResult();
                NextQuestion();
            }
        }

        private void ShowResult()
        {
            
        }

        private void ShowFinalResult()
        {
            MessageBox.Show("Done!");
        }

        private void NextQuestion()
        {
            questionID++;
            try
            {
                timeCount = 0;
                thisQuesion = AccessForm.MyQuestions.Questions[questionID];
                lblQuest.Text = thisQuesion.Quest;
                btnA.Text = thisQuesion.AnswerA;
                btnB.Text = thisQuesion.AnswerB;
                btnC.Text = thisQuesion.AnswerC;
                btnD.Text = thisQuesion.AnswerD;
                lblQuestNumber.Text = thisQuesion.ID;
            }
            catch (Exception ex)
            {
                ShowFinalResult();
            }
        }
        private void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = AccessForm.ServerSocket.EndAccept(ar);

                //Start listening for more clients
                AccessForm.ServerSocket.BeginAccept(new AsyncCallback(OnAccept), null);

                //Once the client connects then start receiving the commands from her
                clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None,
                    new AsyncCallback(OnReceive), clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = (Socket)ar.AsyncState;
                clientSocket.EndReceive(ar);

                //Transform the array of bytes received from the user into an
                //intelligent form of object Data
                Data msgReceived = new Data(byteData);

                //We will send this object in response the users request
                Data msgToSend = new Data();

                byte[] message;

                //If the message is to login, logout, or simple text message
                //then when send to others the type of the message remains the same
                msgToSend.cmdCommand = msgReceived.cmdCommand;
                msgToSend.strName = msgReceived.strName;

                switch (msgReceived.cmdCommand)
                {
                    case Command.Login:

                        //When a user logs in to the server then we add her to our
                        //list of clients

                        ClientInfo clientInfo = new ClientInfo();
                        clientInfo.socket = clientSocket;
                        clientInfo.strName = msgReceived.strName;

                        AccessForm.clientList.Add(clientInfo);

                        //Set the text of the message that we will broadcast to all users
                        //msgToSend.strMessage = "<<<" + msgReceived.strName + " has joined the room>>>";

                        addListClient(msgReceived.strName);
                        break;

                    case Command.Logout:

                        //When a user wants to log out of the server then we search for her 
                        //in the list of clients and close the corresponding connection

                        int nIndex = 0;
                        foreach (ClientInfo client in AccessForm.clientList)
                        {
                            if (client.socket == clientSocket)
                            {
                                AccessForm.clientList.RemoveAt(nIndex);
                                break;
                            }
                            ++nIndex;
                        }

                        clientSocket.Close();

                        // msgToSend.strMessage = "<<<" + msgReceived.strName + " has left the room>>>";
                        removeListClient(msgReceived.strName);
                        break;

                    case Command.Message:

                        //Set the text of the message that we will broadcast to all users
                        msgToSend.strMessage = msgReceived.strName + ": " + msgReceived.strMessage;
                        break;

                    case Command.List:

                        //Send the names of all users in the chat room to the new user
                        msgToSend.cmdCommand = Command.List;
                        msgToSend.strName = null;
                        msgToSend.strMessage = null;

                        //Collect the names of the user in the chat room
                        foreach (ClientInfo client in AccessForm.clientList)
                        {
                            //To keep things simple we use asterisk as the marker to separate the user names
                            msgToSend.strMessage += client.strName + "*";
                        }

                        message = msgToSend.ToByte();

                        //Send the name of the users in the chat room
                        clientSocket.BeginSend(message, 0, message.Length, SocketFlags.None,
                                new AsyncCallback(OnSend), clientSocket);
                        break;
                }

                if (msgToSend.cmdCommand != Command.List)   //List messages are not broadcasted
                {
                    message = msgToSend.ToByte();

                    foreach (ClientInfo clientInfo in AccessForm.clientList)
                    {
                        if (clientInfo.socket != clientSocket ||
                            msgToSend.cmdCommand != Command.Login)
                        {
                            //Send the message to all users
                            clientInfo.socket.BeginSend(message, 0, message.Length, SocketFlags.None,
                                new AsyncCallback(OnSend), clientInfo.socket);
                        }
                    }
                }

                //If the user is logging out then we need not listen from her
                if (msgReceived.cmdCommand != Command.Logout)
                {
                    //Start listening to the message send by the user
                    clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnReceive), clientSocket);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnSend(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                client.EndSend(ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addListClient(string name)
        {
            ListViewItem item = new ListViewItem();
            item.Name = name;
            item.Text = name;
            item.SubItems.Add(name);
            ///////////list_client.Items.Add(item);

            clientViewObject checkitem = new clientViewObject();
            checkitem.id = 0;
            checkitem.name = name;

            listviewclient.Add(checkitem);
        }

        private void removeListClient(string name)
        {
            clientViewObject temp = new clientViewObject();
            foreach (clientViewObject item in listviewclient)
            {
                if (item.name == name)
                {
                    temp = item;
                }
            }

            ////////////list_client.Items.RemoveAt(temp.id);
            listviewclient.RemoveAt(temp.id);
        }

        private void PlayGameForm_Deactivate(object sender, EventArgs e)
        {
        }
    }
}
