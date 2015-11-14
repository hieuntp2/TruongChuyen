using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTransactionCode
{
    public enum Transaction_Code
    {
        cl_disconnect = 1,
        cl_client_connect_infor = 2,


        sv_disconnect = 3,
        sv_client_connect = 4,
        sv_client_disconnect = 5,
        sv_incorrect_info = 6,
        sv_login_accept = 7
    }

    public class MyBaseTransaction
    {
        public Transaction_Code _myTransactioncode;
        private string p;

        public MyBaseTransaction() { }

        public MyBaseTransaction(string p)
        {
            this.p = p;
        }

        public Transaction_Code MyTransactioncode
        {
            get { return _myTransactioncode; }
            set { _myTransactioncode = value; }
        }
    }

    public class MyTr_Client_Connect_Infor : MyBaseTransaction
    {
        public MyTr_Client_Connect_Infor(string username, string password)
        {
            this._myTransactioncode = Transaction_Code.cl_client_connect_infor;
            this.username = username;
            this.password = password;
        }

        public string username, password;
    }

    /// <summary>
    /// Create transaction base on input. 
    /// This is singleton class
    /// </summary>
    public class MyTransactionFactory
    {
        private static MyTransactionFactory _instance = null;
        private MyTransactionFactory()
        {

        }

        public static MyTransactionFactory getInstance()
        {
            if (_instance == null)
            {
                _instance = new MyTransactionFactory();
            }

            return _instance;
        }

        public MyBaseTransaction createTransaction(JObject obj)
        {
            string transaction_type = obj["_myTransactioncode"].ToString();
            MyBaseTransaction transaction = new MyBaseTransaction();

            switch (transaction_type)
            {
                case "1":
                    transaction._myTransactioncode = Transaction_Code.cl_disconnect;
                    break;
                case "2":
                    MyTr_Client_Connect_Infor transactionoff = new MyTr_Client_Connect_Infor(obj["username"].ToString(), obj["password"].ToString());

                    return transactionoff;
                case "3":
                    transaction._myTransactioncode = Transaction_Code.sv_disconnect;
                    break;
                case "4":
                    transaction._myTransactioncode = Transaction_Code.sv_client_connect;
                    break;
                case "5":
                    transaction._myTransactioncode = Transaction_Code.sv_client_disconnect;
                    break;
                case "6":
                    transaction._myTransactioncode = Transaction_Code.sv_incorrect_info;
                    break;
                case "7":
                    transaction._myTransactioncode = Transaction_Code.sv_login_accept;
                    break;
            }
            return transaction;
        }
    }
}

