using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txbNumA.Text) || String.IsNullOrEmpty(txbNumB.Text))
                {
                    throw new Exception("Không được để trống ô nhập giá trị");
                }

                int soA = Int32.Parse(txbNumA.Text.ToString());
                int soB = Int32.Parse(txbNumB.Text.ToString());

                if (soA > soB)
                {
                    txbResult.Text = String.Format($"Số lớn hơn là: {soA}");
                }
                else if (soA < soB)
                {
                    txbResult.Text = String.Format($"Số lớn hơn là: {soB}");
                }
                else
                {
                    txbResult.Text = String.Format($"Hai số bằng nhau và bằng {soA}");
                }
            }
            catch(OverflowException)
            {
                MessageBox.Show($"Giá trị trong ô không được vượt quá {Int32.MaxValue}");
            }
            catch(FormatException)
            {
                MessageBox.Show($"Ô nhập giá trị chỉ nhận định dạng số");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbNumA.Clear();
            txbNumB.Clear();
            txbResult.Clear();
            txbNumA.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát?", "Exit Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
