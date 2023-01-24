using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizeMe
{
    public partial class Notes : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public readonly Color LABEL_COLOUR_SELECTED = Color.FromArgb(157, 157, 157);
        public readonly Color LABEL_COLOUR_UNSELECTED = Color.FromArgb(70, 70, 70);

        public static Label currentNoteLabel;
        public static TextBox currentNoteContent;

        public static int notesCount = 1;
        public static ArrayList noteLabels = new ArrayList();
        public static ArrayList notes = new ArrayList();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Notes()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            noteLabels.Add(note1);
            notes.Add(content1);
            currentNoteLabel = (Label)noteLabels[0];
            currentNoteContent = (TextBox)notes[0];

            content1.SelectionLength = 0;
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void createNewNote_Click(object sender, EventArgs e)
        {
            notesCount++;
            Label oldNoteLabel = (Label)noteLabels[0];

            Label newNoteLabel = new Label
            {
                Name = Convert.ToString("note " + notesCount),
                Text = Convert.ToString("Note " + notesCount),
                ForeColor = oldNoteLabel.ForeColor,
                BackColor = LABEL_COLOUR_SELECTED,
                Width = oldNoteLabel.Width,
                Height = oldNoteLabel.Height,
                Padding = oldNoteLabel.Padding,
                TextAlign= oldNoteLabel.TextAlign,
                Margin= oldNoteLabel.Margin,
                BorderStyle = oldNoteLabel.BorderStyle,
                Font = oldNoteLabel.Font,
                Dock = DockStyle.Top
            };

            newNoteLabel.Click += new EventHandler(loadNote);

            noteLabels.Add(newNoteLabel);
            currentNoteLabel = newNoteLabel;
            currentNoteContent.Text = ""; // To remove
            newNoteLabel.Show();

            renderNotesList();
        }

        private void renderNotesList()
        {
            notesList.Controls.Clear();
            
            for(int i = 0; i < noteLabels.Count; i++)
            {
                if(i != noteLabels.Count - 1) 
                    ((Label)noteLabels[i]).BackColor = LABEL_COLOUR_UNSELECTED;

                notesList.Controls.Add((Label)noteLabels[i]);
            }
            
        }

        private void loadNote(object sender, EventArgs e)
        {
            currentNoteLabel.BackColor = LABEL_COLOUR_UNSELECTED;
            ((Label)sender).BackColor = LABEL_COLOUR_SELECTED;
            currentNoteLabel = (Label)sender;
            currentNoteContent.Text = ""; // To remove
        }
    }
}
