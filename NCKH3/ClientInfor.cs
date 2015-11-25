using MyTransactionCode.MyQuestion;
using System;
using System.Windows.Forms;

namespace NCKH3
{
    public partial class ClientInfor : Form
    {
        public ClientInfor()
        {
            InitializeComponent();
        }

        private void ClientInfor_Load(object sender, EventArgs e)
        {

        }

        internal void updateInfor(Class.MyClient myClient, MyGroupQuestion groupQuestion)
        {
            lbUsername.Text = myClient.Username;
            lvListQuestionAnswer.Items.Clear();

            for (int i = 0; i < myClient.ListQuestionAnswereds.Count; i++)
            {
                ListViewItem item = new ListViewItem();

                item.Text = i.ToString();
                item.SubItems.Add(groupQuestion.questions[i].Question);

                switch (groupQuestion.questions[i].type)
                {
                    case MyQuestionType.MyMissingFieldQuestion:
                        item.SubItems.Add("Điền khuyết");
                        break;
                    case MyQuestionType.MyMultiChoiceQuestion:
                        item.SubItems.Add("Nhiều đáp án");
                        break;
                    case MyQuestionType.MyOneChoiceQuestion:
                        item.SubItems.Add("Chọn duy nhất");
                        break;
                }

                item.SubItems.Add(myClient.ListQuestionAnswereds[i]);
                item.SubItems.Add(groupQuestion.questions[i].Answer);

                checkClientAnswer(myClient, groupQuestion, i, item);

                lvListQuestionAnswer.Items.Add(item);
            }
        }

        private static void checkClientAnswer(Class.MyClient myClient, MyGroupQuestion groupQuestion, int i, ListViewItem item)
        {
            string myClientAnswer = myClient.ListQuestionAnswereds[i];
            string myQuestionAnswer = groupQuestion.questions[i].Answer;

            if (groupQuestion.questions[i].isUpcase == false)
            {
                myClientAnswer = myClientAnswer.ToLower();
                myQuestionAnswer = myQuestionAnswer.ToLower();
            }
            if (myQuestionAnswer == myClientAnswer)
            {
                item.SubItems.Add("Đúng");
            }
            else
            {
                item.SubItems.Add("Sai");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
