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
    public partial class Cau13 : Form
    {
        public Cau13()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        string path;
        int soNguoiChoiChon;
        int soLanChoi;
        int soLanDung, soLanSai;
        enum RightWrong { Right, Wrong };
        #endregion

        private void KhoiTao()
        {
            soNguoiChoiChon = 1;
            soLanChoi = 0;
            soLanDung = soLanSai = 0;
            lblCalc1.Text = "Lần đoán:";
            lblCalc2.Text = "Lần thắng:";
            lblCalc3.Text = "Lần thua:";
            lstbResult.Items.Clear();
            picbRandom.Image = null;
            picbDice.Image = Image.FromFile(path + soNguoiChoiChon + ".jpg");
            foreach (Control c in grbGuessTheNumber.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                    c.Font = new Font(c.Font, FontStyle.Regular);
                }
            }
            btn1.BackColor = Color.Green;
            btn1.ForeColor = Color.White;
            btn1.Font = new Font(btn1.Font, FontStyle.Bold);
        }

        private void Cau13_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\imageonline\";
            KhoiTao();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            KhoiTao();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void Play()
        {
            Random rand = new Random();
            int soCuaMay;
            string ketQua = "";

            soCuaMay = rand.Next(1, 7);
            soLanChoi += 1;

            picbRandom.Image = Image.FromFile(path + soCuaMay + ".jpg");

            RightWrong rw = new RightWrong();
            if (soNguoiChoiChon == soCuaMay)
            {
                ketQua = "Đúng";
                rw = RightWrong.Right;
                soLanDung += 1;
            }
            else
            {
                ketQua = "Sai";
                rw = RightWrong.Wrong;
                soLanSai += 1;
            }
            string thisTimeResult = $"{soLanChoi}. {ketQua} (Đoán {soNguoiChoiChon} ra {soCuaMay})";
            lstbResult.Items.Add(new { Text = thisTimeResult, Result = rw });
            lstbResult.SelectedIndex = lstbResult.Items.Count - 1;

            lblCalc1.Text = $"Lần đoán: {soLanChoi}";
            lblCalc2.Text = $"Lần đúng: {soLanDung} {(double)soLanDung / soLanChoi * 100: 0.00}%";
            lblCalc3.Text = $"Lần sai: {soLanSai} {(double)soLanSai / soLanChoi * 100: 0.00}%";
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Enter:
                    Play();
                    btnRandom.Focus();
                    return true;
                case Keys.Escape:
                    KhoiTao();
                    btnReset.Focus();
                    return true;
                case Keys.D1:
                    ClickButton(btn1);
                    btn1.Focus();
                    return true;
                case Keys.D2:
                    ClickButton(btn2);
                    return true;
                case Keys.D3:
                    ClickButton(btn3);
                    return true;
                case Keys.D4:
                    ClickButton(btn4);
                    return true;
                case Keys.D5:
                    ClickButton(btn5);
                    return true;
                case Keys.D6:
                    ClickButton(btn6);
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btnNumberChoosen_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ClickButton(btn);
        }

        private void lstbResult_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            var item = lstbResult.Items[e.Index] as dynamic;
            string text = item.Text;
            RightWrong result = item.Result;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }

            Brush textBrush = (result == RightWrong.Right) ? Brushes.Green : Brushes.Red;

            e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds.X, e.Bounds.Y);

            e.DrawFocusRectangle();
        }

        private void ClickButton(Button btn)
        {
            picbDice.Image = Image.FromFile(path + btn.Text + ".jpg");
            foreach(Control c in grbGuessTheNumber.Controls)
            {
                if(c.GetType() == typeof(Button))
                {
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                    c.Font = new Font(c.Font, FontStyle.Regular);
                }
            }
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.White;
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.Focus();
            soNguoiChoiChon = Convert.ToInt32(btn.Text);
        }
    }
}
