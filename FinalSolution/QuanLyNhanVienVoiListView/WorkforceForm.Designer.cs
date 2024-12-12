namespace QuanLyNhanVienVoiListView
{
    partial class WorkforceForm
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
            this.lblBornDate = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.dtpickerBornDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lblHometown = new System.Windows.Forms.Label();
            this.cbHometown = new System.Windows.Forms.ComboBox();
            this.lstvWorker = new System.Windows.Forms.ListView();
            this.colheadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadBornDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadHometown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Cyan;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1323, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "QUẢN LÝ NHÂN VIÊN";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ tên:";
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBornDate.Location = new System.Drawing.Point(23, 100);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(105, 25);
            this.lblBornDate.TabIndex = 2;
            this.lblBornDate.Text = "Ngày sinh:";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(148, 54);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(294, 29);
            this.txbName.TabIndex = 4;
            // 
            // dtpickerBornDate
            // 
            this.dtpickerBornDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerBornDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerBornDate.Location = new System.Drawing.Point(148, 97);
            this.dtpickerBornDate.Name = "dtpickerBornDate";
            this.dtpickerBornDate.Size = new System.Drawing.Size(132, 29);
            this.dtpickerBornDate.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(27, 358);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(146, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.AutoSize = true;
            this.btnModify.BackColor = System.Drawing.Color.Silver;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModify.Location = new System.Drawing.Point(265, 358);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(113, 35);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Sửa";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // grbGender
            // 
            this.grbGender.BackColor = System.Drawing.Color.Thistle;
            this.grbGender.Controls.Add(this.rdbtnFemale);
            this.grbGender.Controls.Add(this.rdbtnMale);
            this.grbGender.Location = new System.Drawing.Point(27, 142);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(232, 100);
            this.grbGender.TabIndex = 10;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Giới tính";
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(43, 44);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(70, 29);
            this.rdbtnMale.TabIndex = 0;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Nam";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(139, 44);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(55, 29);
            this.rdbtnFemale.TabIndex = 1;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Nữ";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txbUserName
            // 
            this.txbUserName.Enabled = false;
            this.txbUserName.Location = new System.Drawing.Point(27, 399);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(351, 33);
            this.txbUserName.TabIndex = 11;
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHometown.Location = new System.Drawing.Point(23, 259);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(104, 25);
            this.lblHometown.TabIndex = 12;
            this.lblHometown.Text = "Quê quán:";
            // 
            // cbHometown
            // 
            this.cbHometown.FormattingEnabled = true;
            this.cbHometown.Items.AddRange(new object[] {
            "Hồ Chí Minh",
            "Hà Nội",
            "Huế",
            "Đà Nẵng"});
            this.cbHometown.Location = new System.Drawing.Point(133, 256);
            this.cbHometown.Name = "cbHometown";
            this.cbHometown.Size = new System.Drawing.Size(265, 33);
            this.cbHometown.TabIndex = 13;
            // 
            // lstvWorker
            // 
            this.lstvWorker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheadName,
            this.colheadBornDate,
            this.colheadGender,
            this.colheadHometown});
            this.lstvWorker.FullRowSelect = true;
            this.lstvWorker.HideSelection = false;
            this.lstvWorker.Location = new System.Drawing.Point(460, 54);
            this.lstvWorker.Name = "lstvWorker";
            this.lstvWorker.Size = new System.Drawing.Size(851, 381);
            this.lstvWorker.TabIndex = 14;
            this.lstvWorker.UseCompatibleStateImageBehavior = false;
            this.lstvWorker.View = System.Windows.Forms.View.Details;
            this.lstvWorker.SelectedIndexChanged += new System.EventHandler(this.lstvWorker_SelectedIndexChanged);
            // 
            // colheadName
            // 
            this.colheadName.Text = "Họ tên";
            // 
            // colheadBornDate
            // 
            this.colheadBornDate.Text = "Ngày sinh";
            // 
            // colheadGender
            // 
            this.colheadGender.Text = "Giới tính";
            // 
            // colheadHometown
            // 
            this.colheadHometown.Text = "Quê quán";
            // 
            // WorkforceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1323, 447);
            this.Controls.Add(this.lstvWorker);
            this.Controls.Add(this.cbHometown);
            this.Controls.Add(this.lblHometown);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpickerBornDate);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblBornDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "WorkforceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.WorkforceForm_Load);
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.DateTimePicker dtpickerBornDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.ComboBox cbHometown;
        private System.Windows.Forms.ListView lstvWorker;
        private System.Windows.Forms.ColumnHeader colheadName;
        private System.Windows.Forms.ColumnHeader colheadBornDate;
        private System.Windows.Forms.ColumnHeader colheadGender;
        private System.Windows.Forms.ColumnHeader colheadHometown;
    }
}