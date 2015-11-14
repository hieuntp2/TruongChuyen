using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    /// <summary>
    /// This class manage socket throw program. This is singleton object
    /// </summary>
    class ClientSocketManage
    {
        private ClientSocketManage() 
        {
            _socket = new TcpClient();
        }
        TcpClient _socket = null;

        private static ClientSocketManage _instance = null;
        public static ClientSocketManage getInstance()
        {
            if(_instance == null)
            {
                _instance = new ClientSocketManage();
            }

            return _instance;
        }

        /// <summary>
        /// return true if connect successful. Return fail when cant connect
        /// </summary>
        /// <returns></returns>
        public bool startConnection(string ipServer) 
        {
            try
            {
                if(_socket.Connected)
                {
                    return true;
                }
                _socket.Connect(ipServer, 8888);
                return true;
            }
            catch
            {
                return false;
            }
            return false;
        }

        public void stopConnection() 
        {
            Thread.Sleep(500);
            _socket.Close();
        }

        public TcpClient getSocket()
        {
            return _socket;
        }     
    }
}
