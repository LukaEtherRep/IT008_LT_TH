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
    public partial class Cau12 : Form
    {
        int dx, dy;
        Random rand;
        
        public Cau12()
        {
            InitializeComponent();
        }

        private void Cau12_Load(object sender, EventArgs e)
        {
            dx = 4;
            dy = 3;
            rand = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(picbBall.Left < 0 || picbBall.Right > this.ClientRectangle.Width)
            {
                int varies = rand.Next(-2, 3);
                dx = -(dx + varies);
            }
            if(picbBall.Top < 0 || picbBall.Bottom > this.ClientRectangle.Height)
            {
                int varies = rand.Next(-2, 3);
                dy = -(dy + varies);
            }

            picbBall.Left += dx;
            picbBall.Top += dy;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Space:
                    timer1.Enabled = timer1.Enabled == true ? false : true;
                    return true;
                case Keys.Up:
                    if (CheckTimerEnabled(timer1))
                        dy = -Math.Abs(dy);
                    return true;
                case Keys.Down:
                    if (CheckTimerEnabled(timer1))
                        dy = Math.Abs(dy);
                    return true;
                case Keys.Left:
                    if (CheckTimerEnabled(timer1))
                        dx = -Math.Abs(dx);
                    return true;
                case Keys.Right:
                    if (CheckTimerEnabled(timer1))
                        dx = Math.Abs(dx);
                    return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dx = 4;
            dy = 3;
        }

        private bool CheckTimerEnabled(Timer timer)
        {
            return timer.Enabled;
        }
    }
}
