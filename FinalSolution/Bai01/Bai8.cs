using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bai8 : Form
    {
        private const string passOne = "0908";
        private const string passTwo = "0338";
        private const string passThree = "0338452907";
        private const string passFour = "1111";
        private string ketQua;

        public Bai8()
        {
            InitializeComponent();
        }

        private void txbCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Enter_Event();
            }
        }

        private void numBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txbCode.Text += btn.Text;
            txbCode.Focus();
            txbCode.SelectionStart = txbCode.TextLength;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txbCode.Clear();
            txbCode.Focus();
            txbCode.SelectionStart = txbCode.TextLength;
        }

        private void btnSharp_Click(object sender, EventArgs e)
        {
            txbCode.Focus();

            if (txbCode.TextLength == 0)
            {
                return;
            }
            txbCode.Text = txbCode.Text.Remove(txbCode.Text.Length - 1, 1);
            txbCode.SelectionStart = txbCode.TextLength;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path;
            path = @"C:\Recent\saveData.txt";

            DialogResult dlgR = 
                MessageBox.Show("Có đồng ý lưu", "tiêu đề", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgR == DialogResult.No)
            {
                return;
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                foreach(string item in lstbLog.Items)
                {
                    sw.WriteLine(item);
                }
            }
        }

        private void Enter_Event()
        {
            switch (txbCode.Text)
            {
                case passOne:
                    ketQua = "Viet";
                    break;
                case passTwo:
                    ketQua = "Huy";
                    break;
                case passThree:
                    ketQua = "Nguyễn Nhật Huy";
                    break;
                case passFour:
                    ketQua = "VPN 1111";
                    break;
                default:
                    ketQua = "Đăng nhập bị từ chối";
                    break;
            }

            lstbLog.Items.Add(String.Format($"{DateTime.Now.ToString("dd/MM/yyyy")} \t {ketQua}"));
            txbCode.Text = "";
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Enter:
                    Enter_Event();
                    return true;
                case Keys.D1:
                    txbCode.Text += "1";
                    txbCode.Focus();
                    txbCode.SelectionStart = txbCode.TextLength;
                    return true;
                case Keys.D2:
                    txbCode.Text += "2";
                    txbCode.Focus();
                    txbCode.SelectionStart = txbCode.TextLength;
                    return true;
                case Keys.D3:
                    txbCode.Text += "3";
                    txbCode.Focus();
                    txbCode.SelectionStart = txbCode.TextLength;
                    return true;
                case Keys.D4:
                    txbCode.Text += "4";
                    txbCode.Focus();
                    txbCode.SelectionStart = txbCode.TextLength;
                    return true;
                case Keys.D5:
                    txbCode.Text += "5";
                    txbCode.Focus();
                    txbCode.SelectionStart = txbCode.TextLength;
                    return true;
                case Keys.D6:
                    txbCode.Text += "6";
                    txbCode.Focus();
                    txbCode.SelectionStart = txbCode.TextLength;
                    return true;
                case Keys.D7:
                    txbCode.Text += "7";
                    txbCode.Focus();
                    txbCode.SelectionStart = txbCode.TextLength;
                    return true;
                case Keys.D8:
                    txbCode.Text += "8";
                    txbCode.Focus();
                    txbCode.SelectionStart = txbCode.TextLength;
                    return true;
                case Keys.D9:
                    txbCode.Text += "9";
                    txbCode.Focus();
                    txbCode.SelectionStart = txbCode.TextLength;
                    return true;
                case Keys.D0:
                    txbCode.Text += "0";
                    txbCode.Focus();
                    txbCode.SelectionStart = txbCode.TextLength;
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void txbCode_TextChanged(object sender, EventArgs e)
        {
            TextBox txbTemp = (TextBox)sender;
            bool isParsable = Int32.TryParse(txbTemp.Text, out int index);
            if(!isParsable)
            {
                return;
            }
        }
    }
}
