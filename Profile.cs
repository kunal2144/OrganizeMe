using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrganizeMe
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            panel1.Select();
            profilePicture.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void change_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";
            if (open.ShowDialog() == DialogResult.OK)
            {
                profilePicture.Image = new Bitmap(open.FileName);
            }
        }
    }
}
