namespace Client
{
    partial class Client
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
            this.sendAnswer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbFillMissingField = new System.Windows.Forms.GroupBox();
            this.tbClientAnswer = new System.Windows.Forms.TextBox();
            this.gbOneChoice = new System.Windows.Forms.GroupBox();
            this.btChoiseA = new System.Windows.Forms.Button();
            this.btChoiseA_ = new System.Windows.Forms.Button();
            this.btChoiseB_ = new System.Windows.Forms.Button();
            this.btChoiseB = new System.Windows.Forms.Button();
            this.btChoiseC_ = new System.Windows.Forms.Button();
            this.btChoiseC = new System.Windows.Forms.Button();
            this.btChoiseD_ = new System.Windows.Forms.Button();
            this.btChoiseD = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.lbType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmProcessBar = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.gbFillMissingField.SuspendLayout();
            this.gbOneChoice.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendAnswer
            // 
            this.sendAnswer.Location = new System.Drawing.Point(0, 390);
            this.sendAnswer.Name = "sendAnswer";
            this.sendAnswer.Size = new System.Drawing.Size(710, 52);
            this.sendAnswer.TabIndex = 0;
            this.sendAnswer.Text = "Gửi";
            this.sendAnswer.UseVisualStyleBackColor = true;
            this.sendAnswer.Click += new System.EventHandler(this.sendAnswer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbFillMissingField);
            this.groupBox2.Controls.Add(this.gbOneChoice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbCurrentTime);
            this.groupBox2.Controls.Add(this.sendAnswer);
            this.groupBox2.Controls.Add(this.lbTime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pbTime);
            this.groupBox2.Controls.Add(this.lbType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txQuestion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 448);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Câu hỏi";
            // 
            // gbFillMissingField
            // 
            this.gbFillMissingField.Controls.Add(this.tbClientAnswer);
            this.gbFillMissingField.Location = new System.Drawing.Point(7, 155);
            this.gbFillMissingField.Name = "gbFillMissingField";
            this.gbFillMissingField.Size = new System.Drawing.Size(708, 173);
            this.gbFillMissingField.TabIndex = 27;
            this.gbFillMissingField.TabStop = false;
            this.gbFillMissingField.Text = "Trả lời";
            // 
            // tbClientAnswer
            // 
            this.tbClientAnswer.Location = new System.Drawing.Point(7, 19);
            this.tbClientAnswer.Multiline = true;
            this.tbClientAnswer.Name = "tbClientAnswer";
            this.tbClientAnswer.Size = new System.Drawing.Size(694, 142);
            this.tbClientAnswer.TabIndex = 27;
            // 
            // gbOneChoice
            // 
            this.gbOneChoice.Controls.Add(this.btChoiseA);
            this.gbOneChoice.Controls.Add(this.btChoiseA_);
            this.gbOneChoice.Controls.Add(this.btChoiseB_);
            this.gbOneChoice.Controls.Add(this.btChoiseB);
            this.gbOneChoice.Controls.Add(this.btChoiseC_);
            this.gbOneChoice.Controls.Add(this.btChoiseC);
            this.gbOneChoice.Controls.Add(this.btChoiseD_);
            this.gbOneChoice.Controls.Add(this.btChoiseD);
            this.gbOneChoice.Location = new System.Drawing.Point(8, 154);
            this.gbOneChoice.Name = "gbOneChoice";
            this.gbOneChoice.Size = new System.Drawing.Size(708, 173);
            this.gbOneChoice.TabIndex = 26;
            this.gbOneChoice.TabStop = false;
            this.gbOneChoice.Text = "Trả lời";
            // 
            // btChoiseA
            // 
            this.btChoiseA.Location = new System.Drawing.Point(57, 19);
            this.btChoiseA.Name = "btChoiseA";
            this.btChoiseA.Size = new System.Drawing.Size(643, 32);
            this.btChoiseA.TabIndex = 25;
            this.btChoiseA.Text = "__choice A";
            this.btChoiseA.UseVisualStyleBackColor = true;
            this.btChoiseA.Click += new System.EventHandler(this.btChoiseA_Click);
            // 
            // btChoiseA_
            // 
            this.btChoiseA_.Location = new System.Drawing.Point(12, 19);
            this.btChoiseA_.Name = "btChoiseA_";
            this.btChoiseA_.Size = new System.Drawing.Size(40, 32);
            this.btChoiseA_.TabIndex = 5;
            this.btChoiseA_.Text = "A";
            this.btChoiseA_.UseVisualStyleBackColor = true;
            this.btChoiseA_.Click += new System.EventHandler(this.btChoiseA_Click);
            // 
            // btChoiseB_
            // 
            this.btChoiseB_.Location = new System.Drawing.Point(12, 57);
            this.btChoiseB_.Name = "btChoiseB_";
            this.btChoiseB_.Size = new System.Drawing.Size(40, 32);
            this.btChoiseB_.TabIndex = 8;
            this.btChoiseB_.Text = "B";
            this.btChoiseB_.UseVisualStyleBackColor = true;
            this.btChoiseB_.Click += new System.EventHandler(this.btChoiseB_Click);
            // 
            // btChoiseB
            // 
            this.btChoiseB.Location = new System.Drawing.Point(58, 57);
            this.btChoiseB.Name = "btChoiseB";
            this.btChoiseB.Size = new System.Drawing.Size(643, 32);
            this.btChoiseB.TabIndex = 9;
            this.btChoiseB.Text = "__choice A";
            this.btChoiseB.UseVisualStyleBackColor = true;
            this.btChoiseB.Click += new System.EventHandler(this.btChoiseB_Click);
            // 
            // btChoiseC_
            // 
            this.btChoiseC_.Location = new System.Drawing.Point(12, 95);
            this.btChoiseC_.Name = "btChoiseC_";
            this.btChoiseC_.Size = new System.Drawing.Size(40, 32);
            this.btChoiseC_.TabIndex = 10;
            this.btChoiseC_.Text = "C";
            this.btChoiseC_.UseVisualStyleBackColor = true;
            this.btChoiseC_.Click += new System.EventHandler(this.btChoiseC_Click);
            // 
            // btChoiseC
            // 
            this.btChoiseC.Location = new System.Drawing.Point(58, 95);
            this.btChoiseC.Name = "btChoiseC";
            this.btChoiseC.Size = new System.Drawing.Size(643, 32);
            this.btChoiseC.TabIndex = 11;
            this.btChoiseC.Text = "__choice A";
            this.btChoiseC.UseVisualStyleBackColor = true;
            this.btChoiseC.Click += new System.EventHandler(this.btChoiseC_Click);
            // 
            // btChoiseD_
            // 
            this.btChoiseD_.Location = new System.Drawing.Point(12, 133);
            this.btChoiseD_.Name = "btChoiseD_";
            this.btChoiseD_.Size = new System.Drawing.Size(40, 32);
            this.btChoiseD_.TabIndex = 12;
            this.btChoiseD_.Text = "D";
            this.btChoiseD_.UseVisualStyleBackColor = true;
            this.btChoiseD_.Click += new System.EventHandler(this.btChoiseD_Click);
            // 
            // btChoiseD
            // 
            this.btChoiseD.Location = new System.Drawing.Point(58, 133);
            this.btChoiseD.Name = "btChoiseD";
            this.btChoiseD.Size = new System.Drawing.Size(643, 32);
            this.btChoiseD.TabIndex = 13;
            this.btChoiseD.Text = "__choice A";
            this.btChoiseD.UseVisualStyleBackColor = true;
            this.btChoiseD.Click += new System.EventHandler(this.btChoiseD_Click);
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
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(10, 346);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(701, 23);
            this.pbTime.TabIndex = 14;
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
            // tmProcessBar
            // 
            this.tmProcessBar.Tick += new System.EventHandler(this.tmProcessBar_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 27;
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
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbFillMissingField.ResumeLayout(false);
            this.gbFillMissingField.PerformLayout();
            this.gbOneChoice.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendAnswer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.Button btChoiseD;
        private System.Windows.Forms.Button btChoiseD_;
        private System.Windows.Forms.Button btChoiseC;
        private System.Windows.Forms.Button btChoiseC_;
        private System.Windows.Forms.Button btChoiseB;
        private System.Windows.Forms.Button btChoiseB_;
        private System.Windows.Forms.Button btChoiseA_;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmProcessBar;
        private System.Windows.Forms.Button btChoiseA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbOneChoice;
        private System.Windows.Forms.GroupBox gbFillMissingField;
        private System.Windows.Forms.TextBox tbClientAnswer;
    }
}

