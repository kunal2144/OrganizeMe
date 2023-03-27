using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizeMe
{
    public partial class Preferences : Form
    {
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();
        Label currentPref;

        public static readonly Color LABEL_COLOUR_SELECTED = Color.FromArgb(157, 157, 157);
        public static readonly Color LABEL_COLOUR_UNSELECTED = Color.FromArgb(70, 70, 70);

        private void setCurrentPref(object sender, System.EventArgs e)
        {
            if (currentPref != null)
            {
                currentPref.BackColor = LABEL_COLOUR_UNSELECTED;
            }

            currentPref = (Label) sender;
            pref.Controls.Clear();
            pref.Controls.Add(panels[currentPref.Name + "Pref"]);

            currentPref.BackColor = LABEL_COLOUR_SELECTED;
        }

        public Preferences()
        {
            InitializeComponent();
            Font f = Notes.instance.getContentFont();
            currentFont.Text = f.Name + ", " + f.Style + ", " + f.Size + "pt";

            foreach (Label l in headings.Controls)
            {
                l.Click += new System.EventHandler(setCurrentPref);
            }

            foreach (Panel p in pref.Controls)
            {
                panels.Add(p.Name, p);
            }
            
            pref.Controls.Clear();
            pref.Controls.Add(panels["generalPref"]);
            currentPref = (Label) headings.Controls.Find("general", true)[0];
            currentPref.BackColor = LABEL_COLOUR_SELECTED;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = Notes.instance.getContentFont();
            fd.ShowDialog();
            Notes.instance.setContentFont(fd.Font);
            currentFont.Text = fd.Font.Name + ", " + fd.Font.Style + ", " + fd.Font.Size + "pt";
        }
    }
}
