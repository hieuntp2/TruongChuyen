using MyTransactionCode.MyQuestion;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH3
{
    public partial class CreateQuestion : Form
    {
        private MyGroupQuestion _groupquestion;
        public CreateQuestion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CreateQuestion_Load(object sender, EventArgs e)
        {
            _groupquestion = new MyGroupQuestion();
            _groupquestion.Address = "D:/";
            tbAddress.Text = "D:/";

            _groupquestion.Name = "Bộ câu hỏi 1";
            tbQuestionGroupName.Text = "Bộ câu hỏi 1";

            clearValue();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (checkInput() == false)
            {
                return;
            }
            addNewQuestion();
            clearValue();
        }

        private bool checkInput()
        {
            // kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(tbQuestion.Text) ||
                string.IsNullOrWhiteSpace(tbChoiceA.Text) ||
                string.IsNullOrWhiteSpace(tbChoiceB.Text) ||
                string.IsNullOrWhiteSpace(tbChoiceC.Text) ||
                string.IsNullOrWhiteSpace(tbChoiceD.Text) ||
                string.IsNullOrWhiteSpace(tbAnswer.Text))
            {
                MessageBox.Show("Có một số field đang để trống!");
                return false;
            }

            // kiểm tra đáp án dựa vào loại
            if (rbOneChoice.Checked)
            {
                // Nếu là câu hỏi 1 đáp án thì kiểm tra đáp án
                if (tbAnswer.Text.Length > 1)
                {
                    MessageBox.Show("Câu trả lời chứa nhiều hơn 1 đáp án vì câu hỏi là câu hỏi trả lời duy nhất! Đáp án chỉ chứa 1 ký tự là A/B/C/D");
                    return false;
                }
                else
                {
                    char _answer;
                    // Kiểm tra xem kết quả có cho phép chữ hoa/thường
                    if (rdExactlyChoise.Checked)
                    {
                        _answer = tbAnswer.Text[0];
                    }
                    else
                    {
                        _answer = tbAnswer.Text.ToUpper()[0];
                    }

                    if (_answer == 'A' ||
                        _answer == 'B' ||
                        _answer == 'C' ||
                        _answer == 'D')
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Đáp án chỉ chứa 1 ký tự là A/B/C/D");
                        return false;
                    }
                }
            }

            // Kiểm tra loại câu hỏi nhiều đáp án
            if (rbMultiQuestion.Checked)
            {

            }

            // Kiểm tra câu hỏi điền khuyết
            if (rbMissingField.Checked)
            {

            }
            return true;
        }

        private void addNewQuestion()
        {
            MyBaseQuestion question = new MyBaseQuestion();

            question.Question = tbQuestion.Text;
            question.Time = (int)tbTime.Value;
            question.choiceA = tbChoiceA.Text;
            question.choiceB = tbChoiceB.Text;
            question.choiceC = tbChoiceC.Text;
            question.choiceD = tbChoiceD.Text;

            question.Answer = tbAnswer.Text;

            if (rbdNotExactlyChoice.Checked)
            {
                question.isUpcase = true;
            }
            else
            {
                question.isUpcase = false;
            }

            if (rbOneChoice.Checked)
            {
                question.type = MyQuestionType.MyOneChoiceQuestion;
            }
            if (rbMultiQuestion.Checked)
            {
                question.type = MyQuestionType.MyMultiChoiceQuestion;
            }
            if (rbMissingField.Checked)
            {
                question.type = MyQuestionType.MyMissingFieldQuestion;
            }

            // Update ListView Question
            int idquestion = _groupquestion.addQuestion(question);

            ListViewItem item = new ListViewItem();
            item.Text = idquestion.ToString();

            if (question.Question.Length > 20)
            {
                item.SubItems.Add(question.Question.Substring(0, 20));
            }
            else
            {
                item.SubItems.Add(question.Question);
            }

            lvListQuestion.Items.Add(item);
        }

        private void btSaveFileDialog_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    System.IO.StreamReader sr = new
            //       System.IO.StreamReader(saveFileDialog1.FileName);
            //    MessageBox.Show(sr.ReadToEnd());

            //    saveFileDialog1.FileName = _groupquestion.Name;
            //    saveFileDialog1.DefaultExt = "json";

            //    sr.Close();
            //}
        }

        private void btListQuestionDelete_Click(object sender, EventArgs e)
        {
            if(lvListQuestion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn câu hỏi nào!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa câu hỏi này?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _groupquestion.removeQuestion(Int16.Parse(lvListQuestion.SelectedItems[0].Text));
                lvListQuestion.Items.RemoveAt(lvListQuestion.SelectedItems[0].Index);
            }
            
        }

        private void btListQuestionEdit_Click(object sender, EventArgs e)
        {
            if (lvListQuestion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn câu hỏi nào!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn chỉnh sửa câu hỏi này? /n Mọi thông tin câu hỏi hiện tại sẽ bị thay đổi!", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MyBaseQuestion question = _groupquestion.getQuestion(Int32.Parse(lvListQuestion.SelectedItems[0].Text));

                if(question != null)
                {
                    loadQuestionToForm(question);
                }
            }
        }

        public void loadQuestionToForm(MyBaseQuestion question)
        {
            tbQuestion.Text = question.Question;
            tbAnswer.Text = question.Answer;
            tbChoiceA.Text = question.choiceA;
            tbChoiceB.Text = question.choiceB;
            tbChoiceC.Text = question.choiceC;
            tbChoiceD.Text = question.choiceD;

            tbTime.Value = question.Time;

            switch (question.type)
            {
                case MyQuestionType.MyMissingFieldQuestion:
                    rbMissingField.Checked = true;
                    break;
                case MyQuestionType.MyMultiChoiceQuestion:
                    rbMultiQuestion.Checked = true;
                    break;
                case MyQuestionType.MyOneChoiceQuestion:
                    rbOneChoice.Checked = true;
                    break;
                default:
                    MessageBox.Show("Không tìm thấy loại câu hỏi!");
                    break;
            }

            if (question.isUpcase)
            {
                rdExactlyChoise.Checked = true;
            }
            else
            {
                rbdNotExactlyChoice.Checked = true;
            }
        }

        public void clearValue()
        {
            tbQuestion.Text = "";
            tbAnswer.Text = "";
            tbChoiceA.Text = "";
            tbChoiceB.Text = "";
            tbChoiceC.Text = "";
            tbChoiceD.Text = "";

            tbTime.Value = 30;

            rbOneChoice.Checked = true;

            rbdNotExactlyChoice.Checked = true;
            rdExactlyChoise.Checked = false;
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            _groupquestion.SaveToFile();
        }

        private void openFromFile_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.json)|*.json|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            {
                // Open the selected file to read.
                string pathFile = openFileDialog1.FileName;
                string data = System.IO.File.ReadAllText(pathFile);
                JObject jobject = JObject.Parse(data);

                _groupquestion.convertFromJObjcet(jobject);
            }          
        }
    }
}
