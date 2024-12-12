namespace BTK1
{
    partial class Cau12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cau12));
            this.picbBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbBall)).BeginInit();
            this.SuspendLayout();
            // 
            // picbBall
            // 
            this.picbBall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picbBall.Image = ((System.Drawing.Image)(resources.GetObject("picbBall.Image")));
            this.picbBall.Location = new System.Drawing.Point(291, 145);
            this.picbBall.Name = "picbBall";
            this.picbBall.Size = new System.Drawing.Size(76, 76);
            this.picbBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbBall.TabIndex = 0;
            this.picbBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(196, 343);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(295, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Nhấn nút này khi quả bóng bay quá nhanh, quá nguy hiểm";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Cau12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 378);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picbBall);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Cau12";
            this.Text = "Cau12";
            this.Load += new System.EventHandler(this.Cau12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReset;
    }
}