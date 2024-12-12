namespace BTTH_HOTEN_MSSV
{
    partial class Cau19
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.lblString3 = new System.Windows.Forms.Label();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txbPosition = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnChange23 = new System.Windows.Forms.Button();
            this.btnChange1 = new System.Windows.Forms.Button();
            this.btnDelete21 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblRunString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(326, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(111, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Xử lý chuỗi";
            // 
            // timerCount
            // 
            this.timerCount.Enabled = true;
            this.timerCount.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString1.ForeColor = System.Drawing.Color.Navy;
            this.lblString1.Location = new System.Drawing.Point(12, 82);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(67, 21);
            this.lblString1.TabIndex = 1;
            this.lblString1.Text = "Chuỗi 1:";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString2.ForeColor = System.Drawing.Color.Navy;
            this.lblString2.Location = new System.Drawing.Point(12, 120);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(67, 21);
            this.lblString2.TabIndex = 2;
            this.lblString2.Text = "Chuỗi 2:";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(85, 79);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(619, 29);
            this.txb1.TabIndex = 3;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(85, 117);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(276, 29);
            this.txb2.TabIndex = 4;
            // 
            // lblString3
            // 
            this.lblString3.AutoSize = true;
            this.lblString3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString3.ForeColor = System.Drawing.Color.Navy;
            this.lblString3.Location = new System.Drawing.Point(367, 120);
            this.lblString3.Name = "lblString3";
            this.lblString3.Size = new System.Drawing.Size(67, 21);
            this.lblString3.TabIndex = 5;
            this.lblString3.Text = "Chuỗi 3:";
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(440, 117);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(264, 29);
            this.txb3.TabIndex = 6;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(26, 196);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(225, 25);
            this.lblSection.TabIndex = 7;
            this.lblSection.Text = "Chèn chuỗi 2 vào chuỗi 1";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.Navy;
            this.lblPosition.Location = new System.Drawing.Point(36, 231);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(43, 21);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Vị trí";
            // 
            // txbPosition
            // 
            this.txbPosition.Location = new System.Drawing.Point(85, 228);
            this.txbPosition.Name = "txbPosition";
            this.txbPosition.Size = new System.Drawing.Size(79, 29);
            this.txbPosition.TabIndex = 9;
            this.txbPosition.TextChanged += new System.EventHandler(this.txbPosition_TextChanged);
            this.txbPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPosition_KeyPress);
            // 
            // btnAction
            // 
            this.btnAction.AutoSize = true;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAction.ForeColor = System.Drawing.Color.Navy;
            this.btnAction.Location = new System.Drawing.Point(170, 226);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(56, 31);
            this.btnAction.TabIndex = 10;
            this.btnAction.Text = "Chèn";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnChange23
            // 
            this.btnChange23.AutoSize = true;
            this.btnChange23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange23.ForeColor = System.Drawing.Color.Navy;
            this.btnChange23.Location = new System.Drawing.Point(384, 206);
            this.btnChange23.Name = "btnChange23";
            this.btnChange23.Size = new System.Drawing.Size(140, 31);
            this.btnChange23.TabIndex = 11;
            this.btnChange23.Text = "Thay s2 bằng s3";
            this.btnChange23.UseVisualStyleBackColor = true;
            this.btnChange23.Click += new System.EventHandler(this.btnChange23_Click);
            // 
            // btnChange1
            // 
            this.btnChange1.AutoSize = true;
            this.btnChange1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange1.ForeColor = System.Drawing.Color.Navy;
            this.btnChange1.Location = new System.Drawing.Point(530, 206);
            this.btnChange1.Name = "btnChange1";
            this.btnChange1.Size = new System.Drawing.Size(140, 31);
            this.btnChange1.TabIndex = 12;
            this.btnChange1.Text = "Đảo từ trong s1";
            this.btnChange1.UseVisualStyleBackColor = true;
            this.btnChange1.Click += new System.EventHandler(this.btnChange1_Click);
            // 
            // btnDelete21
            // 
            this.btnDelete21.AutoSize = true;
            this.btnDelete21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete21.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete21.Location = new System.Drawing.Point(384, 254);
            this.btnDelete21.Name = "btnDelete21";
            this.btnDelete21.Size = new System.Drawing.Size(140, 31);
            this.btnDelete21.TabIndex = 13;
            this.btnDelete21.Text = "Xóa s2 trong s1";
            this.btnDelete21.UseVisualStyleBackColor = true;
            this.btnDelete21.Click += new System.EventHandler(this.btnDelete21_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Navy;
            this.btnOK.Location = new System.Drawing.Point(530, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 31);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "Chuẩn hóa";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblRunString
            // 
            this.lblRunString.AutoSize = true;
            this.lblRunString.Location = new System.Drawing.Point(377, 45);
            this.lblRunString.Name = "lblRunString";
            this.lblRunString.Size = new System.Drawing.Size(0, 21);
            this.lblRunString.TabIndex = 15;
            this.lblRunString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cau19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 340);
            this.Controls.Add(this.lblRunString);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDelete21);
            this.Controls.Add(this.btnChange1);
            this.Controls.Add(this.btnChange23);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txbPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.lblString3);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Cau19";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cau19";
            this.Load += new System.EventHandler(this.Cau19_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Label lblString3;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txbPosition;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnChange23;
        private System.Windows.Forms.Button btnChange1;
        private System.Windows.Forms.Button btnDelete21;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblRunString;
    }
}