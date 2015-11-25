using Newtonsoft.Json;
using System;
using System.Net.Sockets;
using System.Text;

namespace MyTransactionCode
{
    public class MySendFactory
    {
        TcpClient clientSocket;

        public MySendFactory(TcpClient socket)
        {
            clientSocket = socket;
        }

        /// <summary>
        /// send data to server
        /// </summary>
        /// <param name="obj"></param>
        public void sendJsonObject(Object obj)
        {
            if (clientSocket.Connected)
            {
                string json = JsonConvert.SerializeObject(obj);
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = Encoding.Unicode.GetBytes(json);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
            }
        }

        /// <summary>
        /// send data to server
        /// </summary>
        /// <param name="obj"></param>
        public void quickSendJsonObject(Transaction_Code transactioncode)
        {
            MyBaseTransaction transaction = new MyBaseTransaction();
            transaction.MyTransactioncode = transactioncode;

            sendJsonObject(transaction);
        }
    }
}
