using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVienVoiListView
{
    public partial class LoginForm : Form
    {
        private bool isLogin;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbLoginName.Text) || txbPasscode.Text != "admin")
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                return;
            }
            WorkforceForm.loginName = txbLoginName.Text;

            isLogin = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isLogin == false)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            isLogin = false;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Enter:
                    btnLogin.PerformClick();
                    return true;
                case Keys.Escape:
                    btnClose.PerformClick();
                    return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
