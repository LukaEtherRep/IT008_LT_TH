namespace WindowsFormsApp1
{
    partial class Form1
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai7 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForm,
            this.exitToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(600, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiForm
            // 
            this.tsmiForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBai1,
            this.tsmiBai5,
            this.tsmiBai7,
            this.bai8ToolStripMenuItem});
            this.tsmiForm.Name = "tsmiForm";
            this.tsmiForm.Size = new System.Drawing.Size(47, 20);
            this.tsmiForm.Text = "Form";
            // 
            // tsmiBai1
            // 
            this.tsmiBai1.Name = "tsmiBai1";
            this.tsmiBai1.Size = new System.Drawing.Size(180, 22);
            this.tsmiBai1.Text = "Bai 1";
            this.tsmiBai1.Click += new System.EventHandler(this.tsmiBai1_Click);
            // 
            // tsmiBai5
            // 
            this.tsmiBai5.Name = "tsmiBai5";
            this.tsmiBai5.Size = new System.Drawing.Size(180, 22);
            this.tsmiBai5.Text = "Bai 5";
            this.tsmiBai5.Click += new System.EventHandler(this.tsmiBai5_Click);
            // 
            // tsmiBai7
            // 
            this.tsmiBai7.Name = "tsmiBai7";
            this.tsmiBai7.Size = new System.Drawing.Size(180, 22);
            this.tsmiBai7.Text = "Bai 7";
            this.tsmiBai7.Click += new System.EventHandler(this.tsmiBai7_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bai8ToolStripMenuItem
            // 
            this.bai8ToolStripMenuItem.Name = "bai8ToolStripMenuItem";
            this.bai8ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bai8ToolStripMenuItem.Text = "Bai 8";
            this.bai8ToolStripMenuItem.Click += new System.EventHandler(this.bai8ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiBai1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBai5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBai7;
        private System.Windows.Forms.ToolStripMenuItem bai8ToolStripMenuItem;
    }
}

