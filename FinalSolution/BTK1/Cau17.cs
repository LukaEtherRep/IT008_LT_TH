using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTK1
{
    public partial class Cau17 : Form
    {
        Random rnd;

        public Cau17()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cau17_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgr = MessageBox.Show("Đóng form??", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlgr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "AVI Files|*.avi|WAV Files|*.wav|MP4 Files|*.mp4|MP3 Files|*.mp3";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string dateMonthYear = now.ToString("dd/MM/yyyy");
            string hourMinuteSecond = now.ToString("hh:mm:ss tt");
            lblTime.Text = $"Thời gian hiện tại là: {DateTime.Now.ToString("dd/MM/yyyy")} {DateTime.Now.ToString("hh:mm:ss tt")}";
            lblTime.ForeColor = Color.FromArgb(rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
        }

        private void Cau17_Load(object sender, EventArgs e)
        {
            lblTime.Text = $"Thời gian hiện tại là: {DateTime.Now.ToString("dd/MM/yyyy")} {DateTime.Now.ToString("hh:mm:ss tt")}";
            timer1.Start();
            rnd = new Random();
        }
    }
}
