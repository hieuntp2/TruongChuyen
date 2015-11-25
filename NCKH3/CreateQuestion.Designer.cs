namespace NCKH3
{
    partial class CreateQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbChoiceA = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGroupQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuNhưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bộCâuHỏiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMultiQuestion = new System.Windows.Forms.RadioButton();
            this.rbMissingField = new System.Windows.Forms.RadioButton();
            this.rbOneChoice = new System.Windows.Forms.RadioButton();
            this.gbOneChoiceQuestion = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdExactlyChoise = new System.Windows.Forms.RadioButton();
            this.rbdNotExactlyChoice = new System.Windows.Forms.RadioButton();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.NumericUpDown();
            this.gbAnswer = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbChoiceB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbChoiceC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbChoiceD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbQuestionGroupName = new System.Windows.Forms.TextBox();
            this.lvListQuestion = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btListQuestionEdit = new System.Windows.Forms.Button();
            this.btListQuestionDelete = new System.Windows.Forms.Button();
            this.gbFillMissingField = new System.Windows.Forms.GroupBox();
            this.tbClientAnswer = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOneChoiceQuestion.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).BeginInit();
            this.gbAnswer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbFillMissingField.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbChoiceA
            // 
            this.tbChoiceA.Location = new System.Drawing.Point(33, 19);
            this.tbChoiceA.Multiline = true;
            this.tbChoiceA.Name = "tbChoiceA";
            this.tbChoiceA.Size = new System.Drawing.Size(652, 20);
            this.tbChoiceA.TabIndex = 0;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(168, 457);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(88, 28);
            this.btCreate.TabIndex = 1;
            this.btCreate.Text = "Hoàn thành";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bộ câu hỏi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bộCâuHỏiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGroupQuestion,
            this.toolStripSeparator1,
            this.openFromFile,
            this.toolStripSeparator3,
            this.saveFileToolStripMenuItem,
            this.lưuNhưToolStripMenuItem,
            this.toolStripSeparator2,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGroupQuestion
            // 
            this.newGroupQuestion.Name = "newGroupQuestion";
            this.newGroupQuestion.Size = new System.Drawing.Size(153, 22);
            this.newGroupQuestion.Text = "Tạo bộ câu hỏi";
            this.newGroupQuestion.Click += new System.EventHandler(this.newGroupQuestion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // openFromFile
            // 
            this.openFromFile.Name = "openFromFile";
            this.openFromFile.Size = new System.Drawing.Size(153, 22);
            this.openFromFile.Text = "Mở bộ câu hỏi";
            this.openFromFile.Click += new System.EventHandler(this.openFromFile_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(150, 6);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveFileToolStripMenuItem.Text = "Lưu";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // lưuNhưToolStripMenuItem
            // 
            this.lưuNhưToolStripMenuItem.Name = "lưuNhưToolStripMenuItem";
            this.lưuNhưToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.lưuNhưToolStripMenuItem.Text = "Lưu bản khác";
            this.lưuNhưToolStripMenuItem.Click += new System.EventHandler(this.lưuNhưToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // bộCâuHỏiToolStripMenuItem
            // 
            this.bộCâuHỏiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaToolStripMenuItem});
            this.bộCâuHỏiToolStripMenuItem.Name = "bộCâuHỏiToolStripMenuItem";
            this.bộCâuHỏiToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bộCâuHỏiToolStripMenuItem.Text = "Bộ câu hỏi";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.chỉnhSửaToolStripMenuItem.Text = "Thuộc tính";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMultiQuestion);
            this.groupBox1.Controls.Add(this.rbMissingField);
            this.groupBox1.Controls.Add(this.rbOneChoice);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại câu hỏi";
            // 
            // rbMultiQuestion
            // 
            this.rbMultiQuestion.AutoSize = true;
            this.rbMultiQuestion.Location = new System.Drawing.Point(6, 65);
            this.rbMultiQuestion.Name = "rbMultiQuestion";
            this.rbMultiQuestion.Size = new System.Drawing.Size(90, 17);
            this.rbMultiQuestion.TabIndex = 8;
            this.rbMultiQuestion.TabStop = true;
            this.rbMultiQuestion.Text = "Nhiều đáp án";
            this.rbMultiQuestion.UseVisualStyleBackColor = true;
            this.rbMultiQuestion.CheckedChanged += new System.EventHandler(this.rbMultiQuestion_CheckedChanged);
            // 
            // rbMissingField
            // 
            this.rbMissingField.AutoSize = true;
            this.rbMissingField.Location = new System.Drawing.Point(6, 42);
            this.rbMissingField.Name = "rbMissingField";
            this.rbMissingField.Size = new System.Drawing.Size(82, 17);
            this.rbMissingField.TabIndex = 7;
            this.rbMissingField.TabStop = true;
            this.rbMissingField.Text = "Điền khuyết";
            this.rbMissingField.UseVisualStyleBackColor = true;
            this.rbMissingField.CheckedChanged += new System.EventHandler(this.rbMissingField_CheckedChanged);
            // 
            // rbOneChoice
            // 
            this.rbOneChoice.AutoSize = true;
            this.rbOneChoice.Location = new System.Drawing.Point(6, 19);
            this.rbOneChoice.Name = "rbOneChoice";
            this.rbOneChoice.Size = new System.Drawing.Size(68, 17);
            this.rbOneChoice.TabIndex = 6;
            this.rbOneChoice.TabStop = true;
            this.rbOneChoice.Text = "1 đán án";
            this.rbOneChoice.UseVisualStyleBackColor = true;
            this.rbOneChoice.CheckedChanged += new System.EventHandler(this.rbOneChoice_CheckedChanged);
            // 
            // gbOneChoiceQuestion
            // 
            this.gbOneChoiceQuestion.Controls.Add(this.gbFillMissingField);
            this.gbOneChoiceQuestion.Controls.Add(this.groupBox4);
            this.gbOneChoiceQuestion.Controls.Add(this.gbAnswer);
            this.gbOneChoiceQuestion.Controls.Add(this.groupBox2);
            this.gbOneChoiceQuestion.Location = new System.Drawing.Point(168, 27);
            this.gbOneChoiceQuestion.Name = "gbOneChoiceQuestion";
            this.gbOneChoiceQuestion.Size = new System.Drawing.Size(740, 419);
            this.gbOneChoiceQuestion.TabIndex = 0;
            this.gbOneChoiceQuestion.TabStop = false;
            this.gbOneChoiceQuestion.Text = "Nội dung câu hỏi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.rdExactlyChoise);
            this.groupBox4.Controls.Add(this.rbdNotExactlyChoice);
            this.groupBox4.Controls.Add(this.tbAnswer);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbTime);
            this.groupBox4.Location = new System.Drawing.Point(9, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(725, 100);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đáp án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "(s)";
            // 
            // rdExactlyChoise
            // 
            this.rdExactlyChoise.AutoSize = true;
            this.rdExactlyChoise.Location = new System.Drawing.Point(470, 42);
            this.rdExactlyChoise.Name = "rdExactlyChoise";
            this.rdExactlyChoise.Size = new System.Drawing.Size(206, 17);
            this.rdExactlyChoise.TabIndex = 21;
            this.rdExactlyChoise.TabStop = true;
            this.rdExactlyChoise.Text = "Phân biệt chữ hoa-thường (Chính xác)";
            this.rdExactlyChoise.UseVisualStyleBackColor = true;
            // 
            // rbdNotExactlyChoice
            // 
            this.rbdNotExactlyChoice.AutoSize = true;
            this.rbdNotExactlyChoice.Location = new System.Drawing.Point(470, 19);
            this.rbdNotExactlyChoice.Name = "rbdNotExactlyChoice";
            this.rbdNotExactlyChoice.Size = new System.Drawing.Size(181, 17);
            this.rbdNotExactlyChoice.TabIndex = 20;
            this.rbdNotExactlyChoice.TabStop = true;
            this.rbdNotExactlyChoice.Text = "Không phân biệt chữ hoa thường";
            this.rbdNotExactlyChoice.UseVisualStyleBackColor = true;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(69, 27);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(376, 20);
            this.tbAnswer.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Câu trả lời:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thời gian";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(69, 67);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(120, 20);
            this.tbTime.TabIndex = 1;
            this.tbTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // gbAnswer
            // 
            this.gbAnswer.Controls.Add(this.tbChoiceA);
            this.gbAnswer.Controls.Add(this.label5);
            this.gbAnswer.Controls.Add(this.label6);
            this.gbAnswer.Controls.Add(this.tbChoiceB);
            this.gbAnswer.Controls.Add(this.label7);
            this.gbAnswer.Controls.Add(this.tbChoiceC);
            this.gbAnswer.Controls.Add(this.label8);
            this.gbAnswer.Controls.Add(this.tbChoiceD);
            this.gbAnswer.Location = new System.Drawing.Point(9, 182);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(728, 125);
            this.gbAnswer.TabIndex = 1;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "Trả lời";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "C";
            // 
            // tbChoiceB
            // 
            this.tbChoiceB.Location = new System.Drawing.Point(34, 45);
            this.tbChoiceB.Multiline = true;
            this.tbChoiceB.Name = "tbChoiceB";
            this.tbChoiceB.Size = new System.Drawing.Size(652, 20);
            this.tbChoiceB.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "B";
            // 
            // tbChoiceC
            // 
            this.tbChoiceC.Location = new System.Drawing.Point(33, 68);
            this.tbChoiceC.Multiline = true;
            this.tbChoiceC.Name = "tbChoiceC";
            this.tbChoiceC.Size = new System.Drawing.Size(652, 20);
            this.tbChoiceC.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "A";
            // 
            // tbChoiceD
            // 
            this.tbChoiceD.Location = new System.Drawing.Point(34, 95);
            this.tbChoiceD.Multiline = true;
            this.tbChoiceD.Name = "tbChoiceD";
            this.tbChoiceD.Size = new System.Drawing.Size(652, 20);
            this.tbChoiceD.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbQuestion);
            this.groupBox2.Location = new System.Drawing.Point(9, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 160);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Câu hỏi";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(6, 14);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(710, 140);
            this.tbQuestion.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xóa nội dung";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbQuestionGroupName
            // 
            this.tbQuestionGroupName.Location = new System.Drawing.Point(12, 43);
            this.tbQuestionGroupName.Name = "tbQuestionGroupName";
            this.tbQuestionGroupName.Size = new System.Drawing.Size(150, 20);
            this.tbQuestionGroupName.TabIndex = 10;
            // 
            // lvListQuestion
            // 
            this.lvListQuestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.question});
            this.lvListQuestion.Location = new System.Drawing.Point(12, 237);
            this.lvListQuestion.Name = "lvListQuestion";
            this.lvListQuestion.Size = new System.Drawing.Size(150, 214);
            this.lvListQuestion.TabIndex = 13;
            this.lvListQuestion.UseCompatibleStateImageBehavior = false;
            this.lvListQuestion.View = System.Windows.Forms.View.Details;
            this.lvListQuestion.DoubleClick += new System.EventHandler(this.lvListQuestion_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 25;
            // 
            // question
            // 
            this.question.Text = "Câu hỏi";
            this.question.Width = 119;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(434, 457);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(474, 20);
            this.tbAddress.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "File address";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btListQuestionEdit
            // 
            this.btListQuestionEdit.Location = new System.Drawing.Point(12, 457);
            this.btListQuestionEdit.Name = "btListQuestionEdit";
            this.btListQuestionEdit.Size = new System.Drawing.Size(74, 28);
            this.btListQuestionEdit.TabIndex = 24;
            this.btListQuestionEdit.Text = "Sửa";
            this.btListQuestionEdit.UseVisualStyleBackColor = true;
            this.btListQuestionEdit.Click += new System.EventHandler(this.btListQuestionEdit_Click);
            // 
            // btListQuestionDelete
            // 
            this.btListQuestionDelete.Location = new System.Drawing.Point(92, 457);
            this.btListQuestionDelete.Name = "btListQuestionDelete";
            this.btListQuestionDelete.Size = new System.Drawing.Size(70, 28);
            this.btListQuestionDelete.TabIndex = 25;
            this.btListQuestionDelete.Text = "Xóa";
            this.btListQuestionDelete.UseVisualStyleBackColor = true;
            this.btListQuestionDelete.Click += new System.EventHandler(this.btListQuestionDelete_Click);
            // 
            // gbFillMissingField
            // 
            this.gbFillMissingField.Controls.Add(this.tbClientAnswer);
            this.gbFillMissingField.Location = new System.Drawing.Point(7, 182);
            this.gbFillMissingField.Name = "gbFillMissingField";
            this.gbFillMissingField.Size = new System.Drawing.Size(727, 125);
            this.gbFillMissingField.TabIndex = 28;
            this.gbFillMissingField.TabStop = false;
            this.gbFillMissingField.Text = "Trả lời";
            // 
            // tbClientAnswer
            // 
            this.tbClientAnswer.Location = new System.Drawing.Point(7, 19);
            this.tbClientAnswer.Multiline = true;
            this.tbClientAnswer.Name = "tbClientAnswer";
            this.tbClientAnswer.Size = new System.Drawing.Size(714, 96);
            this.tbClientAnswer.TabIndex = 27;
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 492);
            this.Controls.Add(this.btListQuestionDelete);
            this.Controls.Add(this.btListQuestionEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lvListQuestion);
            this.Controls.Add(this.tbQuestionGroupName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbOneChoiceQuestion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateQuestion";
            this.Text = "Tạo bộ câu hỏi";
            this.Load += new System.EventHandler(this.CreateQuestion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOneChoiceQuestion.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).EndInit();
            this.gbAnswer.ResumeLayout(false);
            this.gbAnswer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbFillMissingField.ResumeLayout(false);
            this.gbFillMissingField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChoiceA;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMultiQuestion;
        private System.Windows.Forms.RadioButton rbMissingField;
        private System.Windows.Forms.RadioButton rbOneChoice;
        private System.Windows.Forms.GroupBox gbOneChoiceQuestion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbQuestionGroupName;
        private System.Windows.Forms.ToolStripMenuItem newGroupQuestion;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.GroupBox gbAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbChoiceB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbChoiceC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbChoiceD;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown tbTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem bộCâuHỏiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdExactlyChoise;
        private System.Windows.Forms.RadioButton rbdNotExactlyChoice;
        private System.Windows.Forms.ListView lvListQuestion;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader question;
        private System.Windows.Forms.ToolStripMenuItem openFromFile;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btListQuestionEdit;
        private System.Windows.Forms.Button btListQuestionDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem lưuNhưToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbFillMissingField;
        private System.Windows.Forms.TextBox tbClientAnswer;
    }
}