using MyTransactionCode;
using MyTransactionCode.MyQuestion;
using System.Collections.Generic;
using System.Net.Sockets;

namespace NCKH3.Class
{
    class MyClientManage
    { 
        List<MyClient> _lClients;
        private static Server _currentForm;
        private static MyClientManage _instance = null;
        private bool isRunning = true;

        public void setRunning(bool isRunning)
        {
            this.isRunning = isRunning;
        }

        private MyClientManage()
        {
            _lClients = new List<MyClient>();
        }

        public void setCurrentForm(Server current)
        {
            _currentForm = current;
        }

        public static MyClientManage getInstance()
        {
            if (_instance == null)
            {
                _instance = new MyClientManage();
            }

            return _instance;
        }

        public void listenClient()
        {

        }

        internal void addNewClient(TcpClient clientSocket)
        {
            MyClient myclient = new MyClient(clientSocket, _currentForm);
            //myclient.setCurrentForm(_currentForm);
            _lClients.Add(myclient);
            _currentForm.addToReceiverText(">> Usser " + myclient.getId() + " kết nối!");
        }

        /// <summary>
        /// Disconnect all client and remove all from manage
        /// </summary>
        public void StopAllClient()
        {
            foreach (MyClient client in _lClients)
            {
                client.Stop();
            }

            _lClients.Clear();
        }

        public void RemoveClient(MyClient client)
        {
            this._lClients.Remove(client);
        }

        public void StopClient(int p)
        {
            _lClients.RemoveAt(p);
        }


        internal void sendToAll(MyBaseTransaction transaction)
        {
            for(int i = 0; i < _lClients.Count; i++)
            {
                _lClients[i].sendTransaction(transaction);
            }
        }

        internal void sendToAll(Transaction_Code code)
        {
            MyBaseTransaction transaction = new MyBaseTransaction();
            transaction.MyTransactioncode = code;
            for (int i = 0; i < _lClients.Count; i++)
            {
                _lClients[i].sendTransaction(transaction);
            }
        }

        public void setMaxQuestion(int p)
        {
            foreach(MyClient client in _lClients)
            {
                client.setMaxGroupAnswer(p);
            }
        }

        internal void showClientInfor(int clientId, MyGroupQuestion groupQuestion)
        {
            for(int i = 0; i < _lClients.Count; i++)
            {
                if(_lClients[i].getId() == clientId)
                {
                    ClientInfor form = new ClientInfor();
                    form.updateInfor(_lClients[i], groupQuestion);
                    form.Show();
                    break;
                }
            }
        }

        internal void writeResultToFile(string pathFile, MyGroupQuestion groupQuestion)
        {
            for (int i = 0; i < _lClients.Count; i++)
            {
                _lClients[i].writeResultToFile(pathFile, groupQuestion);
            }
        }
    }
}
