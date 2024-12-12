using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH_HOTEN_MSSV
{
    public partial class Cau18 : Form
    {
        #region Biến toàn cục
        string pathPicture;
        Point pointOldPic;
        bool isIntersect;
        PictureBox picbRandomImage;
        int tocDo;
        int picCount;
        #endregion

        public Cau18()
        {
            InitializeComponent();
        }

        private void RandomImage()
        {
            Random random = new Random();
            int so;
            so = random.Next(1, 17);
            picbRandomImage = new PictureBox();

            picbRandomImage.Image = Image.FromFile($"{pathPicture}character_{so:D2}.png");
            picbRandomImage.Width = picbRandomImage.Height = 90;
            picbRandomImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picbRandomImage.Location = new Point(12, 12);
            picbRandomImage.MouseDown += Cau18_MouseDown;
            picbRandomImage.MouseMove += Cau18_MouseMove;
            picbRandomImage.MouseUp += Cau18_MouseUp;
            picbRandomImage.Name = "pic" + picCount++;

            this.Controls.Add(picbRandomImage);
            picbRandomImage.BringToFront();
            label2.Text = picCount.ToString();
        }

        private void Cau18_Load(object sender, EventArgs e)
        {
            pathPicture = Application.StartupPath + @"\player\";
            isIntersect = false;
            tocDo = 5;
            picCount = 0;
            RandomImage();
        }

        private void Cau18_MouseDown(object sender, MouseEventArgs e)
        {
            // Chuyển đổi vị trí chuột trên màn hình thành tọa độ tương đối với PictureBox
            Point mousePositionRelativeToPicBox = picbRandomImage.PointToClient(MousePosition);

            // Kiểm tra nếu vị trí chuột nằm trong PictureBox
            if (picbRandomImage.ClientRectangle.Contains(mousePositionRelativeToPicBox))
            {
                pointOldPic = mousePositionRelativeToPicBox;  // Cập nhật tọa độ cũ của chuột
                isIntersect = true;  // Cho phép di chuyển hình ảnh
            }
        }

        private void Cau18_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left || isIntersect == false || PicBoxInClient(tocDo) == false)
            {
                return;
            }

            int dx, dy;
            dx = e.X - pointOldPic.X;
            dy = e.Y - pointOldPic.Y;

            picbRandomImage.Left += dx;
            picbRandomImage.Top += dy;
        }

        private void Cau18_MouseUp(object sender, MouseEventArgs e)
        {
            PicBoxInFlow();
        }

        private void PicBoxInFlow()
        {
            if (flowLPPictures.Bounds.Contains(picbRandomImage.Bounds))
            {
                flowLPPictures.Controls.Add(picbRandomImage);
                RandomImage();
            }
            isIntersect = false;
        }

        private bool PicBoxInClient(int moveSize)
        {
            bool top = picbRandomImage.Top - moveSize < 0 ? false : true;
            bool bottem = picbRandomImage.Bottom + moveSize > this.ClientSize.Height ? false : true;
            bool left = picbRandomImage.Left - moveSize < 0 ? false : true;
            bool right = picbRandomImage.Right + moveSize > this.ClientSize.Width ? false : true;
            if (top == false)
            {
                picbRandomImage.Top += 2 + moveSize;
            }
            if(bottem == false)
            {
                picbRandomImage.Top -= 2 + moveSize;
            }
            if(left == false)
            {
                picbRandomImage.Left += 2 + moveSize;
            }
            if(right == false)
            {
                picbRandomImage.Left -= 2 + moveSize;
            }
            if (top && bottem && left && right)
                return true;
            return false;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Up:
                    if (PicBoxInClient(tocDo))
                        picbRandomImage.Top -= tocDo;
                    PicBoxInFlow();
                    return true;
                case Keys.Down:
                    if (PicBoxInClient(tocDo))
                        picbRandomImage.Top += tocDo;
                    PicBoxInFlow();
                    return true;
                case Keys.Left:
                    if (PicBoxInClient(tocDo))
                        picbRandomImage.Left -= tocDo;
                    PicBoxInFlow();
                    return true;
                case Keys.Right:
                    if (PicBoxInClient(tocDo))
                        picbRandomImage.Left += tocDo;
                    PicBoxInFlow();
                    return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
