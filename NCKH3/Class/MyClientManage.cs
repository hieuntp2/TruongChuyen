using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
            MyClient myclient = new MyClient(clientSocket);
            myclient.setCurrentForm(_currentForm);
            _lClients.Add(myclient);
            _currentForm.addToReceiverText("Client " + myclient.getId().ToString() + "Connect to server!");
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
    
    }
}
