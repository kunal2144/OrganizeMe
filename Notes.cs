using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySqlConnector;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

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
        public static string filterType;

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

        public void fetchNotes(MySqlConnection conn)
        {
            conn.Open();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM NOTES", conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        new Note((int)reader.GetValue(0), ((DateTime)reader.GetValue(1)).ToString("yyyy'-'MM'-'dd"), (string)reader.GetValue(2), (string)reader.GetValue(3), createNewLabel());
                    }
                    updateNoteSearch();
                }
            }
            conn.Close();
        }

        public void updateNoteSearch()
        {
            foreach(Note note in Note.notes)
            {
                if(!searchNotes.Items.Contains(note.noteLabel.Text)) searchNotes.Items.Add(note.noteLabel.Text);
            }
        }

        public Notes()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            fetchNotes(new MySqlConnection("SERVER=localhost;DATABASE=organizeMe;UID=root;PASSWORD=8136"));
            if (Note.count == 0) createNewNote_Click(newPersonalNote, new EventArgs());
            filter_personal.Checked = true;
            content.Text = Note.currentNote.content;
            content.SelectionLength = 0;
        }

        private void createNewNote_Click(object sender, EventArgs e)
        {
            //Save current note content
            if(Note.count != 0) Note.currentNote.content = content.Text;

            //Change filter based on button clicked
            if(((Button)sender).Name == "newWorkNote")
            {
                new Note(Note.count, DateTime.Now.ToString("yyyy'-'MM'-'dd"), "Erase me and start noting!", "work", createNewLabel());
            } 
            else
            {
                new Note(Note.count, DateTime.Now.ToString("yyyy'-'MM'-'dd"), "Erase me and start noting!", "personal", createNewLabel());
            }
 
            Note.currentNote.noteLabel.Show();
            content.Text = Note.currentNote.content;

            updateNoteSearch();

            if (((Button)sender).Name == "newWorkNote")
            {
                if(filter_work.Checked) filter_personal_CheckedChanged(sender, new EventArgs());
                else filter_work.Checked = true;
            }
            else
            {
                if (filter_personal.Checked) filter_personal_CheckedChanged(sender, new EventArgs());
                else filter_personal.Checked = true;
            }
        }

        private void renderNotesList()
        {
            notesList.Controls.Clear();
            
            for(int i = 0; i < Note.count; i++)
            {
                if (Note.notes[i].type == filterType)
                {
                    if (i != Note.count - 1) (Note.notes[i].noteLabel).BackColor = LABEL_COLOUR_UNSELECTED;
                    
                    notesList.Controls.Add(Note.notes[i].noteLabel);
                }
            }
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
            content.SelectionStart = content.Text.Length;
            content.SelectionLength = 0;
        }

        private void searchNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note selectedNote = Note.notes.Find(note =>
            {
                if (note.noteLabel.Text == searchNotes.Text) return true;
                else return false;
            });

            if (selectedNote != null)
            {
                if (selectedNote.type == filterType)
                {
                    loadNote(selectedNote.noteLabel, new EventArgs());
                }
                else
                {
                    if(selectedNote.type == "personal")
                    {
                        filter_personal.Checked = true;
                    }
                    else
                    {
                        filter_work.Checked = true;
                    }

                    loadNote(selectedNote.noteLabel, new EventArgs());
                }
            }

            searchNotes.Text = "";
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

                String query = "insert into notes values ";

                foreach (Note note in Note.notes)
                {
                    query += String.Format("(null, '{0}', '{1}', '{2}'), ", note.dateCreated, note.content, note.type);
                }

                query = query.Substring(0, query.Length - 2);

                reader = new MySqlCommand(query, connection).ExecuteReader();
                while (reader.Read()) { }
                reader.Close();
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

        private void filter_personal_CheckedChanged(object sender, EventArgs e)
        {
            filterType = (filter_personal.Checked) ? "personal" : "work";
            renderNotesList();

            int toHighlightNoteLabelIndex = Note.notes.FindLastIndex(note =>
            {
                return (note.type == filterType);
            });

            if(toHighlightNoteLabelIndex != -1)
            {
                Label toHighlightNoteLabel = Note.notes[toHighlightNoteLabelIndex].noteLabel;
                loadNote(toHighlightNoteLabel, new EventArgs());
            }
        }

        private void generateReport()
        {
            DateTime dateTime = DateTime.Now;
            PdfWriter writer = new PdfWriter("C:\\Users\\jkuna\\Desktop\\" + dateTime.ToString(@"dd\_MM\_yyyy\_HHmmss") + ".pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Paragraph header = new Paragraph("Notes Dump")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetBold()
               .SetFontSize(20);

            Paragraph timeStamp = new Paragraph(dateTime.ToString(@"dd-MM-yyy HH:mm:ss"))
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetFontSize(10);

            Paragraph newLine = new Paragraph("")
                .SetFontSize(20);

            document.Add(header);
            document.Add(timeStamp);

            foreach(Note note in Note.notes)
            {
                Paragraph noteTitle = new Paragraph(note.noteLabel.Text)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetBold()
                    .SetFontSize(16);
                

                Paragraph noteData = new Paragraph(note.content) 
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(14);

                document.Add(newLine);
                document.Add(noteTitle);
                document.Add(noteData);
            }

            document.Close();
        }

        private void exportNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note.currentNote.content = content.Text;
            generateReport();
        }
    }
}
