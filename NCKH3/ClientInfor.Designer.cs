namespace NCKH3
{
    partial class ClientInfor
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lvListQuestionAnswer = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.traloi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dapan1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ketqua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(12, 9);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(65, 13);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "__username";
            // 
            // lvListQuestionAnswer
            // 
            this.lvListQuestionAnswer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.Question,
            this.loai,
            this.traloi,
            this.dapan1,
            this.ketqua});
            this.lvListQuestionAnswer.Location = new System.Drawing.Point(13, 45);
            this.lvListQuestionAnswer.Name = "lvListQuestionAnswer";
            this.lvListQuestionAnswer.Size = new System.Drawing.Size(692, 213);
            this.lvListQuestionAnswer.TabIndex = 1;
            this.lvListQuestionAnswer.UseCompatibleStateImageBehavior = false;
            this.lvListQuestionAnswer.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "Stt";
            // 
            // Question
            // 
            this.Question.Text = "Câu hỏi";
            this.Question.Width = 233;
            // 
            // loai
            // 
            this.loai.Text = "Loại";
            // 
            // traloi
            // 
            this.traloi.Text = "Trả lời";
            // 
            // dapan1
            // 
            this.dapan1.Text = "Đáp án";
            // 
            // ketqua
            // 
            this.ketqua.Text = "Kết quả";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvListQuestionAnswer);
            this.Controls.Add(this.lbUsername);
            this.Name = "ClientInfor";
            this.Text = "Client Info";
            this.Load += new System.EventHandler(this.ClientInfor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.ListView lvListQuestionAnswer;
        private System.Windows.Forms.ColumnHeader Question;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader loai;
        private System.Windows.Forms.ColumnHeader traloi;
        private System.Windows.Forms.ColumnHeader dapan1;
        private System.Windows.Forms.ColumnHeader ketqua;
    }
}