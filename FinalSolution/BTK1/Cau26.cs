using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTK1
{
    public partial class Cau26 : Form
    {
        public Cau26()
        {
            InitializeComponent();
        }

        private void Cau26_Load(object sender, EventArgs e)
        {

        }

        private void Cau26_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush solidBrush;
            HatchBrush hatchBrush;
            LinearGradientBrush linearGradientBrush;
            TextureBrush textureBrush;
            Image image;

            solidBrush = new SolidBrush(Color.Blue);
            hatchBrush = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Yellow, Color.Red);
            linearGradientBrush = new LinearGradientBrush(new Rectangle(10, 10, 10, 10),
                Color.Blue, Color.White, LinearGradientMode.Horizontal);

            image = Image.FromFile(@"C:\Recent\Games\Arknights Endfield\Illustration\Chibi\ENDFIELD.jpg");
            textureBrush = new TextureBrush(image);

            string chuoi = "HELLO";
            Font font = new Font("Segoe UI", 50, FontStyle.Bold);

            StringFormat format = new StringFormat();

            format.Alignment = StringAlignment.Far;
            g.DrawString(chuoi, font, solidBrush, ClientRectangle, format);

            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Far;
            g.DrawString(chuoi, font, textureBrush, ClientRectangle, format);

            format.FormatFlags = StringFormatFlags.DirectionVertical;
            format.LineAlignment = StringAlignment.Near;
            g.DrawString(chuoi, font, hatchBrush, ClientRectangle, format);

            format.Alignment = StringAlignment.Far;
            format.LineAlignment = StringAlignment.Far;
            g.DrawString(chuoi, font, linearGradientBrush, ClientRectangle, format);

        }
    }
}
