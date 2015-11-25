using MyTransactionCode;
using MyTransactionCode.MyQuestion;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        private TcpClient clientSocket;
        private ClientSocketManage mysocketManage;
        private MySendFactory _mysendFactory;
        private bool isRunning = false;
        private Thread _listenFromServer = null;
        private MyBaseQuestion _currentQuestion = null;

        private string _answer = "";
        private bool _multi_aswer = false;

        public Client()
        {
            InitializeComponent();
            mysocketManage = ClientSocketManage.getInstance();
            clientSocket = mysocketManage.getSocket();
            _mysendFactory = new MySendFactory(clientSocket);

            isRunning = true;

            _listenFromServer = new Thread(listenFromServer);
            _listenFromServer.Start();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            hideAnswerGroup();
        }

        private void hideAnswerGroup()
        {
            gbFillMissingField.Hide();
            gbOneChoice.Hide();
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
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tbMessage.Text = my_new_text + Environment.NewLine;
            }
        }

        delegate void SetQuestionCallback(MyBaseQuestion question);

        public void updateQuestionToForm(MyBaseQuestion question)
        {
            if (this.txQuestion.InvokeRequired)
            {
                SetQuestionCallback d = new SetQuestionCallback(updateQuestionToForm);
                this.Invoke(d, new object[] { question });
            }
            else
            {
                _answer = "";
                clearAllAnswerButton();
                txQuestion.Text = _currentQuestion.Question;
                lbTime.Text = _currentQuestion.Time.ToString();

                switch (_currentQuestion.type)
                {
                    case MyQuestionType.MyMissingFieldQuestion:
                        lbType.Text = "Điền khuyết";
                        gbFillMissingField.Visible = true;
                        gbOneChoice.Visible = false;
                        tbClientAnswer.Focus();
                        break;
                    case MyQuestionType.MyOneChoiceQuestion:
                        lbType.Text = "Câu trả lời DUY NHẤT";
                        gbFillMissingField.Visible = false;
                        gbOneChoice.Visible = true;
                        _multi_aswer = false;
                        break;
                    case MyQuestionType.MyMultiChoiceQuestion:
                        lbType.Text = "Nhiều lựa chọn";
                        gbFillMissingField.Visible = false;
                        gbOneChoice.Visible = true;
                        _multi_aswer = true;
                        break;
                }

                btChoiseA.Text = _currentQuestion.choiceA;
                btChoiseB.Text = _currentQuestion.choiceB;
                btChoiseC.Text = _currentQuestion.choiceC;
                btChoiseD.Text = _currentQuestion.choiceD;

                pbTime.Maximum = _currentQuestion.Time;
                pbTime.Minimum = 0;
                pbTime.Value = 0;

                tmProcessBar.Enabled = true;
                tmProcessBar.Start();
                tmProcessBar.Interval = 1000;
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn đóng cửa sổ?", "Đóng cửa sổ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            stop();
        }

        private void listenFromServer()
        {
            while (isRunning)
            {
                try
                {
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesFrom = new byte[10025];
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    string dataFromClient = MyDecodeUnicode.DecodeFromUtf8(Encoding.Unicode.GetString(bytesFrom));

                    processRequest(dataFromClient);
                }
                catch (Exception ex)
                {
                    MyLogSystem.Log(ex.ToString());
                }
            }
        }

        private void processRequest(string dataFromClient)
        {
            JObject jObject = JObject.Parse(dataFromClient);

            MyTransactionFactory factory = MyTransactionFactory.getInstance();
            MyBaseTransaction transaction = factory.createTransaction(jObject);

            switch (transaction.MyTransactioncode)
            {
                case Transaction_Code.sv_disconnect:
                    // Nếu server đóng thì client cũng sẽ close session
                    MessageBox.Show("You has beend disconnect from server!");
                    stop();
                    break;
                case Transaction_Code.sv_question:
                    MyTr_Sv_Question transQuestion = factory.recreateMyTr_Sv_Question(jObject);
                    _currentQuestion = transQuestion.Question;
                    updateQuestionToForm(_currentQuestion);
                    break;
                case Transaction_Code.sv_end_questions:
                    MessageBox.Show("Bài kiểm tra đã kết thúc!");
                    clearAllAnswerButton();
                    break;
            }
        }

        private void stop()
        {
            MyBaseTransaction transaction = new MyBaseTransaction();
            transaction.MyTransactioncode = Transaction_Code.cl_disconnect;

            isRunning = false;
            _listenFromServer.Interrupt();
            _mysendFactory.sendJsonObject(transaction);
            mysocketManage.stopConnection();
        }

        private void tmProcessBar_Tick(object sender, EventArgs e)
        {
            if (_currentQuestion != null)
            {
                lbCurrentTime.Text = pbTime.Value.ToString();
                pbTime.Increment(1);

                if (_currentQuestion.Time == pbTime.Value)
                {
                    _currentQuestion = null;
                }
            }

        }

        // Client Answer Question

        private void btChoiseA_Click(object sender, EventArgs e)
        {
            UpdateClientAnswerForm("A");

            revertAnswerButtonColor(btChoiseA, btChoiseA_);
        }

        private void revertAnswerButtonColor(Button bt1, Button bt2)
        {
            if (_currentQuestion != null)
            {
                if (_currentQuestion.type == MyQuestionType.MyMultiChoiceQuestion)
                {
                    if (bt1.BackColor == Color.MediumSlateBlue)
                    {
                        bt1.BackColor = DefaultBackColor;
                        bt2.BackColor = DefaultBackColor;
                    }
                    else
                    {
                        bt1.BackColor = Color.MediumSlateBlue;
                        bt2.BackColor = Color.MediumSlateBlue;
                    }
                }
            }

        }

        private void btChoiseB_Click(object sender, EventArgs e)
        {
            UpdateClientAnswerForm("B");
            revertAnswerButtonColor(btChoiseB, btChoiseB_);
        }

        private void btChoiseC_Click(object sender, EventArgs e)
        {
            UpdateClientAnswerForm("C");
            revertAnswerButtonColor(btChoiseC, btChoiseC_);
        }

        private void btChoiseD_Click(object sender, EventArgs e)
        {
            UpdateClientAnswerForm("D");
            revertAnswerButtonColor(btChoiseD, btChoiseD_);
        }

        private void UpdateClientAnswerForm(string answer)
        {
            if (_multi_aswer)
            {

            }
            else
            {
                clearAllAnswerButton();
                _answer = answer;
                switch (answer)
                {
                    case "A":
                        btChoiseA.BackColor = Color.MediumSlateBlue;
                        btChoiseA_.BackColor = Color.MediumSlateBlue;
                        break;
                    case "B":
                        btChoiseB.BackColor = Color.MediumSlateBlue;
                        btChoiseB_.BackColor = Color.MediumSlateBlue;
                        break;
                    case "C":
                        btChoiseC.BackColor = Color.MediumSlateBlue;
                        btChoiseC_.BackColor = Color.MediumSlateBlue;
                        break;
                    case "D":
                        btChoiseD.BackColor = Color.MediumSlateBlue;
                        btChoiseD_.BackColor = Color.MediumSlateBlue;
                        break;
                }
            }
        }

        private void clearAllAnswerButton()
        {
            btChoiseA.BackColor = DefaultBackColor;
            btChoiseB.BackColor = DefaultBackColor;
            btChoiseC.BackColor = DefaultBackColor;
            btChoiseD.BackColor = DefaultBackColor;
            btChoiseA_.BackColor = DefaultBackColor;
            btChoiseB_.BackColor = DefaultBackColor;
            btChoiseC_.BackColor = DefaultBackColor;
            btChoiseD_.BackColor = DefaultBackColor;
        }

        private void sendAnswer_Click(object sender, EventArgs e)
        {
            if (_currentQuestion != null)
            {
                _answer = createAnswer();
                if (_answer != "")
                {
                    MyTr_Cl_AnswerQuestion transaction = new MyTr_Cl_AnswerQuestion();
                    transaction.Answer = _answer;
                    transaction.MyTransactioncode = Transaction_Code.cl_answer_question;
                    _mysendFactory.sendJsonObject(transaction);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn đáp án!");
                }
            }
            else
            {
                MessageBox.Show("Chưa có câu hỏi hoặc thời gian đã hết!");
            }

        }

        private string createAnswer()
        {
            string _my_aswer = "";
            switch (_currentQuestion.type)
            {
                case MyQuestionType.MyMissingFieldQuestion:
                    _my_aswer = tbClientAnswer.Text;
                    break;
                case MyQuestionType.MyMultiChoiceQuestion:
                    if (btChoiseA.BackColor == Color.MediumSlateBlue)
                    {
                        _my_aswer += "A ";
                    }
                    if (btChoiseB.BackColor == Color.MediumSlateBlue)
                    {
                        _my_aswer += "B ";
                    }
                    if (btChoiseC.BackColor == Color.MediumSlateBlue)
                    {
                        _my_aswer += "C ";
                    }
                    if (btChoiseD.BackColor == Color.MediumSlateBlue)
                    {
                        _my_aswer += "D ";
                    }
                    break;
                case MyQuestionType.MyOneChoiceQuestion:
                    _my_aswer = _answer;
                    break;
            }

            return _my_aswer.Trim();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn đóng cửa sổ?", "Đóng cửa sổ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}
