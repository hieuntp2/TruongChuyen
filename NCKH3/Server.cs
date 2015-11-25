using MyTransactionCode;
using MyTransactionCode.MyQuestion;
using NCKH3.Class;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace NCKH3
{
    public partial class Server : Form
    {
        private SvListenAcceptClient _myListenAccept;
        private Thread _sthreadAcceptClient;
        private TcpListener serverSocket;
        private MyClientManage _myClientManage;
        private ServerTheadingManage _threadmanage = null;
        private MyBaseQuestion _currentQuestion = null;

        private MyGroupQuestion _groupquestion;

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            serverSocket = new TcpListener(8888);
            serverSocket.Start();

            _threadmanage = ServerTheadingManage.getInstance();

            _myClientManage = MyClientManage.getInstance();
            _myClientManage.setCurrentForm(this);

            _myListenAccept = SvListenAcceptClient.getInstance(serverSocket);
            _sthreadAcceptClient = new Thread(_myListenAccept.task);
            _myListenAccept.start();
            _myListenAccept.setForm(this);
            _sthreadAcceptClient.Start();

            tbPassword.Text = "";

            cleanGroupQuestion();
            lbServerIP.Text = GetLocalIPAddress();
            this.addToReceiverText(">> Server đã khởi động xong.");
        }

        private void cleanGroupQuestion()
        {
            lbNumberQuestion.Text = "0";
            lbTotalQuestion.Text = "0";
            lbGroupName.Text = "CHƯA MỞ BỘ CÂU HỎI";
            lbType.Text = "";
            lbAnswer.Text = "";
            cleanBtAnswer();
            _groupquestion = null;
            lbTime.Text = "0";
            lbCurrentTime.Text = "0";
        }

        private void cleanBtAnswer()
        {
            btChoiseA.Text = "";
            btChoiseB.Text = "";
            btChoiseC.Text = "";
            btChoiseD.Text = "";
        }

        delegate void SetTextCallback(string text);
        delegate void SetLvClientCallback(MyClient client);

        public void addToReceiverText(string text)
        {
            string my_new_text = tbMessage.Text + text;
            if (this.tbMessage.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(addToReceiverText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tbMessage.Text = my_new_text + Environment.NewLine;
            }
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }

        internal string getPassword()
        {
            return tbPassword.Text;
        }

        private void Stop()
        {
            // Send a message to all client that server has been stopped
            MyBaseTransaction tr_disconect = new MyBaseTransaction();
            tr_disconect.MyTransactioncode = Transaction_Code.sv_disconnect;
            _myClientManage.sendToAll(tr_disconect);

            serverSocket.Stop();
            _myListenAccept.stop();
            _threadmanage.StopManage();
        }

        /// <summary>
        /// Thêm một client vào danh sách user
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public void addClientToListView(MyClient client)
        {
            //ListViewItem item = new ListViewItem();
            //item.Text = client.Username;
            //item.Tag = client.getId();
            //item.SubItems.Add("");

            //lvClients.Items.Add(item);

            MyClient my_new_text = client;
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbMessage.InvokeRequired)
            {
                SetLvClientCallback d = new SetLvClientCallback(addClientToListView);
                this.Invoke(d, new object[] { client });
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.Username;
                item.Tag = client.getId();
                item.SubItems.Add("");

                lvClients.Items.Add(item);
            }
        }

        /// <summary>
        /// Xóa client ra khỏi listview
        /// </summary>
        /// <param name="client"></param>
        public void removeClientFromListView(MyClient client)
        {
            MyClient my_new_text = client;
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tbMessage.InvokeRequired)
            {
                SetLvClientCallback d = new SetLvClientCallback(removeClientFromListView);
                this.Invoke(d, new object[] { client });
            }
            else
            {
                for (int i = 0; i < lvClients.Items.Count; i++)
                {
                    int id = (int)lvClients.Items[i].Tag;

                    if (id == client.getId())
                    {
                        lvClients.Items.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        delegate void SetClientAnswerCallback(MyClient client, string answer);

        /// <summary>
        /// Update câu trả lời cho client
        /// </summary>
        /// <param name="client"></param>
        public void updateClientAnswer(MyClient client, string answer)
        {
            if (this.tbMessage.InvokeRequired)
            {
                SetClientAnswerCallback d = new SetClientAnswerCallback(updateClientAnswer);
                this.Invoke(d, new object[] { client, answer });
            }
            else
            {
                for (int i = 0; i < lvClients.Items.Count; i++)
                {
                    int id = (int)lvClients.Items[i].Tag;

                    if (id == client.getId())
                    {
                        lvClients.Items[i].SubItems[1].Text = answer;
                        break;
                    }
                }
            }
        }

        private void clearListViewUserAnswer()
        {
            for (int i = 0; i < lvClients.Items.Count; i++)
            {

                lvClients.Items[i].SubItems[1].Text = "";
            }
        }

        private void btLoadGroupQuestion_Click(object sender, EventArgs e)
        {
            if (_groupquestion != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn thay thế bộ câu hỏi hiện tại?", "Mở bộ câu hỏi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

#if DEBUG
            openGroupQuestion("D:/Bộ câu hỏi 1.json");
#else
              String Location = String.Empty;
            OpenFileDialog frm = new OpenFileDialog();
            frm.InitializeLifetimeService();
            frm.Filter = "Bộ đề (*.json)|*.json";
            frm.Title = "Browse Config file";
            DialogResult ret = STAShowDialog(frm);


            if (ret == DialogResult.OK)
                Location = frm.FileName;
            if (Location != "")
            {
                openGroupQuestion(Location);
            }   
#endif

        }

        private void openGroupQuestion(string path)
        {
            _groupquestion = new MyGroupQuestion();
            _groupquestion.LoadFromFile(path);

            lbGroupName.Text = _groupquestion.name;

            lbTotalQuestion.Text = _groupquestion.questions.Count.ToString();
            lbNumberQuestion.Text = "0";
            setMaxQuestiontoClient();
        }

        private void btStartTest_Click(object sender, EventArgs e)
        {
            if (_groupquestion == null)
            {
                MessageBox.Show("Bạn chưa mở bộ câu hỏi!");
                return;
            }

            openNextQuestion();
        }

        private void btNextQuestion_Click(object sender, EventArgs e)
        {
            if (_groupquestion == null)
            {
                MessageBox.Show("Bạn chưa mở bộ câu hỏi nào!");
                return;
            }
            openNextQuestion();
        }

        private void openNextQuestion()
        {
            _currentQuestion = _groupquestion.getNextQuestion();

            if (_currentQuestion == null)
            {
                MessageBox.Show("Đã hết bộ câu hỏi");
                //cleanGroupQuestion();
                _myClientManage.sendToAll(Transaction_Code.sv_end_questions);

                return;
            }
            lbNumberQuestion.Text = (_groupquestion.CurrentIndexQuestion + 1).ToString();
            updateCurrentQuestionToForm(_currentQuestion);
            sendQuestionToClient(_currentQuestion);
            clearListViewUserAnswer();
        }

        private void sendQuestionToClient(MyBaseQuestion _currentQuestion)
        {
            MyTr_Sv_Question tras = new MyTr_Sv_Question();
            tras.Question = _currentQuestion;
            _myClientManage.sendToAll(tras);
        }

        private void updateCurrentQuestionToForm(MyBaseQuestion question)
        {
            txQuestion.Text = question.Question;
            lbAnswer.Text = question.Answer;
            lbTime.Text = question.Time.ToString();

            switch (question.type)
            {
                case MyQuestionType.MyMissingFieldQuestion:
                    lbType.Text = "Điền khuyết";
                    break;
                case MyQuestionType.MyOneChoiceQuestion:
                    lbType.Text = "Câu trả lời DUY NHẤT";
                    break;
                case MyQuestionType.MyMultiChoiceQuestion:
                    lbType.Text = "Nhiều lựa chọn";
                    break;
            }

            btChoiseA.Text = question.choiceA;
            btChoiseB.Text = question.choiceB;
            btChoiseC.Text = question.choiceC;
            btChoiseD.Text = question.choiceD;

            pbTime.Maximum = question.Time;
            pbTime.Minimum = 0;
            pbTime.Value = 0;

            tmProcessBar.Enabled = true;
            tmProcessBar.Start();
            tmProcessBar.Interval = 1000;
        }

        private void tmProcessBar_Tick(object sender, EventArgs e)
        {
            if (_currentQuestion != null)
            {
                lbCurrentTime.Text = pbTime.Value.ToString();
                if (pbTime.Value == _currentQuestion.Time)
                {
                    if (cbAutoNextQuestion.Checked)
                    {
                        openNextQuestion();
                    }
                    else
                    {
                        tmProcessBar.Enabled = false;
                    }
                }
                pbTime.Increment(1);
            }
        }

        private void setMaxQuestiontoClient()
        {
            _myClientManage.setMaxQuestion(_groupquestion.questions.Count);
        }

        private void lvClients_DoubleClick(object sender, EventArgs e)
        {
            ClientInfor form = new ClientInfor();
            _myClientManage.showClientInfor(int.Parse(lvClients.SelectedItems[0].Tag.ToString()), _groupquestion);
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn đóng cửa sổ?", "Đóng cửa sổ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEndGroupQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveResultToFile_Click(object sender, EventArgs e)
        {
            if(_groupquestion != null)
            {
                string pathFile = "D:/test_result.txt";
                System.IO.StreamWriter file = new System.IO.StreamWriter(pathFile, true);
                file.WriteLine("Bộ câu hỏi: " + _groupquestion.name + " số lượng: " + _groupquestion.questions.Count);
                file.WriteLine("Ngày kiểm tra: " + DateTime.Now);
                file.Close();
                _myClientManage.writeResultToFile(pathFile, _groupquestion);

                System.IO.StreamWriter file2 = new System.IO.StreamWriter(pathFile, true);
                file2.WriteLine("**************************");
                file2.WriteLine("**************************");
                file2.Close();
                MessageBox.Show("Đã ghi xong file kết quả!");
            }
            else
            {
                MessageBox.Show("Chưa có bộ câu hỏi!");
            }
            
        }

        /* STAShowDialog takes a FileDialog and shows it on a background STA thread and returns the results.
      * Usage:
      *   OpenFileDialog d = new OpenFileDialog();
      *   DialogResult ret = STAShowDialog(d);
      *   if (ret == DialogResult.OK)
      *      MessageBox.Show(d.FileName);
      */
        private DialogResult STAShowDialog(FileDialog dialog)
        {
            DialogState state = new DialogState();
            state.dialog = dialog;
            System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.Join();
            return state.result;
        }
    }
}
