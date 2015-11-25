using MyTransactionCode;
using MyTransactionCode.MyQuestion;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace NCKH3.Class
{
    public class MyClient
    {
        private int id = -1;
        private static int NEXT_ID_NUMBER = 0;
        private bool isRunning = false;
        private Server _currentForm;

        private int _idThread;
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private TcpClient _socket;

        private ServerTheadingManage _threadManage;
        private MySendFactory _mysendFactory;

        private List<string> _listQuestionAnswereds;

        public List<string> ListQuestionAnswereds
        {
            get { return _listQuestionAnswereds; }
            set { _listQuestionAnswereds = value; }
        }
        private int _currentIndexQuestion = -1;

        public MyClient(TcpClient socketClient, Server currentForm)
        {
            setCurrentForm(currentForm);
            id = NEXT_ID_NUMBER;
            NEXT_ID_NUMBER += 1;
            _socket = socketClient;
            isRunning = true;

            _threadManage = ServerTheadingManage.getInstance();
            _idThread = _threadManage.addNewWork(listenServer);
            _threadManage.startInstance(_idThread);

            _mysendFactory = new MySendFactory(_socket);
            _listQuestionAnswereds = new List<string>();
        }

        public int getId()
        {
            return id;
        }

        public void setCurrentForm(Server currentForm)
        {
            _currentForm = currentForm;
        }

        // listen message from server
        public void listenServer()
        {
            while (isRunning)
            {
                try
                {
                    NetworkStream networkStream = _socket.GetStream();
                    byte[] bytesFrom = new byte[10025];
                    networkStream.Read(bytesFrom, 0, (int)_socket.ReceiveBufferSize);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    processRequest(dataFromClient);
                }
                catch (Exception ex)
                {
                    Stop();
                    _currentForm.addToReceiverText(">> Client " + id + " đã ngắt kết nối");
                    MyLogSystem.Log(ex.ToString());
                }
            }
        }

        public void processRequest(string requestdata)
        {
            JObject jObject = JObject.Parse(requestdata);

            MyTransactionFactory factory = MyTransactionFactory.getInstance();
            MyBaseTransaction transaction = factory.createTransaction(jObject);

            switch (transaction.MyTransactioncode)
            {
                case Transaction_Code.cl_client_connect_infor:
                    string _password = _currentForm.getPassword();
                    MyTr_Client_Connect_Infor transactionoff = (MyTr_Client_Connect_Infor)transaction;
                    if (_password == transactionoff.password)
                    {
                        // if password is match
                        this.Username = transactionoff.username;
                        MyBaseTransaction info = new MyBaseTransaction();
                        info.MyTransactioncode = Transaction_Code.sv_login_accept;
                        _mysendFactory.sendJsonObject(info);
                        _currentForm.addClientToListView(this);

                        _currentForm.addToReceiverText(">> User có id: " + id + " có tên: " + username);
                    }
                    else
                    {
                        // if password not match
                        _currentForm.addToReceiverText(">> User có id: " + id + " thử kết nối nhưng không đúng mật khẩu.");
                        _mysendFactory.quickSendJsonObject(Transaction_Code.sv_incorrect_info);
                    }
                    break;
                case Transaction_Code.cl_disconnect:
                    Stop();
                    _currentForm.addToReceiverText(">> User " + username + "(" + id + ") đã ngắt kết nối!");
                    break;
                case Transaction_Code.cl_answer_question:
                    MyTr_Cl_AnswerQuestion trans_answer = new MyTr_Cl_AnswerQuestion();
                    trans_answer = factory.recreateMyTr_Cl_AnswerQuestion(jObject);
                    _currentForm.updateClientAnswer(this, trans_answer.Answer);
                    setClientAnswer(trans_answer.Answer, _currentIndexQuestion);
                    break;
            }
        }

        public void Stop()
        {
            _currentForm.removeClientFromListView(this);
            isRunning = false;
            _socket.Close();
            _threadManage.stopInstance(_idThread);
            MyClientManage manage = MyClientManage.getInstance();
            manage.RemoveClient(this);
        }

        internal void sendTransaction(MyBaseTransaction transaction)
        {
            if (transaction.MyTransactioncode == Transaction_Code.sv_question)
            {
                _currentIndexQuestion += 1;
            }
            _mysendFactory.sendJsonObject(transaction);
        }

        public void setMaxGroupAnswer(int maxQuestion)
        {
            ListQuestionAnswereds = new List<string>(maxQuestion);
            _currentIndexQuestion = -1;
            for (int i = 0; i < maxQuestion; i++)
            {
                ListQuestionAnswereds.Add("");
            }
        }

        public void setClientAnswer(string answer, int index)
        {
            ListQuestionAnswereds[index] = answer;
        }

        internal void writeResultToFile(string pathFile, MyGroupQuestion groupQuestion)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(pathFile, true);

            // Tên Client
            file.WriteLine("===========================");
            file.WriteLine("Tên: " + this.username);

            // Kết quả client
            for (int i = 0; i < ListQuestionAnswereds.Count; i++)
            {
                file.Write("Câu hỏi số: " + i + ". Đáp án: " +  ListQuestionAnswereds[i] + ", đáp án: " + groupQuestion.questions[i].Answer + ": ");

                string myClientAnswer = ListQuestionAnswereds[i];
                string myQuestionAnswer = groupQuestion.questions[i].Answer;

                if (groupQuestion.questions[i].isUpcase == false)
                {
                    myClientAnswer = myClientAnswer.ToLower();
                    myQuestionAnswer = myQuestionAnswer.ToLower();
                }

                if (myQuestionAnswer == myClientAnswer)
                {
                    file.WriteLine("Đúng");
                }
                else
                {
                    file.WriteLine("Sai");
                }
            }
            file.Close();
        }
    }
}
