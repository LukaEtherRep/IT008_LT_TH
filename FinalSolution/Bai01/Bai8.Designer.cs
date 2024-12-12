namespace WindowsFormsApp1
{
    partial class Bai8
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSharp = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.lstbLog = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.Crimson;
            this.lblSection.Location = new System.Drawing.Point(165, 9);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(138, 25);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "Security Panel";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(12, 48);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(137, 25);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Security code:";
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(162, 45);
            this.txbCode.Name = "txbCode";
            this.txbCode.PasswordChar = '*';
            this.txbCode.Size = new System.Drawing.Size(232, 33);
            this.txbCode.TabIndex = 2;
            this.txbCode.TextChanged += new System.EventHandler(this.txbCode_TextChanged);
            this.txbCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCode_KeyDown);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Location = new System.Drawing.Point(120, 95);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 33);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Location = new System.Drawing.Point(180, 95);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 33);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Location = new System.Drawing.Point(240, 95);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 33);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Violet;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.Location = new System.Drawing.Point(300, 95);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(45, 33);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnSharp
            // 
            this.btnSharp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSharp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSharp.Location = new System.Drawing.Point(300, 136);
            this.btnSharp.Name = "btnSharp";
            this.btnSharp.Size = new System.Drawing.Size(45, 33);
            this.btnSharp.TabIndex = 10;
            this.btnSharp.Text = "#";
            this.btnSharp.UseVisualStyleBackColor = false;
            this.btnSharp.Click += new System.EventHandler(this.btnSharp_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Location = new System.Drawing.Point(240, 136);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 33);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Location = new System.Drawing.Point(180, 136);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 33);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Location = new System.Drawing.Point(120, 136);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 33);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Location = new System.Drawing.Point(300, 177);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(45, 33);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Location = new System.Drawing.Point(240, 177);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 33);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Location = new System.Drawing.Point(180, 177);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 33);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Location = new System.Drawing.Point(120, 177);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 33);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(12, 234);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(108, 25);
            this.lblLog.TabIndex = 15;
            this.lblLog.Text = "Access log:";
            // 
            // lstbLog
            // 
            this.lstbLog.FormattingEnabled = true;
            this.lstbLog.HorizontalScrollbar = true;
            this.lstbLog.ItemHeight = 25;
            this.lstbLog.Location = new System.Drawing.Point(17, 267);
            this.lstbLog.Name = "lstbLog";
            this.lstbLog.Size = new System.Drawing.Size(377, 129);
            this.lstbLog.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Crimson;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSave.Location = new System.Drawing.Point(331, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 408);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstbLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSharp);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblSection);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Bai8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai8";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSharp;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.ListBox lstbLog;
        private System.Windows.Forms.Button btnSave;
    }
}