namespace BTK1
{
    partial class Cau25
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
            this.treevFolder = new System.Windows.Forms.TreeView();
            this.flpPicture = new System.Windows.Forms.FlowLayoutPanel();
            this.picbPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // treevFolder
            // 
            this.treevFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.treevFolder.Location = new System.Drawing.Point(0, 0);
            this.treevFolder.Name = "treevFolder";
            this.treevFolder.Size = new System.Drawing.Size(244, 436);
            this.treevFolder.TabIndex = 0;
            this.treevFolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treevFolder_BeforeExpand);
            this.treevFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treevFolder_AfterSelect);
            // 
            // flpPicture
            // 
            this.flpPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpPicture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpPicture.Location = new System.Drawing.Point(244, 293);
            this.flpPicture.Margin = new System.Windows.Forms.Padding(0);
            this.flpPicture.Name = "flpPicture";
            this.flpPicture.Size = new System.Drawing.Size(616, 143);
            this.flpPicture.TabIndex = 1;
            // 
            // picbPicture
            // 
            this.picbPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.picbPicture.Location = new System.Drawing.Point(244, 0);
            this.picbPicture.Margin = new System.Windows.Forms.Padding(0);
            this.picbPicture.Name = "picbPicture";
            this.picbPicture.Size = new System.Drawing.Size(616, 293);
            this.picbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbPicture.TabIndex = 2;
            this.picbPicture.TabStop = false;
            // 
            // Cau25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 436);
            this.Controls.Add(this.picbPicture);
            this.Controls.Add(this.flpPicture);
            this.Controls.Add(this.treevFolder);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Cau25";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cau25";
            this.Load += new System.EventHandler(this.Cau25_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treevFolder;
        private System.Windows.Forms.FlowLayoutPanel flpPicture;
        private System.Windows.Forms.PictureBox picbPicture;
    }
}