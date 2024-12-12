using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Bai5 : Form
    {
        private int so1, so2, so3;
        private int diem;
        private bool loadedForm;

        public Bai5()
        {
            InitializeComponent();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            so1 = so2 = so3 = diem = default;
            lblNum1.Text = so1.ToString();
            lblNum2.Text = so2.ToString();
            lblNum3.Text = so3.ToString();
            lblScoreValue.Text = diem.ToString();
            rdbtn1.Checked = rdbtn2.Checked = false;
            rdbtn1.BackColor = rdbtn2.BackColor = Color.Silver;
        }

        private void rdbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if(loadedForm == true)
            {
                loadedForm = false;
                rdbtn1.Checked = rdbtn2.Checked = false;
                return;
            }

            RadioButton rad = (RadioButton)sender;
            if(rad.Checked == true)
            {
                rad.BackColor = Color.Black;
            }
            else
            {
                rad.BackColor = Color.Silver;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int tong = default;
            if(rdbtn1.Checked == false && rdbtn2.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn miền giá trị");
                return;
            }

            Random rand = new Random();
            so1 = rand.Next(1, 7);
            so2 = rand.Next(1, 7);
            so3 = rand.Next(1, 7);
            tong = so1 + so2 + so3;
            lblNum1.Text = so1.ToString();
            lblNum2.Text = so2.ToString();
            lblNum3.Text = so3.ToString();

            if(rdbtn1.Checked)
            {
                if (tong >= 3 && tong <= 10)
                    diem += 10;
                else
                    diem -= 10;
            }
            else
            {
                if (tong >= 11 && tong <= 18)
                    diem += 10;
                else
                    diem -= 10;
            }

            lblScoreValue.Text = diem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            so1 = so2 = so3 = diem = default;
            lblNum1.Text = so1.ToString();
            lblNum2.Text = so2.ToString();
            lblNum3.Text = so3.ToString();
            lblScoreValue.Text = diem.ToString();
            rdbtn1.Checked = rdbtn2.Checked = false;
            rdbtn1.BackColor = rdbtn2.BackColor = Color.Silver;
            loadedForm = true;
        }
    }
}
