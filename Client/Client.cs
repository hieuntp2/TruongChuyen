using MyTransactionCode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        TcpClient clientSocket;
        ClientSocketManage mysocketManage;
        MySendFactory _mysendFactory;
        public Client()
        {           
            InitializeComponent();
            mysocketManage = ClientSocketManage.getInstance();
            clientSocket = mysocketManage.getSocket();
            _mysendFactory = new MySendFactory(clientSocket);
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
            MyBaseTransaction transaction = new MyBaseTransaction();
            transaction._myTransactioncode = Transaction_Code.cl_disconnect;
            _mysendFactory.sendJsonObject(transaction);
            mysocketManage.stopConnection();
        }
    }
}
