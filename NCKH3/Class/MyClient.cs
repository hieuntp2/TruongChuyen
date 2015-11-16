using MyTransactionCode;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Sockets;

namespace NCKH3.Class
{
    class MyClient
    {
        private int id = -1;
        private static int NEXT_ID_NUMBER = 0;
        private bool isRunning = false;
        private Server _currentForm;

        private int _idThread;
        private string username;
        private TcpClient _socket;

        private ServerTheadingManage _threadManage;
        private MySendFactory _mysendFactory;

        public MyClient(TcpClient socketClient)
        {
            id = NEXT_ID_NUMBER;
            NEXT_ID_NUMBER += 1;
            _socket = socketClient;
            isRunning = true;

            _threadManage = ServerTheadingManage.getInstance();
            _idThread = _threadManage.addNewWork(listenServer);
            _threadManage.startInstance(_idThread);

            _mysendFactory = new MySendFactory(_socket);
        }

        public int getId()
        {
            return id;
        }

        public void setCurrentForm(Server currentForm)
        {
            _currentForm = currentForm;
        }

        // listen message from server
        public void listenServer()
        {
            while (isRunning)
            {
                try
                {
                    NetworkStream networkStream = _socket.GetStream();
                    byte[] bytesFrom = new byte[10025];
                    networkStream.Read(bytesFrom, 0, (int)_socket.ReceiveBufferSize);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    //dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                    _currentForm.addToReceiverText(id + ": " +  dataFromClient);

                    processRequest(dataFromClient);
                }
                catch
                {
                    Stop();
                    _currentForm.addToReceiverText("Client " + id + " has disconnect from server!");                   
                }
            }
        }

        public void processRequest(string requestdata)
        {
            JObject jObject = JObject.Parse(requestdata);

            MyTransactionFactory factory = MyTransactionFactory.getInstance();
            MyBaseTransaction transaction = factory.createTransaction(jObject);

            switch(transaction._myTransactioncode)
            {
                case Transaction_Code.cl_client_connect_infor:
                    string _password = _currentForm.getPassword();
                    MyTr_Client_Connect_Infor transactionoff = (MyTr_Client_Connect_Infor)transaction;
                    if (_password == transactionoff.password)
                    {
                        // if password is match
                        this.username = transactionoff.username;
                        MyBaseTransaction info = new MyBaseTransaction();
                        info._myTransactioncode = Transaction_Code.sv_login_accept;
                        _mysendFactory.sendJsonObject(info);
                    }
                    else
                    {
                        // if password not match
                        _mysendFactory.quickSendJsonObject(Transaction_Code.sv_incorrect_info);
                    }
                    break;
                case Transaction_Code.cl_disconnect:
                    Stop();
                    break;
                case Transaction_Code.sv_client_connect:
                    break;
                case Transaction_Code.sv_client_disconnect:
                    break;
                case Transaction_Code.sv_disconnect:
                    break;
                case Transaction_Code.sv_incorrect_info:
                    break;
                case Transaction_Code.sv_login_accept:
                    break;               
            }
        }

        public void Stop()
        {
            isRunning = false;
            _socket.Close();
            _threadManage.stopInstance(_idThread);
            MyClientManage manage = MyClientManage.getInstance();
            manage.RemoveClient(this);
        }


        internal void sendTransaction(MyBaseTransaction transaction)
        {
            _mysendFactory.sendJsonObject(transaction);
        }
    }
}
