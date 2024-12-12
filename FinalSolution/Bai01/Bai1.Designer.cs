namespace WindowsFormsApp1
{
    partial class Bai1
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
            this.lblNumA = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbNumA = new System.Windows.Forms.TextBox();
            this.txbNumB = new System.Windows.Forms.TextBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblSection.Location = new System.Drawing.Point(280, 35);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(215, 31);
            this.lblSection.TabIndex = 5;
            this.lblSection.Text = "Form so sánh hai số";
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumA.Location = new System.Drawing.Point(25, 110);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(125, 31);
            this.lblNumA.TabIndex = 6;
            this.lblNumA.Text = "Nhập số A:";
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumB.Location = new System.Drawing.Point(25, 180);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(123, 31);
            this.lblNumB.TabIndex = 7;
            this.lblNumB.Text = "Nhập số B:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(25, 250);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(97, 31);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Kết quả:";
            // 
            // txbNumA
            // 
            this.txbNumA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumA.Location = new System.Drawing.Point(226, 111);
            this.txbNumA.Name = "txbNumA";
            this.txbNumA.Size = new System.Drawing.Size(282, 30);
            this.txbNumA.TabIndex = 0;
            // 
            // txbNumB
            // 
            this.txbNumB.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txbNumB.Location = new System.Drawing.Point(226, 181);
            this.txbNumB.Name = "txbNumB";
            this.txbNumB.Size = new System.Drawing.Size(282, 30);
            this.txbNumB.TabIndex = 1;
            // 
            // txbResult
            // 
            this.txbResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbResult.Enabled = false;
            this.txbResult.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txbResult.Location = new System.Drawing.Point(226, 251);
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.Size = new System.Drawing.Size(282, 30);
            this.txbResult.TabIndex = 2;
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(85, 328);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(145, 62);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "So sánh";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(300, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 62);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(515, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.txbNumB);
            this.Controls.Add(this.txbNumA);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.lblNumA);
            this.Controls.Add(this.lblSection);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Bai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm số lớn nhất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txbNumA;
        private System.Windows.Forms.TextBox txbNumB;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}