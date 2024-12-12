namespace BTK1
{
    partial class Cau14
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lstbA = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.btnDoubleToRight = new System.Windows.Forms.Button();
            this.btnDoubleToLeft = new System.Windows.Forms.Button();
            this.lstbB = new System.Windows.Forms.ListBox();
            this.lblB = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Red;
            this.lblHeader.Location = new System.Drawing.Point(260, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(284, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "DANH SÁCH SINH VIÊN";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Navy;
            this.lblName.Location = new System.Drawing.Point(15, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ tên SV:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(118, 47);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(450, 34);
            this.txbName.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdate.Location = new System.Drawing.Point(616, 45);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(19, 109);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(63, 28);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "Lớp A";
            // 
            // lstbA
            // 
            this.lstbA.FormattingEnabled = true;
            this.lstbA.HorizontalScrollbar = true;
            this.lstbA.ItemHeight = 28;
            this.lstbA.Location = new System.Drawing.Point(23, 134);
            this.lstbA.Name = "lstbA";
            this.lstbA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbA.Size = new System.Drawing.Size(251, 172);
            this.lstbA.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(101, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnToRight
            // 
            this.btnToRight.AutoSize = true;
            this.btnToRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToRight.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToRight.ForeColor = System.Drawing.Color.Navy;
            this.btnToRight.Location = new System.Drawing.Point(311, 167);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(51, 47);
            this.btnToRight.TabIndex = 7;
            this.btnToRight.Text = ">";
            this.btnToRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.AutoSize = true;
            this.btnToLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToLeft.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLeft.ForeColor = System.Drawing.Color.Navy;
            this.btnToLeft.Location = new System.Drawing.Point(386, 167);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(51, 47);
            this.btnToLeft.TabIndex = 8;
            this.btnToLeft.Text = "<";
            this.btnToLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // btnDoubleToRight
            // 
            this.btnDoubleToRight.AutoSize = true;
            this.btnDoubleToRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoubleToRight.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoubleToRight.ForeColor = System.Drawing.Color.Navy;
            this.btnDoubleToRight.Location = new System.Drawing.Point(311, 229);
            this.btnDoubleToRight.Name = "btnDoubleToRight";
            this.btnDoubleToRight.Size = new System.Drawing.Size(63, 47);
            this.btnDoubleToRight.TabIndex = 9;
            this.btnDoubleToRight.Text = ">>";
            this.btnDoubleToRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoubleToRight.UseVisualStyleBackColor = true;
            this.btnDoubleToRight.Click += new System.EventHandler(this.btnDoubleToRight_Click);
            // 
            // btnDoubleToLeft
            // 
            this.btnDoubleToLeft.AutoSize = true;
            this.btnDoubleToLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoubleToLeft.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoubleToLeft.ForeColor = System.Drawing.Color.Navy;
            this.btnDoubleToLeft.Location = new System.Drawing.Point(386, 229);
            this.btnDoubleToLeft.Name = "btnDoubleToLeft";
            this.btnDoubleToLeft.Size = new System.Drawing.Size(63, 47);
            this.btnDoubleToLeft.TabIndex = 10;
            this.btnDoubleToLeft.Text = "<<";
            this.btnDoubleToLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoubleToLeft.UseVisualStyleBackColor = true;
            this.btnDoubleToLeft.Click += new System.EventHandler(this.btnDoubleToLeft_Click);
            // 
            // lstbB
            // 
            this.lstbB.FormattingEnabled = true;
            this.lstbB.HorizontalScrollbar = true;
            this.lstbB.ItemHeight = 28;
            this.lstbB.Location = new System.Drawing.Point(471, 134);
            this.lstbB.Name = "lstbB";
            this.lstbB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbB.Size = new System.Drawing.Size(251, 172);
            this.lstbB.TabIndex = 11;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(467, 109);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(61, 28);
            this.lblB.TabIndex = 12;
            this.lblB.Text = "Lớp B";
            // 
            // btnEnd
            // 
            this.btnEnd.AutoSize = true;
            this.btnEnd.BackColor = System.Drawing.Color.Crimson;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.Black;
            this.btnEnd.Location = new System.Drawing.Point(556, 318);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(102, 38);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Cau14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 361);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lstbB);
            this.Controls.Add(this.btnDoubleToLeft);
            this.Controls.Add(this.btnDoubleToRight);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstbA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cau14";
            this.Text = "Cau14";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cau14_FormClosing);
            this.Load += new System.EventHandler(this.Cau14_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ListBox lstbA;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.Button btnDoubleToRight;
        private System.Windows.Forms.Button btnDoubleToLeft;
        private System.Windows.Forms.ListBox lstbB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnEnd;
    }
}