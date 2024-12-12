namespace Bai05
{
    partial class Bai5
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
            this.lblSection = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.gbRadioButtons = new System.Windows.Forms.GroupBox();
            this.rdbtn2 = new System.Windows.Forms.RadioButton();
            this.rdbtn1 = new System.Windows.Forms.RadioButton();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.gbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(252, 38);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(295, 38);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "ỨNG DỤNG ĐOÁN SỐ";
            // 
            // lblNum1
            // 
            this.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum1.Font = new System.Drawing.Font("Segoe UI", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblNum1.Location = new System.Drawing.Point(35, 95);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(196, 136);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "10";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum2
            // 
            this.lblNum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum2.Font = new System.Drawing.Font("Segoe UI", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblNum2.Location = new System.Drawing.Point(305, 95);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(196, 136);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "10";
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum3
            // 
            this.lblNum3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum3.Font = new System.Drawing.Font("Segoe UI", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum3.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblNum3.Location = new System.Drawing.Point(575, 95);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(196, 136);
            this.lblNum3.TabIndex = 3;
            this.lblNum3.Text = "10";
            this.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbRadioButtons
            // 
            this.gbRadioButtons.Controls.Add(this.rdbtn2);
            this.gbRadioButtons.Controls.Add(this.rdbtn1);
            this.gbRadioButtons.Location = new System.Drawing.Point(80, 270);
            this.gbRadioButtons.Name = "gbRadioButtons";
            this.gbRadioButtons.Size = new System.Drawing.Size(636, 109);
            this.gbRadioButtons.TabIndex = 4;
            this.gbRadioButtons.TabStop = false;
            this.gbRadioButtons.Text = "Chọn";
            // 
            // rdbtn2
            // 
            this.rdbtn2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn2.BackColor = System.Drawing.Color.Silver;
            this.rdbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbtn2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn2.Location = new System.Drawing.Point(350, 45);
            this.rdbtn2.Name = "rdbtn2";
            this.rdbtn2.Size = new System.Drawing.Size(195, 49);
            this.rdbtn2.TabIndex = 1;
            this.rdbtn2.TabStop = true;
            this.rdbtn2.Text = "11-18";
            this.rdbtn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtn2.UseVisualStyleBackColor = false;
            this.rdbtn2.CheckedChanged += new System.EventHandler(this.rdbtn1_CheckedChanged);
            // 
            // rdbtn1
            // 
            this.rdbtn1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn1.BackColor = System.Drawing.Color.Silver;
            this.rdbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbtn1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn1.Location = new System.Drawing.Point(70, 45);
            this.rdbtn1.Name = "rdbtn1";
            this.rdbtn1.Size = new System.Drawing.Size(195, 49);
            this.rdbtn1.TabIndex = 0;
            this.rdbtn1.TabStop = true;
            this.rdbtn1.Text = "3-10";
            this.rdbtn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtn1.UseVisualStyleBackColor = false;
            this.rdbtn1.CheckedChanged += new System.EventHandler(this.rdbtn1_CheckedChanged);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.AutoSize = true;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayAgain.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnPlayAgain.Location = new System.Drawing.Point(44, 400);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(134, 48);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "Chơi lại";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.AutoSize = true;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandom.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRandom.Location = new System.Drawing.Point(211, 400);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(134, 48);
            this.btnRandom.TabIndex = 6;
            this.btnRandom.Text = "Quay số";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.Crimson;
            this.lblScore.Location = new System.Drawing.Point(556, 406);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(89, 38);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Điểm:";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.ForeColor = System.Drawing.Color.Black;
            this.lblScoreValue.Location = new System.Drawing.Point(644, 407);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(32, 38);
            this.lblScoreValue.TabIndex = 8;
            this.lblScoreValue.Text = "0";
            this.lblScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 472);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.gbRadioButtons);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblSection);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Bai5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbRadioButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.GroupBox gbRadioButtons;
        private System.Windows.Forms.RadioButton rdbtn2;
        private System.Windows.Forms.RadioButton rdbtn1;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreValue;
    }
}

