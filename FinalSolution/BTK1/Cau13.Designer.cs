namespace BTK1
{
    partial class Cau13
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
            this.grbGuessTheNumber = new System.Windows.Forms.GroupBox();
            this.picbDice = new System.Windows.Forms.PictureBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.grbRandom = new System.Windows.Forms.GroupBox();
            this.picbRandom = new System.Windows.Forms.PictureBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbCalculate = new System.Windows.Forms.GroupBox();
            this.lblCalc3 = new System.Windows.Forms.Label();
            this.lblCalc2 = new System.Windows.Forms.Label();
            this.lblCalc1 = new System.Windows.Forms.Label();
            this.lstbResult = new System.Windows.Forms.ListBox();
            this.grbGuessTheNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbDice)).BeginInit();
            this.grbRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbRandom)).BeginInit();
            this.grbCalculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGuessTheNumber
            // 
            this.grbGuessTheNumber.Controls.Add(this.picbDice);
            this.grbGuessTheNumber.Controls.Add(this.btn6);
            this.grbGuessTheNumber.Controls.Add(this.btn5);
            this.grbGuessTheNumber.Controls.Add(this.btn4);
            this.grbGuessTheNumber.Controls.Add(this.btn3);
            this.grbGuessTheNumber.Controls.Add(this.btn2);
            this.grbGuessTheNumber.Controls.Add(this.btn1);
            this.grbGuessTheNumber.Location = new System.Drawing.Point(15, 15);
            this.grbGuessTheNumber.Margin = new System.Windows.Forms.Padding(4);
            this.grbGuessTheNumber.Name = "grbGuessTheNumber";
            this.grbGuessTheNumber.Padding = new System.Windows.Forms.Padding(4);
            this.grbGuessTheNumber.Size = new System.Drawing.Size(227, 193);
            this.grbGuessTheNumber.TabIndex = 0;
            this.grbGuessTheNumber.TabStop = false;
            this.grbGuessTheNumber.Text = "Đoán số";
            // 
            // picbDice
            // 
            this.picbDice.Location = new System.Drawing.Point(85, 80);
            this.picbDice.Name = "picbDice";
            this.picbDice.Size = new System.Drawing.Size(55, 55);
            this.picbDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbDice.TabIndex = 6;
            this.picbDice.TabStop = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(170, 140);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 32);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumberChoosen_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(170, 90);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 32);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumberChoosen_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(170, 40);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 32);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumberChoosen_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(20, 140);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 32);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumberChoosen_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(20, 90);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 32);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumberChoosen_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(20, 40);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 32);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumberChoosen_Click);
            // 
            // grbRandom
            // 
            this.grbRandom.Controls.Add(this.picbRandom);
            this.grbRandom.Location = new System.Drawing.Point(15, 216);
            this.grbRandom.Name = "grbRandom";
            this.grbRandom.Size = new System.Drawing.Size(227, 100);
            this.grbRandom.TabIndex = 1;
            this.grbRandom.TabStop = false;
            this.grbRandom.Text = "Quay số ngẫu nhiên";
            // 
            // picbRandom
            // 
            this.picbRandom.Location = new System.Drawing.Point(85, 31);
            this.picbRandom.Name = "picbRandom";
            this.picbRandom.Size = new System.Drawing.Size(55, 55);
            this.picbRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbRandom.TabIndex = 7;
            this.picbRandom.TabStop = false;
            // 
            // btnRandom
            // 
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandom.Location = new System.Drawing.Point(35, 322);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 44);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Quay số (Enter)";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(145, 322);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 44);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset (Esc)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grbCalculate
            // 
            this.grbCalculate.Controls.Add(this.lblCalc3);
            this.grbCalculate.Controls.Add(this.lblCalc2);
            this.grbCalculate.Controls.Add(this.lblCalc1);
            this.grbCalculate.Location = new System.Drawing.Point(15, 373);
            this.grbCalculate.Name = "grbCalculate";
            this.grbCalculate.Size = new System.Drawing.Size(227, 114);
            this.grbCalculate.TabIndex = 4;
            this.grbCalculate.TabStop = false;
            this.grbCalculate.Text = "Thống kê";
            // 
            // lblCalc3
            // 
            this.lblCalc3.AutoSize = true;
            this.lblCalc3.Location = new System.Drawing.Point(6, 81);
            this.lblCalc3.Name = "lblCalc3";
            this.lblCalc3.Size = new System.Drawing.Size(43, 17);
            this.lblCalc3.TabIndex = 2;
            this.lblCalc3.Text = "label3";
            // 
            // lblCalc2
            // 
            this.lblCalc2.AutoSize = true;
            this.lblCalc2.Location = new System.Drawing.Point(6, 51);
            this.lblCalc2.Name = "lblCalc2";
            this.lblCalc2.Size = new System.Drawing.Size(43, 17);
            this.lblCalc2.TabIndex = 1;
            this.lblCalc2.Text = "label2";
            // 
            // lblCalc1
            // 
            this.lblCalc1.AutoSize = true;
            this.lblCalc1.Location = new System.Drawing.Point(6, 21);
            this.lblCalc1.Name = "lblCalc1";
            this.lblCalc1.Size = new System.Drawing.Size(43, 17);
            this.lblCalc1.TabIndex = 0;
            this.lblCalc1.Text = "label1";
            // 
            // lstbResult
            // 
            this.lstbResult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstbResult.FormattingEnabled = true;
            this.lstbResult.ItemHeight = 17;
            this.lstbResult.Location = new System.Drawing.Point(376, 15);
            this.lstbResult.Name = "lstbResult";
            this.lstbResult.Size = new System.Drawing.Size(345, 480);
            this.lstbResult.TabIndex = 5;
            this.lstbResult.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstbResult_DrawItem);
            // 
            // Cau13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 511);
            this.Controls.Add(this.lstbResult);
            this.Controls.Add(this.grbCalculate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.grbRandom);
            this.Controls.Add(this.grbGuessTheNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cau13";
            this.Text = "Cau13";
            this.Load += new System.EventHandler(this.Cau13_Load);
            this.grbGuessTheNumber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbDice)).EndInit();
            this.grbRandom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbRandom)).EndInit();
            this.grbCalculate.ResumeLayout(false);
            this.grbCalculate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGuessTheNumber;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox picbDice;
        private System.Windows.Forms.GroupBox grbRandom;
        private System.Windows.Forms.PictureBox picbRandom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grbCalculate;
        private System.Windows.Forms.Label lblCalc2;
        private System.Windows.Forms.Label lblCalc1;
        private System.Windows.Forms.Label lblCalc3;
        private System.Windows.Forms.ListBox lstbResult;
    }
}