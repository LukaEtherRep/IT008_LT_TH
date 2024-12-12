namespace BTTH_HOTEN_MSSV
{
    partial class Cau22
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
            this.grbClientInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.dtpickerBornDate = new System.Windows.Forms.DateTimePicker();
            this.txbPhoneNum = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbListInfo = new System.Windows.Forms.GroupBox();
            this.lstvListInfo = new System.Windows.Forms.ListView();
            this.colheadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadBornDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadPhoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbClientInfo.SuspendLayout();
            this.grbListInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblHeader.Location = new System.Drawing.Point(403, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(256, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // grbClientInfo
            // 
            this.grbClientInfo.Controls.Add(this.txbAddress);
            this.grbClientInfo.Controls.Add(this.txbPhoneNum);
            this.grbClientInfo.Controls.Add(this.dtpickerBornDate);
            this.grbClientInfo.Controls.Add(this.txbName);
            this.grbClientInfo.Controls.Add(this.lblAddress);
            this.grbClientInfo.Controls.Add(this.lblPhoneNum);
            this.grbClientInfo.Controls.Add(this.lblBornDate);
            this.grbClientInfo.Controls.Add(this.lblName);
            this.grbClientInfo.Location = new System.Drawing.Point(13, 54);
            this.grbClientInfo.Name = "grbClientInfo";
            this.grbClientInfo.Size = new System.Drawing.Size(1040, 110);
            this.grbClientInfo.TabIndex = 1;
            this.grbClientInfo.TabStop = false;
            this.grbClientInfo.Text = "Thông tin chi tiết";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ tên";
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Location = new System.Drawing.Point(46, 70);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(80, 21);
            this.lblBornDate.TabIndex = 1;
            this.lblBornDate.Text = "Ngày sinh";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(565, 25);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(81, 21);
            this.lblPhoneNum.TabIndex = 2;
            this.lblPhoneNum.Text = "Điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(565, 70);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 21);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(132, 25);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(318, 25);
            this.txbName.TabIndex = 5;
            // 
            // dtpickerBornDate
            // 
            this.dtpickerBornDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerBornDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerBornDate.Location = new System.Drawing.Point(132, 67);
            this.dtpickerBornDate.Name = "dtpickerBornDate";
            this.dtpickerBornDate.Size = new System.Drawing.Size(280, 25);
            this.dtpickerBornDate.TabIndex = 6;
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNum.Location = new System.Drawing.Point(652, 25);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Size = new System.Drawing.Size(220, 25);
            this.txbPhoneNum.TabIndex = 7;
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(652, 70);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(382, 25);
            this.txbAddress.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(621, 181);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(711, 181);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.AutoSize = true;
            this.btnModify.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModify.Location = new System.Drawing.Point(801, 181);
            this.btnModify.Margin = new System.Windows.Forms.Padding(0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(90, 31);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Sửa";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(891, 181);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbListInfo
            // 
            this.grbListInfo.Controls.Add(this.lstvListInfo);
            this.grbListInfo.Location = new System.Drawing.Point(13, 225);
            this.grbListInfo.Name = "grbListInfo";
            this.grbListInfo.Size = new System.Drawing.Size(1040, 215);
            this.grbListInfo.TabIndex = 6;
            this.grbListInfo.TabStop = false;
            this.grbListInfo.Text = "Thông tin chung";
            // 
            // lstvListInfo
            // 
            this.lstvListInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheadName,
            this.colheadBornDate,
            this.colheadAddress,
            this.colheadPhoneNum});
            this.lstvListInfo.GridLines = true;
            this.lstvListInfo.HideSelection = false;
            this.lstvListInfo.Location = new System.Drawing.Point(50, 28);
            this.lstvListInfo.MultiSelect = false;
            this.lstvListInfo.Name = "lstvListInfo";
            this.lstvListInfo.Size = new System.Drawing.Size(943, 170);
            this.lstvListInfo.TabIndex = 0;
            this.lstvListInfo.UseCompatibleStateImageBehavior = false;
            this.lstvListInfo.View = System.Windows.Forms.View.Details;
            this.lstvListInfo.SelectedIndexChanged += new System.EventHandler(this.lstvListInfo_SelectedIndexChanged);
            // 
            // colheadName
            // 
            this.colheadName.Text = "Họ tên";
            // 
            // colheadBornDate
            // 
            this.colheadBornDate.Text = "Ngày sinh";
            // 
            // colheadAddress
            // 
            this.colheadAddress.Text = "Địa chỉ";
            // 
            // colheadPhoneNum
            // 
            this.colheadPhoneNum.Text = "Điện thoại";
            // 
            // Cau22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 452);
            this.Controls.Add(this.grbListInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbClientInfo);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Cau22";
            this.Text = "Cau22";
            this.Load += new System.EventHandler(this.Cau22_Load);
            this.grbClientInfo.ResumeLayout(false);
            this.grbClientInfo.PerformLayout();
            this.grbListInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grbClientInfo;
        private System.Windows.Forms.DateTimePicker dtpickerBornDate;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbPhoneNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbListInfo;
        private System.Windows.Forms.ListView lstvListInfo;
        private System.Windows.Forms.ColumnHeader colheadName;
        private System.Windows.Forms.ColumnHeader colheadBornDate;
        private System.Windows.Forms.ColumnHeader colheadAddress;
        private System.Windows.Forms.ColumnHeader colheadPhoneNum;
    }
}