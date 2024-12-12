namespace WindowsFormsApp1
{
    partial class Bai7
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
            this.lblName = new System.Windows.Forms.Label();
            this.grbService = new System.Windows.Forms.GroupBox();
            this.lblService4Total = new System.Windows.Forms.Label();
            this.lblService4Price = new System.Windows.Forms.Label();
            this.lblService3Price = new System.Windows.Forms.Label();
            this.lblService2Price = new System.Windows.Forms.Label();
            this.lblService1Price = new System.Windows.Forms.Label();
            this.nmrUDService4 = new System.Windows.Forms.NumericUpDown();
            this.lblService4 = new System.Windows.Forms.Label();
            this.ckbService3 = new System.Windows.Forms.CheckBox();
            this.ckbService2 = new System.Windows.Forms.CheckBox();
            this.ckbService1 = new System.Windows.Forms.CheckBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tabControlDental = new System.Windows.Forms.TabControl();
            this.tabPhieuKham = new System.Windows.Forms.TabPage();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstbInfo = new System.Windows.Forms.ListBox();
            this.lblInfoHeader = new System.Windows.Forms.Label();
            this.grbService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUDService4)).BeginInit();
            this.tabControlDental.SuspendLayout();
            this.tabPhieuKham.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSection
            // 
            this.lblSection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.Crimson;
            this.lblSection.Location = new System.Drawing.Point(193, 13);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(225, 30);
            this.lblSection.TabIndex = 4;
            this.lblSection.Text = "Dental Payment Form";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 30);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Tên khách hàng:";
            // 
            // grbService
            // 
            this.grbService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbService.Controls.Add(this.lblService4Total);
            this.grbService.Controls.Add(this.lblService4Price);
            this.grbService.Controls.Add(this.lblService3Price);
            this.grbService.Controls.Add(this.lblService2Price);
            this.grbService.Controls.Add(this.lblService1Price);
            this.grbService.Controls.Add(this.nmrUDService4);
            this.grbService.Controls.Add(this.lblService4);
            this.grbService.Controls.Add(this.ckbService3);
            this.grbService.Controls.Add(this.ckbService2);
            this.grbService.Controls.Add(this.ckbService1);
            this.grbService.Location = new System.Drawing.Point(39, 124);
            this.grbService.Name = "grbService";
            this.grbService.Size = new System.Drawing.Size(498, 172);
            this.grbService.TabIndex = 1;
            this.grbService.TabStop = false;
            this.grbService.Text = "Dịch vụ";
            // 
            // lblService4Total
            // 
            this.lblService4Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblService4Total.AutoSize = true;
            this.lblService4Total.Location = new System.Drawing.Point(390, 135);
            this.lblService4Total.Name = "lblService4Total";
            this.lblService4Total.Size = new System.Drawing.Size(58, 25);
            this.lblService4Total.TabIndex = 9;
            this.lblService4Total.Text = "/1 cái";
            // 
            // lblService4Price
            // 
            this.lblService4Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblService4Price.ForeColor = System.Drawing.Color.Orange;
            this.lblService4Price.Location = new System.Drawing.Point(267, 135);
            this.lblService4Price.Name = "lblService4Price";
            this.lblService4Price.Size = new System.Drawing.Size(129, 25);
            this.lblService4Price.TabIndex = 8;
            this.lblService4Price.Text = "0";
            this.lblService4Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblService3Price
            // 
            this.lblService3Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblService3Price.ForeColor = System.Drawing.Color.Orange;
            this.lblService3Price.Location = new System.Drawing.Point(267, 104);
            this.lblService3Price.Name = "lblService3Price";
            this.lblService3Price.Size = new System.Drawing.Size(129, 25);
            this.lblService3Price.TabIndex = 7;
            this.lblService3Price.Text = "0";
            this.lblService3Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblService2Price
            // 
            this.lblService2Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblService2Price.ForeColor = System.Drawing.Color.Orange;
            this.lblService2Price.Location = new System.Drawing.Point(267, 69);
            this.lblService2Price.Name = "lblService2Price";
            this.lblService2Price.Size = new System.Drawing.Size(129, 25);
            this.lblService2Price.TabIndex = 6;
            this.lblService2Price.Text = "0";
            this.lblService2Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblService1Price
            // 
            this.lblService1Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblService1Price.ForeColor = System.Drawing.Color.Orange;
            this.lblService1Price.Location = new System.Drawing.Point(267, 34);
            this.lblService1Price.Name = "lblService1Price";
            this.lblService1Price.Size = new System.Drawing.Size(129, 25);
            this.lblService1Price.TabIndex = 5;
            this.lblService1Price.Text = "0";
            this.lblService1Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nmrUDService4
            // 
            this.nmrUDService4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nmrUDService4.Location = new System.Drawing.Point(113, 133);
            this.nmrUDService4.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmrUDService4.Name = "nmrUDService4";
            this.nmrUDService4.Size = new System.Drawing.Size(120, 33);
            this.nmrUDService4.TabIndex = 3;
            // 
            // lblService4
            // 
            this.lblService4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblService4.AutoSize = true;
            this.lblService4.Location = new System.Drawing.Point(6, 135);
            this.lblService4.Name = "lblService4";
            this.lblService4.Size = new System.Drawing.Size(101, 25);
            this.lblService4.TabIndex = 4;
            this.lblService4.Text = "Trám răng:";
            // 
            // ckbService3
            // 
            this.ckbService3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbService3.AutoSize = true;
            this.ckbService3.Location = new System.Drawing.Point(7, 103);
            this.ckbService3.Name = "ckbService3";
            this.ckbService3.Size = new System.Drawing.Size(163, 29);
            this.ckbService3.TabIndex = 2;
            this.ckbService3.Text = "Chụp hình răng";
            this.ckbService3.UseVisualStyleBackColor = true;
            // 
            // ckbService2
            // 
            this.ckbService2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbService2.AutoSize = true;
            this.ckbService2.Location = new System.Drawing.Point(7, 68);
            this.ckbService2.Name = "ckbService2";
            this.ckbService2.Size = new System.Drawing.Size(110, 29);
            this.ckbService2.TabIndex = 1;
            this.ckbService2.Text = "Tẩy trắng";
            this.ckbService2.UseVisualStyleBackColor = true;
            // 
            // ckbService1
            // 
            this.ckbService1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbService1.AutoSize = true;
            this.ckbService1.Location = new System.Drawing.Point(7, 33);
            this.ckbService1.Name = "ckbService1";
            this.ckbService1.Size = new System.Drawing.Size(94, 29);
            this.ckbService1.TabIndex = 0;
            this.ckbService1.Text = "Cạo vôi";
            this.ckbService1.UseVisualStyleBackColor = true;
            // 
            // txbName
            // 
            this.txbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbName.Location = new System.Drawing.Point(195, 79);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(353, 33);
            this.txbName.TabIndex = 0;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(230, 299);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(125, 30);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Thành tiền:";
            // 
            // txbTotal
            // 
            this.txbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotal.Enabled = false;
            this.txbTotal.Location = new System.Drawing.Point(361, 300);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(176, 33);
            this.txbTotal.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnExit.Location = new System.Drawing.Point(50, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalculate.ForeColor = System.Drawing.Color.Navy;
            this.btnCalculate.Location = new System.Drawing.Point(152, 343);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 42);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Tính tiền";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tabControlDental
            // 
            this.tabControlDental.Controls.Add(this.tabPhieuKham);
            this.tabControlDental.Controls.Add(this.tabKhachHang);
            this.tabControlDental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDental.Location = new System.Drawing.Point(0, 0);
            this.tabControlDental.Name = "tabControlDental";
            this.tabControlDental.SelectedIndex = 0;
            this.tabControlDental.Size = new System.Drawing.Size(588, 446);
            this.tabControlDental.TabIndex = 8;
            // 
            // tabPhieuKham
            // 
            this.tabPhieuKham.Controls.Add(this.btnTransfer);
            this.tabPhieuKham.Controls.Add(this.lblSection);
            this.tabPhieuKham.Controls.Add(this.btnCalculate);
            this.tabPhieuKham.Controls.Add(this.lblName);
            this.tabPhieuKham.Controls.Add(this.btnExit);
            this.tabPhieuKham.Controls.Add(this.grbService);
            this.tabPhieuKham.Controls.Add(this.txbTotal);
            this.tabPhieuKham.Controls.Add(this.txbName);
            this.tabPhieuKham.Controls.Add(this.lblTotal);
            this.tabPhieuKham.Location = new System.Drawing.Point(4, 34);
            this.tabPhieuKham.Name = "tabPhieuKham";
            this.tabPhieuKham.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuKham.Size = new System.Drawing.Size(580, 408);
            this.tabPhieuKham.TabIndex = 0;
            this.tabPhieuKham.Text = "Phiếu khám";
            this.tabPhieuKham.UseVisualStyleBackColor = true;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.AutoSize = true;
            this.btnTransfer.BackColor = System.Drawing.Color.Gold;
            this.btnTransfer.ForeColor = System.Drawing.Color.Navy;
            this.btnTransfer.Location = new System.Drawing.Point(361, 343);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(179, 42);
            this.btnTransfer.TabIndex = 8;
            this.btnTransfer.Text = "Lưu vào danh sách";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.btnOpen);
            this.tabKhachHang.Controls.Add(this.btnSave);
            this.tabKhachHang.Controls.Add(this.lstbInfo);
            this.tabKhachHang.Controls.Add(this.lblInfoHeader);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 34);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(580, 408);
            this.tabKhachHang.TabIndex = 1;
            this.tabKhachHang.Text = "Thông tin khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = true;
            this.btnOpen.BackColor = System.Drawing.Color.Silver;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Location = new System.Drawing.Point(343, 350);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(150, 35);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Mở danh sách";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(73, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstbInfo
            // 
            this.lstbInfo.FormattingEnabled = true;
            this.lstbInfo.HorizontalScrollbar = true;
            this.lstbInfo.ItemHeight = 25;
            this.lstbInfo.Location = new System.Drawing.Point(8, 65);
            this.lstbInfo.Name = "lstbInfo";
            this.lstbInfo.Size = new System.Drawing.Size(566, 279);
            this.lstbInfo.TabIndex = 6;
            // 
            // lblInfoHeader
            // 
            this.lblInfoHeader.AutoSize = true;
            this.lblInfoHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoHeader.ForeColor = System.Drawing.Color.Crimson;
            this.lblInfoHeader.Location = new System.Drawing.Point(173, 26);
            this.lblInfoHeader.Name = "lblInfoHeader";
            this.lblInfoHeader.Size = new System.Drawing.Size(231, 30);
            this.lblInfoHeader.TabIndex = 5;
            this.lblInfoHeader.Text = "Thông tin khách hàng";
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 446);
            this.Controls.Add(this.tabControlDental);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Bai7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai7";
            this.Load += new System.EventHandler(this.Bai7_Load);
            this.grbService.ResumeLayout(false);
            this.grbService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUDService4)).EndInit();
            this.tabControlDental.ResumeLayout(false);
            this.tabPhieuKham.ResumeLayout(false);
            this.tabPhieuKham.PerformLayout();
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grbService;
        private System.Windows.Forms.Label lblService4;
        private System.Windows.Forms.CheckBox ckbService3;
        private System.Windows.Forms.CheckBox ckbService2;
        private System.Windows.Forms.CheckBox ckbService1;
        private System.Windows.Forms.Label lblService4Total;
        private System.Windows.Forms.Label lblService4Price;
        private System.Windows.Forms.Label lblService3Price;
        private System.Windows.Forms.Label lblService2Price;
        private System.Windows.Forms.Label lblService1Price;
        private System.Windows.Forms.NumericUpDown nmrUDService4;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TabControl tabControlDental;
        private System.Windows.Forms.TabPage tabPhieuKham;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.Label lblInfoHeader;
        private System.Windows.Forms.ListBox lstbInfo;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTransfer;
    }
}