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
    public partial class Cau25 : Form
    {
        public Cau25()
        {
            InitializeComponent();
        }

        private void Init()
        {
            string[] drivers;
            drivers = Directory.GetLogicalDrives();
            TreeNode node;

            foreach (string driver in drivers)
            {
                node = new TreeNode(driver);
                treevFolder.Nodes.Add(node);
                node.Nodes.Add("Tam");
            }
        }

        private void Cau25_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void treevFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node;
            node = e.Node;
            string[] childFolder = Directory.GetDirectories(node.FullPath);

            node.Nodes.Clear();

            TreeNode n;
            foreach (string item in childFolder)
            {
                n = node.Nodes.Add(Path.GetFileName(item));
                n.Nodes.Add("Tam");
            }
        }

        private void treevFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node;
            string[] pictureFile;
            node = e.Node;

            picbPicture.Image = null;
            flpPicture.Controls.Clear();

            pictureFile = Directory.GetFiles(node.FullPath);
            foreach(string item in pictureFile)
            {
                if (item.ToLower().EndsWith(".jpg") ||
                    item.ToLower().EndsWith(".png") ||
                    item.ToLower().EndsWith(".jpeg"))
                {
                    PictureBox picb = new PictureBox();
                    picb.Image = Image.FromFile(item);
                    picb.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                    flpPicture.Controls.Add(picb);

                    picb.Click += Pic_Click;

                    picb.Cursor = Cursors.Hand;
                }
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            picbPicture.Image = ((PictureBox)sender).Image;
        }
    }
}
