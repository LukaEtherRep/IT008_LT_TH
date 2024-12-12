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
    public partial class Bai7 : Form
    {
        int[] mangGiaDV = { 100000, 1200000, 200000, 800000 };

        public Bai7()
        {
            InitializeComponent();
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            lblService1Price.Text = String.Format("{0:N}", mangGiaDV[0]);
            lblService2Price.Text = String.Format("{0:N}", mangGiaDV[1]);
            lblService3Price.Text = String.Format("{0:N}", mangGiaDV[2]);
            lblService4Price.Text = String.Format("{0:N}", mangGiaDV[3]);

            grbService.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbName.Text))
            {
                grbService.Enabled = false;
            }
            else
            {
                grbService.Enabled = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbName.Text)) return;

            int tong = 0;
            if (ckbService1.Checked)
            {
                tong += mangGiaDV[0];
            }
            if (ckbService2.Checked)
            {
                tong += mangGiaDV[1];
            }
            if (ckbService3.Checked)
            {
                tong += mangGiaDV[2];
            }
            tong += mangGiaDV[3] *  Convert.ToInt32(nmrUDService4.Value);

            if (tong == 0) return;
            txbTotal.Text = String.Format("{0:N}", tong);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbTotal.Text)) return;
            DateTime now = DateTime.Now;
            lstbInfo.Items.Add($"Tên khách hàng: {txbName.Text} | " +
                               $"Tổng tiền: {txbTotal.Text} | " +
                               $"Ngày giao dịch: {now.ToString("dd/MM/yyyy hh:mm:ss tt")}");

            txbName.Focus();
            tabControlDental.SelectTab("tabKhachHang");
            ResetInput();
        }

        private void ResetInput()
        {
            txbName.Text = null;
            ckbService1.Checked = ckbService2.Checked = ckbService3.Checked = false;
            nmrUDService4.Value = 0;
            txbTotal.Text = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Chưa xong
            string path = @"C:\Users\ACER\Downloads\FileLogCau7.txt";
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter streamWriter = File.CreateText(path))
                    {
                        foreach (string item in lstbInfo.Items)
                        {
                            streamWriter.WriteLine(item);
                        }
                    }
                }
                else
                {
                    using (StreamWriter streamWriter = File.AppendText(path))
                    {
                        foreach (string item in lstbInfo.Items)
                        {
                            streamWriter.WriteLine(item);
                        }
                    }
                }
                MessageBox.Show("Lưu thành công");
                lstbInfo.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\ACER\Downloads\FileLogCau7.txt";
            try
            {
                lstbInfo.Items.Clear();
                using (StreamReader streamReader = new StreamReader(path))
                {
                    while (streamReader.Peek() != -1)
                    {
                        lstbInfo.Items.Add(streamReader.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
