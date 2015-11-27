using MyTransactionCode.MyQuestion;
using Newtonsoft.Json.Linq;

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
        sv_login_accept = 7,

        sv_question = 8,
        cl_answer_question = 9,
        sv_end_questions = 10
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

    public class MyTr_Sv_Question : MyBaseTransaction
    {
        public MyTr_Sv_Question()
        {
            _myTransactioncode = Transaction_Code.sv_question;
        }

        public MyTr_Sv_Question(JObject question)
        {
            _question = new MyBaseQuestion();
            _myTransactioncode = Transaction_Code.sv_question;
            _question.Answer = question["Question"]["Answer"].ToString();
            _question.choiceA = question["Question"]["choiceA"].ToString();
            _question.choiceB = question["Question"]["choiceB"].ToString();
            _question.choiceC = question["Question"]["choiceC"].ToString();
            _question.choiceD = question["Question"]["choiceD"].ToString();
            _question.Question = question["Question"]["Question"].ToString();
            _question.Time = int.Parse(question["Question"]["Time"].ToString());
            _question.Score = int.Parse(question["Question"]["Score"].ToString());

            int type = int.Parse(question["Question"]["type"].ToString());

            switch (type)
            {
                case 1:
                    _question.type = MyQuestionType.MyOneChoiceQuestion;
                    break;
                case 2:
                    _question.type = MyQuestionType.MyMultiChoiceQuestion;
                    break;
                case 3:
                    _question.type = MyQuestionType.MyMissingFieldQuestion;
                    break;
            }
        }

        private MyBaseQuestion _question;

        public MyBaseQuestion Question
        {
            get { return _question; }
            set { _question = value; }
        }
    }

    public class MyTr_Cl_AnswerQuestion : MyBaseTransaction
    {
        public MyTr_Cl_AnswerQuestion()
        {
            MyTransactioncode = Transaction_Code.cl_answer_question;
        }

        public MyTr_Cl_AnswerQuestion(JObject question)
        {
            MyTransactioncode = Transaction_Code.cl_answer_question;
            this.Answer = question["Answer"].ToString();
        }

        public string Answer;
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
            string transaction_type = obj["MyTransactioncode"].ToString();
            MyBaseTransaction defaulttransaction = new MyBaseTransaction();

            switch (transaction_type)
            {
                case "1":
                    defaulttransaction.MyTransactioncode = Transaction_Code.cl_disconnect;
                    break;
                case "2":
                    MyTr_Client_Connect_Infor transaction = new MyTr_Client_Connect_Infor(obj["username"].ToString(), obj["password"].ToString());

                    return transaction;
                case "3":
                    defaulttransaction.MyTransactioncode = Transaction_Code.sv_disconnect;
                    break;
                case "4":
                    defaulttransaction.MyTransactioncode = Transaction_Code.sv_client_connect;
                    break;
                case "5":
                    defaulttransaction.MyTransactioncode = Transaction_Code.sv_client_disconnect;
                    break;
                case "6":
                    defaulttransaction.MyTransactioncode = Transaction_Code.sv_incorrect_info;
                    break;
                case "7":
                    defaulttransaction.MyTransactioncode = Transaction_Code.sv_login_accept;
                    break;
                case "8":
                    defaulttransaction.MyTransactioncode = Transaction_Code.sv_question;
                    return defaulttransaction;
                case "9":
                    defaulttransaction.MyTransactioncode = Transaction_Code.cl_answer_question;
                    break;
                case "10":
                    defaulttransaction.MyTransactioncode = Transaction_Code.sv_end_questions;
                    break;
            }
            return defaulttransaction;
        }

        public MyTr_Sv_Question recreateMyTr_Sv_Question(JObject jObject)
        {
            MyTr_Sv_Question transaction_question = new MyTr_Sv_Question(jObject);
            transaction_question.MyTransactioncode = Transaction_Code.sv_question;
            return transaction_question;
        }

        public MyTr_Cl_AnswerQuestion recreateMyTr_Cl_AnswerQuestion(JObject jObject)
        {
            MyTr_Cl_AnswerQuestion transaction_question = new MyTr_Cl_AnswerQuestion(jObject);
            transaction_question.MyTransactioncode = Transaction_Code.sv_question;
            return transaction_question;
        }
    }
}

