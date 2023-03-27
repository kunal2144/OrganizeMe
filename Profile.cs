using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrganizeMe
{
    public partial class Profile : Form
    {
        public static string profilePicturePath;

        public Profile()
        {
            InitializeComponent();
            profilePicturePath = Notes.profilePicturePath;      
        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            panel1.Select();
            profilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            if (profilePicturePath != string.Empty)
            {
                profilePicture.Image = new Bitmap(profilePicturePath);
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";
            if (open.ShowDialog() == DialogResult.OK)
            {
                profilePicturePath = open.FileName;
                Notes.profilePicturePath = profilePicturePath;
                profilePicture.Image = new Bitmap(profilePicturePath);
            }
        }
    }
}
