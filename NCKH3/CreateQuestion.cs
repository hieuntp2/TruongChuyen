using MyTransactionCode;
using MyTransactionCode.MyQuestion;
using NCKH3.Class;
using System;
using System.Windows.Forms;

namespace NCKH3
{
    public partial class CreateQuestion : Form
    {
        private MyGroupQuestion _groupquestion;
        private int _current_question_id = -1;
        public bool isNotSaved { get; set; }

        public CreateQuestion()
        {
            InitializeComponent();
        }

        private void CreateQuestion_Load(object sender, EventArgs e)
        {
            _groupquestion = null;
            //_groupquestion.Address = "D:/";
            tbAddress.Text = "D:/";

            //_groupquestion.Name = "Bộ câu hỏi 1";
            tbQuestionGroupName.Text = "Bộ câu hỏi 1";

            isNotSaved = false;
            //clearValue();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (checkInput() == false)
            {
                return;
            }

            if (_current_question_id == -1)
            {
                addNewQuestion();
            }
            else
            {
                updateQuestion();
            }

            clearFormTo();
        }

        private void updateQuestion()
        {
            MyBaseQuestion question = _groupquestion.getQuestion(_current_question_id);

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

            _groupquestion.updateQuestion(question);
        }

        private bool checkInput()
        {
            // kiểm tra rỗng
            // Nếu là câu hỏi điền khuyết thì chỉ kiểm tra 1 câu trả lời
            if (rbMissingField.Checked)
            {
                // kiểm tra rỗng
                if (string.IsNullOrWhiteSpace(tbQuestion.Text) ||
                    string.IsNullOrWhiteSpace(tbAddress.Text))
                {
                    MessageBox.Show("Có một số field đang để trống!");
                    return false;
                }
            }
            else
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

            // nếu câu hỏi là câu hỏi điền khuyết

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

            _groupquestion.addQuestion(question);
            addQuestionToLvQuestion(question);
        }

        private void addQuestionToLvQuestion(MyBaseQuestion question)
        {
            // Update ListView Question
            int idquestion = question.Id;

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

        private void btListQuestionDelete_Click(object sender, EventArgs e)
        {
            if (lvListQuestion.SelectedItems.Count == 0)
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

                if (question != null)
                {
                    _current_question_id = question.Id;
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
            _current_question_id = -1;

            _groupquestion = new MyGroupQuestion();
            lvListQuestion.Items.Clear();
        }

        public void clearFormTo()
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
            _current_question_id = -1;
            tbQuestion.Focus();
        }


        private void openFromFile_Click(object sender, EventArgs e)
        {
            try
            {
#if DEBUG
                Location = "D:/Bộ câu hỏi 1.json";
#else
                if (_groupquestion != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn lưu bạn hiện tại không?", "Lưu", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _groupquestion.SaveToFile(tbQuestionGroupName.Text, tbAddress.Text);
                    }

                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }

                clearValue();
                String Location = String.Empty;

                OpenFileDialog frm = new OpenFileDialog();
                frm.InitializeLifetimeService();
                frm.Filter = "Bộ đề (*.json)|*.json";
                frm.Title = "Browse Config file";
                DialogResult ret = STAShowDialog(frm);


                if (ret == DialogResult.OK)
                    Location = frm.FileName;
#endif
                if (Location != "")
                {
                    _groupquestion.LoadFromFile(Location);
                    updateListQuestions();
                    tbAddress.Text = Location;
                    _groupquestion.Address = Location;
                    tbQuestionGroupName.Text = _groupquestion.Name;

                    tbQuestion.Focus();
                }
            }
            catch (Exception ex)
            {
                MyLogSystem.Log(ex.ToString());
            }
        }

        private void updateListQuestions()
        {
            for (int i = 0; i < _groupquestion.questions.Count; i++)
            {
                addQuestionToLvQuestion(_groupquestion.questions[i]);
            }
        }

        private void newGroupQuestion_Click(object sender, EventArgs e)
        {
            clearValue();
            _groupquestion = new MyGroupQuestion();
        }

        private void lvListQuestion_DoubleClick(object sender, EventArgs e)
        {
            if (lvListQuestion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn câu hỏi nào!");
                return;
            }

            if (_current_question_id != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Lưu câu hỏi hiện tại?", "Lưu", MessageBoxButtons.YesNoCancel);
                if(dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                if (dialogResult == DialogResult.Yes)
                {
                    updateQuestion();
                }
            }

            clearFormTo();
            MyBaseQuestion question = _groupquestion.getQuestion(Int32.Parse(lvListQuestion.SelectedItems[0].Text));
            if (question != null)
            {
                _current_question_id = question.Id;
                loadQuestionToForm(question);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _groupquestion.SaveToFile(tbQuestionGroupName.Text, tbAddress.Text);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co muon luu bo cau hoi nay khong?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _groupquestion.SaveToFile(tbQuestionGroupName.Text, tbAddress.Text);
            }

            this.Close();
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

        private void lưuNhưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Location = String.Empty;
#if DEBUG
            Location = "D:/Bộ câu hỏi 1.json";
#else
            SaveFileDialog frm = new SaveFileDialog();
            frm.InitializeLifetimeService();
            frm.Filter = "Bộ đề (*.json)|*.json";
            frm.Title = "Browse Config file";
            DialogResult ret = STAShowDialog(frm);


            if (ret == DialogResult.OK)
            {
                Location = frm.FileName;
            }
#endif
            tbAddress.Text = Location;
            if (Location != "")
            {
                _groupquestion.SaveToFile(tbQuestionGroupName.Text, tbAddress.Text);
            }
        }

        private void rbOneChoice_CheckedChanged(object sender, EventArgs e)
        {
            gbAnswer.Show();
        }

        private void rbMultiQuestion_CheckedChanged(object sender, EventArgs e)
        {
            gbAnswer.Show();
        }

        private void rbMissingField_CheckedChanged(object sender, EventArgs e)
        {
            gbAnswer.Hide();
        }
    }
}
