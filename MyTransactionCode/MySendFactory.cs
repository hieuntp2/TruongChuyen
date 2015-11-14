using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
            string json = JsonConvert.SerializeObject(obj);
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(json);
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        /// <summary>
        /// send data to server
        /// </summary>
        /// <param name="obj"></param>
        public void quickSendJsonObject(Transaction_Code transactioncode)
        {
            MyBaseTransaction transaction = new MyBaseTransaction();
            transaction._myTransactioncode = transactioncode;

            sendJsonObject(transaction);
        }
    }
}
