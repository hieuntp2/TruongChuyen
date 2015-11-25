using MyTransactionCode;
using System;
using System.Net.Sockets;

namespace NCKH3.Class
{
    /// <summary>
    /// Listen accept from client. This is single-ton client
    /// </summary>
    public class SvListenAcceptClient
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
            if (serverSocket != null)
            {
                myserverSocket = serverSocket;
            }
            if (_instance == null)
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
                }
                catch (Exception ex)
                {
                    MyLogSystem.Log(ex.ToString());
                }
            }
        }

        public void setForm(Server form)
        {
            _currentForm = form;
        }
    }
}
