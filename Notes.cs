using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static OrganizeMe.Notes;

namespace OrganizeMe
{
    public partial class Notes : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static readonly Color LABEL_COLOUR_SELECTED = Color.FromArgb(157, 157, 157);
        public static readonly Color LABEL_COLOUR_UNSELECTED = Color.FromArgb(70, 70, 70);

        public static Label currentNoteLabel;
        public static TextBox currentNoteContent;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Label createNewLabel()
        {
            Label newLabel = new Label
            {
                Name = Convert.ToString("note " + (Note.count+1)),
                Text = Convert.ToString("Note " + (Note.count+1)),
                ForeColor = Color.FromArgb(224, 224, 224),
                BackColor = LABEL_COLOUR_SELECTED,
                Width = 200,
                Height = 46,
                Padding = new Padding(5, 0, 0, 0),
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0, 0, 0, 0),
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Microsoft Sans Serif", 15.75f),
                Dock = DockStyle.Top
            };

            newLabel.Click += new EventHandler(loadNote);
            return newLabel;
        }

        public class Note
        {
            public readonly int id;
            public readonly string dateCreated;
            public string content;
            public Label noteLabel;
            public static List<Note> notes = new List<Note>(); 
            public static int count
            {
                get { return notes.Count; }
            }
            public static Note currentNote;

            public Note(int id, string dateCreated, string content, Label noteLabel)
            {
                this.id = id;
                this.dateCreated = dateCreated;
                this.content = content;
                this.noteLabel = noteLabel;
                currentNote = this;
                notes.Add(this);
                Debug.WriteLine(this.dateCreated);
            }
        }

        public void fetchNotes(MySqlConnection conn)
        {
            conn.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM NOTES", conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        new Note((int)reader.GetValue(0), ((DateTime)reader.GetValue(1)).ToString("yyyy'-'MM'-'dd"), (string)reader.GetValue(2), createNewLabel());
                    }
                }
            }
            conn.Close();
        }

        public Notes()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            fetchNotes(new MySqlConnection("SERVER=localhost;DATABASE=organizeMe;UID=root;PASSWORD=8136"));
            if (Note.count == 0) createNewNote_Click(createNewNote, new EventArgs());
            renderNotesList();
            content.SelectionLength = 0;
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
            //Save current note content
            if(Note.count != 0) Note.currentNote.content = content.Text;

            new Note(Note.count, DateTime.Now.ToString("yyyy'-'MM'-'dd"), "Erase me and start noting!", createNewLabel());
            Note.currentNote.noteLabel.Show();

            renderNotesList();
        }

        private void renderNotesList()
        {
            notesList.Controls.Clear();
            
            for(int i = 0; i < Note.count; i++)
            {
                if(i != Note.count - 1)
                    (Note.notes[i].noteLabel).BackColor = LABEL_COLOUR_UNSELECTED;

                notesList.Controls.Add(Note.notes[i].noteLabel);
            }

            content.Text = Note.currentNote.content;
            
        }

        private void loadNote(object sender, EventArgs e)
        {
            //Save current note content
            Note.currentNote.content = content.Text;

            //Change the current note
            Note.currentNote.noteLabel.BackColor = LABEL_COLOUR_UNSELECTED;
            ((Label)sender).BackColor = LABEL_COLOUR_SELECTED;
            Note.currentNote = Note.notes.Find(note => note.noteLabel == (Label)sender);
            content.Text = Note.currentNote.content;
        }

        private void Notes_FormClosing(object sender, FormClosingEventArgs e)
        {
            String connectionString = "SERVER=localhost;DATABASE=organizeMe;UID=root;PASSWORD=8136";
            MySqlConnection connection = null;

            //Saving current note content
            Note.currentNote.content = content.Text;

            try
            {
                connection = new MySqlConnection(connectionString);
                MySqlDataReader reader;
                connection.Open();

                reader = new MySqlCommand("truncate notes", connection).ExecuteReader();
                while (reader.Read()) { }
                reader.Close();

                reader = new MySqlCommand("alter table notes auto_increment = 0", connection).ExecuteReader();
                while (reader.Read()) { }
                reader.Close();

                foreach (Note note in Note.notes)
                {
                    String query = String.Format("insert into notes values (null, '{0}', '{1}')", note.dateCreated, note.content);
                            
                    reader = new MySqlCommand(query, connection).ExecuteReader();
                    while (reader.Read()) { }
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
