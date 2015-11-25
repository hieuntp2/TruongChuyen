using MyTransactionCode;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        TcpClient clientSocket;
        ClientSocketManage _socketMange;
        MySendFactory _mysendFactory;

        public Login()
        {
            InitializeComponent();

            _socketMange = ClientSocketManage.getInstance();
            clientSocket = _socketMange.getSocket();
            _mysendFactory = new MySendFactory(clientSocket);

            tbIpServer.Text = "127.0.0.1";
            tbName.Text = "Name 1";
            tbPassword.Text = "";
            tbPassword.PasswordChar = '*';
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (_socketMange.startConnection(tbIpServer.Text))
            {
                // send message to server
                MyTr_Client_Connect_Infor info = new MyTr_Client_Connect_Infor(tbName.Text, tbPassword.Text);

                _mysendFactory.sendJsonObject(info);

                NetworkStream networkStream = clientSocket.GetStream();
                byte[] bytesFrom = new byte[10025];
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);

                processRequest(dataFromClient);
            }
            else
            {
                MessageBox.Show("Server not found!", "Alert");
            }          
        }

        private void processRequest(string dataFromClient)
        {
            JObject jObject = JObject.Parse(dataFromClient);

            MyTransactionFactory factory = MyTransactionFactory.getInstance();
            MyBaseTransaction transaction = factory.createTransaction(jObject);

            switch (transaction.MyTransactioncode)
            { 
                case Transaction_Code.sv_incorrect_info:
                    MessageBox.Show("Password not match!");
                    break;
                case Transaction_Code.sv_login_accept:
                    Client client = new Client();
                    this.Hide();
                    client.Show();                    
                    break;
                case Transaction_Code.sv_disconnect:
                    MessageBox.Show("Server has been close or not found!");
                    break;
            }
        }
        private void Client_Load(object sender, EventArgs e)
        {
           
        }      

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyBaseTransaction info = new MyBaseTransaction();
            info.MyTransactioncode = Transaction_Code.cl_disconnect;
            _mysendFactory.sendJsonObject(info);           
            _socketMange.stopConnection();
        }

    }
}
