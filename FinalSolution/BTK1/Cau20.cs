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

namespace BTK1
{
    public partial class Cau20 : Form
    {
        #region Global Variables
        string[] tables = new string[] { "B1", "B2", "B3", "B4" };

        DataTable dt = new DataTable();
        DataColumn[] dtc = new DataColumn[] { new DataColumn("FoodName"), new DataColumn("Quantity") };

        string fileName;
        #endregion

        public Cau20()
        {
            InitializeComponent();
        }

        private void Cau20_Load(object sender, EventArgs e)
        {
            cbTable.Items.AddRange(tables);
            dt.Columns.AddRange(dtc);

            dtgvList.DataSource = dt;

            dtgvList.Columns[0].Width = (int)(dtgvList.Width * 0.448);
            dtgvList.Columns[1].Width = (int)(dtgvList.Width * 0.448);

            dtgvList.AutoGenerateColumns = false;

            cbTable.SelectedIndex = 0;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataRow dr = dt.NewRow();
            bool flag = true;

            foreach (DataRow dr2 in dt.Rows)
            {
                if (dr2[0].ToString() == btn.Text)
                {
                    flag = false;
                    dr2[1] = (int.Parse(dr2[1].ToString()) + 1).ToString();
                    break;
                }
            }
            if (flag == true)
            {
                dr[0] = btn.Text;
                dr[1] = 1;
                dt.Rows.Add(dr);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            StreamWriter stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
            }
            else
            {
                fileName = @"C:\Recent\fileLuuTestBTIT008.txt";
            }

            if (!File.Exists(fileName))
            {
                stream = new StreamWriter(fileName);
                stream.WriteLine($"{"Bàn",-10}"
                               + $"{dtgvList.Columns[0].HeaderText,-50}"
                               + $"{dtgvList.Columns[1].HeaderText,-20}");
                for (int i = 0; i < dtgvList.RowCount-1; i++)
                {
                    stream.WriteLine($"{cbTable.SelectedItem.ToString(),-10}"
                                   + $"{dtgvList.Rows[i].Cells[0].Value.ToString(),-50}"
                                   + $"{dtgvList.Rows[i].Cells[1].Value.ToString(),-20}"
                                   );
                }
                stream.Close();
            }
            else
            {
                stream = File.AppendText(fileName);
                for (int i = 0; i < dtgvList.RowCount-1; i++)
                {
                    stream.WriteLine($"{cbTable.SelectedItem.ToString(),-10}"
                                   + $"{dtgvList.Rows[i].Cells[0].Value.ToString(),-50}"
                                   + $"{dtgvList.Rows[i].Cells[1].Value.ToString(),-20}"
                                   );
                }
                stream.Close();
            }
        }

        private void btnClearDB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
                return;
            StreamWriter stream = new StreamWriter(fileName);
            stream.WriteLine();
            stream.Close();
        }
    }
}
