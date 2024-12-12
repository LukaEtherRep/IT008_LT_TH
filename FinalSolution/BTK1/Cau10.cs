using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTK1.LopDungChung;

namespace BTK1
{
    public partial class Cau10 : Form
    {
        PhanSo p1, p2;

        public Cau10()
        {
            InitializeComponent();
        }

        private void Cau10_Load(object sender, EventArgs e)
        {

        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            PhanSo ketQua = null;
            try
            {
                if (String.IsNullOrEmpty(txbTu1.Text) || String.IsNullOrEmpty(txbTu2.Text)
                    || String.IsNullOrEmpty(txbMau1.Text) || String.IsNullOrEmpty(txbMau2.Text))
                {
                    throw new Exception("Phải nhập giá trị cho toàn bộ tử và mẫu");
                }
                p1 = new PhanSo(Int32.Parse(txbTu1.Text), Int32.Parse(txbMau1.Text));
                p2 = new PhanSo(Int32.Parse(txbTu2.Text), Int32.Parse(txbMau2.Text));
                switch(btn.Text)
                {
                    case "+":
                        ketQua = p1.Cong(p2);
                        lblPhepToan.Text = "+";
                        break;
                    case "-":
                        ketQua = p1.Tru(p2);
                        lblPhepToan.Text = "-";
                        break;
                    case "x":
                        ketQua = p1.Nhan(p2);
                        lblPhepToan.Text = "x";
                        break;
                    case "/":
                        ketQua = p1.Chia(p2);
                        lblPhepToan.Text = "/";
                        break;
                }

                txbTuKQ.Text = ketQua.TuSo.ToString();
                if (ketQua.TuSo != 0)
                {
                    txbMauKQ.Text = ketQua.MauSo.ToString();
                }
                else
                {
                    txbMauKQ.Text = String.Empty;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Text box chỉ nhận giá trị là số nguyên");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Giá trị nhập vào quá lớn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
