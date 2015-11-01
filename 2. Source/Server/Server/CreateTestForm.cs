using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class CreateTestForm : Form
    {
        public QuestionList myQuestion = new QuestionList();

        public CreateTestForm()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is AccessForm);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbA.Enabled = true;
                tbB.Enabled = true;
                tbC.Enabled = true;
                tbD.Enabled = true;
            }
            else
            {
                tbA.Enabled = false;
                tbB.Enabled = false;
                tbC.Enabled = false;
                tbD.Enabled = false;
            }
        }

        private string output = "";
        private void btnExport_Click(object sender, EventArgs e)
        {
            output = "<QuestionList>";
            foreach (Question q in myQuestion.Questions)
            {
                output += "<Question>";
                output += "<ID>";
                output += q.ID;
                output += "</ID>";
                output += "<Quest>";
                output += q.Quest;
                output += "</Quest>";
                output += "<QuestType>";
                output += q.QuestType;
                output += "</QuestType>";
                output += "<AnswerA>";
                output += q.AnswerA;
                output += "</AnswerA>";
                output += "<AnswerB>";
                output += q.AnswerB;
                output += "</AnswerB>";
                output += "<AnswerC>";
                output += q.AnswerC;
                output += "</AnswerC>";
                output += "<AnswerD>";
                output += q.AnswerD;
                output += "</AnswerD>";
                output += "<RightAnswer>";
                output += q.RightAnswer;
                output += "</RightAnswer>";
                output += "<Time>";
                output += q.Time;
                output += "</Time>";
                output += "</Question>";
            }
            output += "</QuestionList>";

            saveFileDialog1.ShowDialog();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (tbQuest.Text != "") Save();
            // Get file name.
            string name = saveFileDialog1.FileName;
            saveFileDialog1.Filter = "NetTest Files | *.Nett";
            saveFileDialog1.DefaultExt = "Nett";
            // Write to the file name selected.
            // ... You can write the text from a TextBox instead of a string literal.
            File.WriteAllText(name, output);
        }

        private int count = 1;
        private int selectedQuestion = 1;

        private void Save()
        {
            string _id = lbNumber.Text;
            string _quest = tbQuest.Text;
            string _A = tbA.Text;
            string _B = tbB.Text;
            string _C = tbC.Text;
            string _D = tbD.Text;
            string _RA = tbAnswer.Text;
            string _time = numericUpDown1.Text;
            string _QT = "1";
            if (checkBox1.Checked == true) _QT = "2";
            myQuestion.Questions.Add(new Question { AnswerB = _B, Quest = _quest, AnswerA = _A, AnswerC = _C, AnswerD = _D, Time = _time, ID = _id, QuestType = _QT, RightAnswer = _RA });

            count++;
            lbTotal.Text = "/" + count.ToString();
            lbNumber.Text = "/" + count.ToString();
            ClearAll();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void ClearAll()
        {
            tbD.Text = "";
            tbA.Text = "";
            tbB.Text = "";
            tbC.Text = "";
            tbAnswer.Text = "";
            tbQuest.Text = "";
            checkBox1.Checked = false;
            numericUpDown1.Text = "0";
        }

        private void CreateTestForm_Deactivate(object sender, EventArgs e)
        {
        }
    }
}