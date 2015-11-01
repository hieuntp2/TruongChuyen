using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Server
{
    public partial class AccessForm : Form
    {
        public static QuestionList MyQuestions = new QuestionList();
        public AccessForm()
        {
            InitializeComponent();
            openFileDialog1.Filter = "NetTest File (.nett)|*.nett|All Files (*.*)|*.*";
        }
        public static ArrayList clientList;
        public static Socket ServerSocket;
       
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //We are using TCP sockets
                ServerSocket = new Socket(AddressFamily.InterNetwork,
                                          SocketType.Stream,
                                          ProtocolType.Tcp);

                //Assign the any IP of the machine and listen on port number 1000
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 1000);

                //Bind and listen on the given address
                ServerSocket.Bind(ipEndPoint);
                ServerSocket.Listen(4);

                //Accept the incoming clients
                //serverSocket.BeginAccept(new AsyncCallback(OnAccept), null);

                txtIP.Text = LocalIPAddress();
                btnConnect.Text = "Connected";
                btnOpenTest.Enabled = true;
                btnCreateTest.Enabled = true;
                btnHelp.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "server",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        private void btnOpenTest_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(QuestionList));
                        MyQuestions = (QuestionList)serializer.Deserialize(reader);
                    }
                    //Console.WriteLine(text);
                    foreach (Question q in MyQuestions.Questions)
                    {
                        Debug.WriteLine(q.ToString());
                    }
                    SGSserverForm ServerForm = new SGSserverForm();
                    ServerForm.Show();
                    this.Hide();
                }
                catch (IOException)
                {
                    MessageBox.Show("Unable to open this test");
                }
            }
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            CreateTestForm _createTestForm = new CreateTestForm();
            _createTestForm.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm _helpForm = new HelpForm();
            _helpForm.Show();
            this.Hide();
        }
    }
    public class Question
    {
        [XmlElement("ID")]
        public string ID { get; set; }
        [XmlElement("Quest")]
        public string Quest { get; set; }
        [XmlElement("QuestType")]
        public string QuestType { get; set; }
        [XmlElement("AnswerA")]
        public string AnswerA { get; set; }
        [XmlElement("AnswerB")]
        public string AnswerB { get; set; }
        [XmlElement("AnswerC")]
        public string AnswerC { get; set; }
        [XmlElement("AnswerD")]
        public string AnswerD { get; set; }
        [XmlElement("RightAnswer")]
        public string RightAnswer { get; set; }
        [XmlElement("Time")]
        public string Time { get; set; }

        public Question()
        {
            ID = "";
            AnswerB = "";
            AnswerD = "";
            AnswerA = "";
            AnswerC = "";
            Time = "0";
            Quest = "";
            QuestType = "1";
        }
    }

    [XmlRoot("QuestionList")]
    public class QuestionList
    {
        [XmlElement("Question", typeof(Question))]
        public List<Question> Questions { get; set; }
        public QuestionList()
        {
            Questions = new List<Question>();
        }
    }
}