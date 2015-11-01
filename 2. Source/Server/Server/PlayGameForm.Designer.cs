namespace Server
{
    partial class PlayGameForm
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
            this.lblQuest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestNumber = new System.Windows.Forms.Label();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.BackColor = System.Drawing.Color.Transparent;
            this.lblQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuest.Location = new System.Drawing.Point(389, 154);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(126, 46);
            this.lblQuest.TabIndex = 0;
            this.lblQuest.Text = "label1";
            this.lblQuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestNumber
            // 
            this.lblQuestNumber.AutoSize = true;
            this.lblQuestNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuestNumber.Location = new System.Drawing.Point(109, 9);
            this.lblQuestNumber.Name = "lblQuestNumber";
            this.lblQuestNumber.Size = new System.Drawing.Size(23, 25);
            this.lblQuestNumber.TabIndex = 2;
            this.lblQuestNumber.Text = "0";
            this.lblQuestNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAnswers
            // 
            this.lblAnswers.AutoSize = true;
            this.lblAnswers.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnswers.Location = new System.Drawing.Point(852, 9);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(23, 25);
            this.lblAnswers.TabIndex = 4;
            this.lblAnswers.Text = "0";
            this.lblAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(755, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Answered";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 254);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(863, 42);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.Transparent;
            this.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnA.FlatAppearance.BorderSize = 2;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Location = new System.Drawing.Point(11, 321);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(423, 84);
            this.btnA.TabIndex = 10;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.Transparent;
            this.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnB.FlatAppearance.BorderSize = 2;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.Location = new System.Drawing.Point(452, 321);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(423, 84);
            this.btnB.TabIndex = 11;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.Transparent;
            this.btnD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnD.FlatAppearance.BorderSize = 2;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.Location = new System.Drawing.Point(452, 425);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(423, 84);
            this.btnD.TabIndex = 13;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Transparent;
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnC.FlatAppearance.BorderSize = 2;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(11, 425);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(423, 84);
            this.btnC.TabIndex = 12;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Server.Properties.Resources.Untitled_1;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblAnswers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQuestNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuest);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "PlayGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.Deactivate += new System.EventHandler(this.PlayGameForm_Deactivate);
            this.Load += new System.EventHandler(this.PlayGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestNumber;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Timer timer1;
    }
}