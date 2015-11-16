using MyTransactionCode;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        TcpClient clientSocket;
        ClientSocketManage mysocketManage;
        MySendFactory _mysendFactory;
        private bool isRunning = false;
        Thread _listenFromServer = null;
        public Client()
        {           
            InitializeComponent();
            mysocketManage = ClientSocketManage.getInstance();
            clientSocket = mysocketManage.getSocket();
            _mysendFactory = new MySendFactory(clientSocket);

            isRunning = true;

            _listenFromServer = new Thread(listenFromServer);
            _listenFromServer.Start();
        }

        private void Client_Load(object sender, EventArgs e)
        {           
        }

        delegate void SetTextCallback(string text);

        public void addToReceiverText(string text)
        {
            string my_new_text = tbMessage.Text + text;
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbMessage.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(addToReceiverText);
                this.Invoke(d, new object[] { text + Environment.NewLine });
            }
            else
            {
                this.tbMessage.Text = my_new_text + Environment.NewLine;
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop();
        }

        private void listenFromServer()
        { 
            while(isRunning)
            {
                try
                {
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesFrom = new byte[10025];
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);

                    processRequest(dataFromClient);
                }
                catch
                {
                    //MessageBox.Show("S");
                }
            }
        }

        private void processRequest(string dataFromClient)
        {
            JObject jObject = JObject.Parse(dataFromClient);

            MyTransactionFactory factory = MyTransactionFactory.getInstance();
            MyBaseTransaction transaction = factory.createTransaction(jObject);

            switch (transaction._myTransactioncode)
            {
                //case Transaction_Code.sv_incorrect_info:
                //    MessageBox.Show("Password not match!");
                //    break;
                //case Transaction_Code.sv_login_accept:
                //    Client client = new Client();
                //    this.Hide();
                //    client.Show();
                //    break;
                case Transaction_Code.sv_disconnect:
                    // Nếu server đóng thì client cũng sẽ close session
                    MessageBox.Show("You has beend disconnect from server!");
                    stop();
                    break;
            }
        }

        private void stop()
        {
            MyBaseTransaction transaction = new MyBaseTransaction();
            transaction._myTransactioncode = Transaction_Code.cl_disconnect;

            isRunning = false;
            _listenFromServer.Interrupt();
            _mysendFactory.sendJsonObject(transaction);
            mysocketManage.stopConnection();
        }
    }
}
