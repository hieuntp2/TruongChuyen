using MyTransactionCode;
using NCKH3.Class;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NCKH3
{
    public partial class Server : Form
    {
        private SvListenAcceptClient _myListenAccept;
        private Thread _sthreadAcceptClient;
        private TcpListener serverSocket;
        private MyClientManage _myClientManage;
        private ServerTheadingManage _threadmanage = null;

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            serverSocket = new TcpListener(8888);
            serverSocket.Start();

            _threadmanage = ServerTheadingManage.getInstance();

            _myClientManage = MyClientManage.getInstance();
            _myClientManage.setCurrentForm(this);

            _myListenAccept = SvListenAcceptClient.getInstance(serverSocket);
            _sthreadAcceptClient = new Thread(_myListenAccept.task);
            _myListenAccept.start();
            _myListenAccept.setForm(this);
            _sthreadAcceptClient.Start();

            tbPassword.PasswordChar = '*';
            tbPassword.Text = "";
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

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {           
            Console.WriteLine(" >> exit");
            Console.ReadLine();
            _myListenAccept.stop();
            serverSocket.Stop();
            _threadmanage.StopManage();
        }

        internal string getPassword()
        {
            return tbPassword.Text;
        }
    }

    /// <summary>
    /// Listen accept from client. This is single-ton client
    /// </summary>
    public class SvListenAcceptClient : IMyThread
    {      
        static SvListenAcceptClient _instance = null;
        private bool isRunning = false;
        Server _currentForm = null;
        static TcpListener myserverSocket;
        MyClientManage _clmanage;

        private SvListenAcceptClient() 
        {
            _clmanage = MyClientManage.getInstance();
        }

        public static SvListenAcceptClient getInstance(TcpListener serverSocket = null)
        {
            if(serverSocket != null)
            {
                myserverSocket = serverSocket;
            }
            if(_instance == null)
            {
                _instance = new SvListenAcceptClient();
            }

            return _instance;
        }

        public void start()
        {
            isRunning = true;
            
        }

        public void stop()
        {
            isRunning = false;          
        }

        public void task()
        {
            while ((isRunning))
            {
                try
                {
                    
                    TcpClient clientSocket = default(TcpClient);   
                    clientSocket = myserverSocket.AcceptTcpClient();
                    _clmanage.addNewClient(clientSocket);

                    _currentForm.addToReceiverText(" >> Accept connection from client");

                    //NetworkStream networkStream = clientSocket.GetStream();
                    //byte[] bytesFrom = new byte[10025];
                    //networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    //string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    //dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                    //_currentForm.addToReceiverText(" >> Data from client - " + dataFromClient);

                    //string serverResponse = "Last Message from client" + dataFromClient;
                    //Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    //networkStream.Write(sendBytes, 0, sendBytes.Length);
                    //networkStream.Flush();
                    //_currentForm.addToReceiverText(" >> " + serverResponse);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void setForm(Server form)
        {
            _currentForm = form;
        }
    }

    public interface IMyThread
    {
        void start();
        void stop();
        void task();
    }
}
