namespace BTTH_HOTEN_MSSV
{
    partial class MDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCau18 = new System.Windows.Forms.ToolStripMenuItem();
            this.cau22ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cau19ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiForm
            // 
            this.tsmiForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCau18,
            this.cau22ToolStripMenuItem,
            this.cau19ToolStripMenuItem});
            this.tsmiForm.Name = "tsmiForm";
            this.tsmiForm.Size = new System.Drawing.Size(47, 20);
            this.tsmiForm.Text = "Form";
            // 
            // tsmiCau18
            // 
            this.tsmiCau18.Name = "tsmiCau18";
            this.tsmiCau18.Size = new System.Drawing.Size(180, 22);
            this.tsmiCau18.Text = "Cau 18";
            this.tsmiCau18.Click += new System.EventHandler(this.tsmiCau18_Click);
            // 
            // cau22ToolStripMenuItem
            // 
            this.cau22ToolStripMenuItem.Name = "cau22ToolStripMenuItem";
            this.cau22ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cau22ToolStripMenuItem.Text = "Cau 22";
            this.cau22ToolStripMenuItem.Click += new System.EventHandler(this.cau22ToolStripMenuItem_Click);
            // 
            // cau19ToolStripMenuItem
            // 
            this.cau19ToolStripMenuItem.Name = "cau19ToolStripMenuItem";
            this.cau19ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cau19ToolStripMenuItem.Text = "Cau 19";
            this.cau19ToolStripMenuItem.Click += new System.EventHandler(this.cau19ToolStripMenuItem_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiCau18;
        private System.Windows.Forms.ToolStripMenuItem cau22ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cau19ToolStripMenuItem;
    }
}

