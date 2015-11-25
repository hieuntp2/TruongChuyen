namespace NCKH3
{
    partial class Server
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
            this.components = new System.ComponentModel.Container();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btEndGroupQuestion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbServerIP = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvClients = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalQuestion = new System.Windows.Forms.Label();
            this.lbNumberQuestion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.btChoiseD = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btChoiseC = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btChoiseB = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btChoiseA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btNextQuestion = new System.Windows.Forms.Button();
            this.cbAutoNextQuestion = new System.Windows.Forms.CheckBox();
            this.btLoadGroupQuestion = new System.Windows.Forms.Button();
            this.lbGroupName = new System.Windows.Forms.Label();
            this.btStartTest = new System.Windows.Forms.Button();
            this.tmProcessBar = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.saveResultToFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(741, 389);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(195, 196);
            this.tbMessage.TabIndex = 2;
            // 
            // btEndGroupQuestion
            // 
            this.btEndGroupQuestion.Location = new System.Drawing.Point(604, 536);
            this.btEndGroupQuestion.Name = "btEndGroupQuestion";
            this.btEndGroupQuestion.Size = new System.Drawing.Size(119, 49);
            this.btEndGroupQuestion.TabIndex = 3;
            this.btEndGroupQuestion.Text = "Kết thúc test";
            this.btEndGroupQuestion.UseVisualStyleBackColor = true;
            this.btEndGroupQuestion.Click += new System.EventHandler(this.btEndGroupQuestion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbServerIP);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lvClients);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Location = new System.Drawing.Point(735, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 357);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // lbServerIP
            // 
            this.lbServerIP.AutoSize = true;
            this.lbServerIP.Location = new System.Drawing.Point(67, 330);
            this.lbServerIP.Name = "lbServerIP";
            this.lbServerIP.Size = new System.Drawing.Size(29, 13);
            this.lbServerIP.TabIndex = 17;
            this.lbServerIP.Text = "__IP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Server IP:";
            // 
            // lvClients
            // 
            this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Answer});
            this.lvClients.Location = new System.Drawing.Point(6, 14);
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(195, 272);
            this.lvClients.TabIndex = 2;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            this.lvClients.View = System.Windows.Forms.View.Details;
            this.lvClients.DoubleClick += new System.EventHandler(this.lvClients_DoubleClick);
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 118;
            // 
            // Answer
            // 
            this.Answer.Text = "Đáp án";
            this.Answer.Width = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(66, 292);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(135, 20);
            this.tbPassword.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbCurrentTime);
            this.groupBox2.Controls.Add(this.lbTime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbAnswer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbTotalQuestion);
            this.groupBox2.Controls.Add(this.lbNumberQuestion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pbTime);
            this.groupBox2.Controls.Add(this.btChoiseD);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.btChoiseC);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.btChoiseB);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btChoiseA);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txQuestion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 419);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Câu hỏi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "/";
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Location = new System.Drawing.Point(326, 330);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(84, 13);
            this.lbCurrentTime.TabIndex = 23;
            this.lbCurrentTime.Text = "__lbCurrentTime";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(388, 330);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(50, 13);
            this.lbTime.TabIndex = 22;
            this.lbTime.Text = "__lbTime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Thời gian:";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(58, 384);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(61, 13);
            this.lbAnswer.TabIndex = 20;
            this.lbAnswer.Text = "__lbanswer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Đáp án:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "/";
            // 
            // lbTotalQuestion
            // 
            this.lbTotalQuestion.AutoSize = true;
            this.lbTotalQuestion.Location = new System.Drawing.Point(655, 21);
            this.lbTotalQuestion.Name = "lbTotalQuestion";
            this.lbTotalQuestion.Size = new System.Drawing.Size(55, 13);
            this.lbTotalQuestion.TabIndex = 17;
            this.lbTotalQuestion.Text = "__Tongso";
            // 
            // lbNumberQuestion
            // 
            this.lbNumberQuestion.AutoSize = true;
            this.lbNumberQuestion.Location = new System.Drawing.Point(589, 21);
            this.lbNumberQuestion.Name = "lbNumberQuestion";
            this.lbNumberQuestion.Size = new System.Drawing.Size(56, 13);
            this.lbNumberQuestion.TabIndex = 16;
            this.lbNumberQuestion.Text = "__soluong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số lượng câu hỏi:";
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(10, 346);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(701, 23);
            this.pbTime.TabIndex = 14;
            // 
            // btChoiseD
            // 
            this.btChoiseD.Enabled = false;
            this.btChoiseD.Location = new System.Drawing.Point(56, 289);
            this.btChoiseD.Name = "btChoiseD";
            this.btChoiseD.Size = new System.Drawing.Size(655, 32);
            this.btChoiseD.TabIndex = 13;
            this.btChoiseD.Text = "__choice A";
            this.btChoiseD.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(10, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 32);
            this.button9.TabIndex = 12;
            this.button9.Text = "D";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btChoiseC
            // 
            this.btChoiseC.Enabled = false;
            this.btChoiseC.Location = new System.Drawing.Point(56, 251);
            this.btChoiseC.Name = "btChoiseC";
            this.btChoiseC.Size = new System.Drawing.Size(655, 32);
            this.btChoiseC.TabIndex = 11;
            this.btChoiseC.Text = "__choice A";
            this.btChoiseC.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(10, 251);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 32);
            this.button7.TabIndex = 10;
            this.button7.Text = "C";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btChoiseB
            // 
            this.btChoiseB.Enabled = false;
            this.btChoiseB.Location = new System.Drawing.Point(56, 213);
            this.btChoiseB.Name = "btChoiseB";
            this.btChoiseB.Size = new System.Drawing.Size(655, 32);
            this.btChoiseB.TabIndex = 9;
            this.btChoiseB.Text = "__choice A";
            this.btChoiseB.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(10, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "B";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btChoiseA
            // 
            this.btChoiseA.Enabled = false;
            this.btChoiseA.Location = new System.Drawing.Point(56, 175);
            this.btChoiseA.Name = "btChoiseA";
            this.btChoiseA.Size = new System.Drawing.Size(655, 32);
            this.btChoiseA.TabIndex = 7;
            this.btChoiseA.Text = "__choice A";
            this.btChoiseA.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(10, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "A";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trả lời";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(235, 21);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(35, 13);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "__loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại:";
            // 
            // txQuestion
            // 
            this.txQuestion.Location = new System.Drawing.Point(10, 37);
            this.txQuestion.Multiline = true;
            this.txQuestion.Name = "txQuestion";
            this.txQuestion.Size = new System.Drawing.Size(701, 109);
            this.txQuestion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Câu hỏi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // btNextQuestion
            // 
            this.btNextQuestion.Location = new System.Drawing.Point(12, 489);
            this.btNextQuestion.Name = "btNextQuestion";
            this.btNextQuestion.Size = new System.Drawing.Size(129, 41);
            this.btNextQuestion.TabIndex = 7;
            this.btNextQuestion.Text = "Câu hỏi tiếp";
            this.btNextQuestion.UseVisualStyleBackColor = true;
            this.btNextQuestion.Click += new System.EventHandler(this.btNextQuestion_Click);
            // 
            // cbAutoNextQuestion
            // 
            this.cbAutoNextQuestion.AutoSize = true;
            this.cbAutoNextQuestion.Location = new System.Drawing.Point(147, 502);
            this.cbAutoNextQuestion.Name = "cbAutoNextQuestion";
            this.cbAutoNextQuestion.Size = new System.Drawing.Size(221, 17);
            this.cbAutoNextQuestion.TabIndex = 8;
            this.cbAutoNextQuestion.Text = "Tự động chuyển câu hỏi khi hết thời gian";
            this.cbAutoNextQuestion.UseVisualStyleBackColor = true;
            // 
            // btLoadGroupQuestion
            // 
            this.btLoadGroupQuestion.Location = new System.Drawing.Point(12, 536);
            this.btLoadGroupQuestion.Name = "btLoadGroupQuestion";
            this.btLoadGroupQuestion.Size = new System.Drawing.Size(119, 49);
            this.btLoadGroupQuestion.TabIndex = 9;
            this.btLoadGroupQuestion.Text = "Mở bộ câu hỏi";
            this.btLoadGroupQuestion.UseVisualStyleBackColor = true;
            this.btLoadGroupQuestion.Click += new System.EventHandler(this.btLoadGroupQuestion_Click);
            // 
            // lbGroupName
            // 
            this.lbGroupName.AutoSize = true;
            this.lbGroupName.Location = new System.Drawing.Point(19, 24);
            this.lbGroupName.Name = "lbGroupName";
            this.lbGroupName.Size = new System.Drawing.Size(43, 13);
            this.lbGroupName.TabIndex = 15;
            this.lbGroupName.Text = "Câu hỏi";
            // 
            // btStartTest
            // 
            this.btStartTest.Location = new System.Drawing.Point(147, 536);
            this.btStartTest.Name = "btStartTest";
            this.btStartTest.Size = new System.Drawing.Size(119, 49);
            this.btStartTest.TabIndex = 16;
            this.btStartTest.Text = "Bắt đầu ";
            this.btStartTest.UseVisualStyleBackColor = true;
            this.btStartTest.Click += new System.EventHandler(this.btStartTest_Click);
            // 
            // tmProcessBar
            // 
            this.tmProcessBar.Interval = 1000;
            this.tmProcessBar.Tick += new System.EventHandler(this.tmProcessBar_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(742, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Message:";
            // 
            // saveResultToFile
            // 
            this.saveResultToFile.Location = new System.Drawing.Point(476, 536);
            this.saveResultToFile.Name = "saveResultToFile";
            this.saveResultToFile.Size = new System.Drawing.Size(119, 49);
            this.saveResultToFile.TabIndex = 19;
            this.saveResultToFile.Text = "Xuất kết quả kiểm tra";
            this.saveResultToFile.UseVisualStyleBackColor = true;
            this.saveResultToFile.Click += new System.EventHandler(this.saveResultToFile_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 597);
            this.Controls.Add(this.saveResultToFile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btStartTest);
            this.Controls.Add(this.lbGroupName);
            this.Controls.Add(this.btLoadGroupQuestion);
            this.Controls.Add(this.cbAutoNextQuestion);
            this.Controls.Add(this.btNextQuestion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btEndGroupQuestion);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.Load += new System.EventHandler(this.Server_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btEndGroupQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btChoiseA;
        private System.Windows.Forms.Button btChoiseD;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btChoiseC;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btChoiseB;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.Button btNextQuestion;
        private System.Windows.Forms.CheckBox cbAutoNextQuestion;
        private System.Windows.Forms.Button btLoadGroupQuestion;
        private System.Windows.Forms.Label lbGroupName;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Answer;
        private System.Windows.Forms.Button btStartTest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotalQuestion;
        private System.Windows.Forms.Label lbNumberQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmProcessBar;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label lbServerIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.Button saveResultToFile;
    }
}

