﻿using iText.Kernel.Pdf;
using iDocument = iText.Layout.Document;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

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
        public static string profilePicturePath = "";

        private Font contentFont;

        public Timer time;

        public static Notes instance = null;

        DataContractSerializer serializer = new DataContractSerializer(typeof(List<Note>));

        Timer timer;

        public Font getContentFont()
        {
            return contentFont;
        }

        public void setContentFont(Font f)
        {
            contentFont = f;
            content.Font = contentFont;
        }

        public Label createNewLabel(string text)
        {
            Label newLabel = new Label
            {
                Name = Convert.ToString("note " + (Note.count + 1)),
                Text = text,
                ForeColor = Color.FromArgb(224, 224, 224),
                BackColor = LABEL_COLOUR_SELECTED,
                Width = 200,
                Height = 46,
                Padding = new Padding(5, 0, 0, 0),
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0, 0, 0, 0),
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Microsoft Sans Serif", 15.75f),
                Dock = DockStyle.Top,
                ContextMenuStrip = noteContextMenu,
            };

            newLabel.Click += new EventHandler(loadNote);
            return newLabel;
        }

        public async Task<bool> fetchNotes()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://adkhafzctymlboywymzr.supabase.co/rest/v1/rpc/get_notes");
            request.Headers.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw");
            request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw");
            var content = new StringContent("{ \"table_name\":\"notes_" + User.CurrentUser.Id + "\" }", null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string notes = await response.Content.ReadAsStringAsync();

                List<Note> notesObj = JsonConvert.DeserializeObject<List<Note>>(notes);

                return true;
            }

            return false;
        }

        public void updateNoteSearch()
        {
            foreach (Note note in Note.notes)
            {
                if (!searchNotes.Items.Contains(note.noteLabel.Text)) searchNotes.Items.Add(note.noteLabel.Text);
            }
        }

        public Notes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            instance = this;

            ToolTip personalNoteToolTip = new ToolTip();

            personalNoteToolTip.AutoPopDelay = 5000;
            personalNoteToolTip.InitialDelay = 1000;
            personalNoteToolTip.ReshowDelay = 500;

            personalNoteToolTip.SetToolTip(this.newPersonalNote, "Create a new personal note");

            ToolTip workNoteToolTip = new ToolTip();

            workNoteToolTip.AutoPopDelay = 5000;
            workNoteToolTip.InitialDelay = 1000;
            workNoteToolTip.ReshowDelay = 500;

            workNoteToolTip.SetToolTip(this.newWorkNote, "Create a new work note");

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                saveCurrentNote();
            }
        }

        private void saveCurrentNote()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Create(saveFileDialog.FileName);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(content.Text);
                writer.Close();
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            //supabase = getSupabaseClient();
            //supabase.InitializeAsync();

            if (Note.count == 0) createNewNote_Click(newPersonalNote, new EventArgs());

            updateNoteSearch();

            content.Text = Note.currentNote.Content;
            contentFont = content.Font;

            //Indirectly renders notes through filter_personal_changed => renderNotesList
            filter_personal.Checked = true;
            content.Text = Note.currentNote.Content;
            content.SelectionLength = 0;

            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += pushData;
            //timer.Start();
        }

        private Supabase.Client getSupabaseClient()
        {
            var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var key = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            return new Supabase.Client(url, key, options);
        }

        private async void pushData(object sender, EventArgs e)
        {
            //using (FileStream fs = new FileStream("notes.xml", FileMode.Create))
            //{
            //    // Serialize the list of notes to the file
            //    serializer.WriteObject(fs, Note.notes);
            //}

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://adkhafzctymlboywymzr.supabase.co/rest/v1/rpc/delete_notes");
            request.Headers.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw");
            request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw");
            var content = new StringContent("{ \"table_name\":\"notes_" + User.CurrentUser.Id + "\" }", null, "application/json");
            request.Content = content;
            await client.SendAsync(request);

            client = new HttpClient();
            request = new HttpRequestMessage(HttpMethod.Post, "https://adkhafzctymlboywymzr.supabase.co/rest/v1/rpc/insert_notes");
            request.Headers.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw");
            request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw");

            content = new StringContent($"{{\"table_name\": \"notes_{User.CurrentUser.Id}\", \"notes_array\": [ {Note.ToString()} ]}}", null, "application/json");

            request.Content = content;
            await client.SendAsync(request);
        }

        private void createNewNote_Click(object sender, EventArgs e)
        {
            //Save current note content
            if (Note.count != 0) Note.currentNote.Content = content.Text;

            if (((Button)sender).Name == "newWorkNote")
            {
                new Note(Note.count, $"Note {Note.count}", "Erase me and start noting!", DateTimeOffset.Now, DateTimeOffset.Now, "W");
            }
            else
            {
                new Note(Note.count, $"Note {Note.count}", "Erase me and start noting!", DateTimeOffset.Now, DateTimeOffset.Now, "P");
            }

            Note.currentNote.noteLabel.Show();
            content.Text = Note.currentNote.Content;

            updateNoteSearch();

            if (((Button)sender).Name == "newWorkNote")
            {
                if (filter_work.Checked) filter_personal_CheckedChanged(sender, new EventArgs());
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

            for (int i = 0; i < Note.count; i++)
            {
                if (Note.notes[i].Type == filterType)
                {
                    if (i != Note.count - 1) (Note.notes[i].noteLabel).BackColor = LABEL_COLOUR_UNSELECTED;

                    notesList.Controls.Add(Note.notes[i].noteLabel);
                }
            }
        }

        private void loadNote(object sender, EventArgs e)
        {
            //Save current note content
            Note.currentNote.Content = content.Text;

            //Change the current note
            Note.currentNote.noteLabel.BackColor = LABEL_COLOUR_UNSELECTED;
            ((Label)sender).BackColor = LABEL_COLOUR_SELECTED;
            Note.currentNote = Note.notes.Find(note => note.noteLabel == (Label)sender);
            content.Text = Note.currentNote.Content;
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
                if (selectedNote.Type == filterType)
                {
                    loadNote(selectedNote.noteLabel, new EventArgs());
                }
                else
                {
                    if (selectedNote.Type == "P")
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
            Note.currentNote.Content = content.Text;
            pushData(this, EventArgs.Empty);
        }

        private void filter_personal_CheckedChanged(object sender, EventArgs e)
        {
            content.Enabled = true;
            emptyContent.Visible = false;
            filterType = (filter_personal.Checked) ? "P" : "W";
            renderNotesList();

            int toHighlightNoteLabelIndex = Note.notes.FindLastIndex(note =>
            {
                return (note.Type == filterType);
            });

            if (toHighlightNoteLabelIndex != -1)
            {
                Label toHighlightNoteLabel = Note.notes[toHighlightNoteLabelIndex].noteLabel;
                loadNote(toHighlightNoteLabel, new EventArgs());
            }
            else
            {
                emptyContent.Visible = true;
                content.Enabled= false;
            }
        }

        private void generateReport()
        {
            DateTime dateTime = DateTime.Now;
            PdfWriter writer = new PdfWriter("C:\\Users\\" + Environment.UserName + "\\Desktop\\" + dateTime.ToString(@"dd\_MM\_yyyy\_HHmmss") + ".pdf");
            PdfDocument pdf = new PdfDocument(writer);
            iDocument document = new iDocument(pdf);

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

            foreach (Note note in Note.notes)
            {
                Paragraph noteTitle = new Paragraph(note.noteLabel.Text)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetBold()
                    .SetFontSize(16);


                Paragraph noteData = new Paragraph(note.Content)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(14);

                document.Add(newLine);
                document.Add(noteTitle);
                document.Add(noteData);

                InitializeMyTimer();
            }

            document.Close();
            document.Close();
        }

        private void InitializeMyTimer()
        {
            time = new Timer();
            time.Interval = 30;
            time.Tick += new EventHandler(IncreaseProgressBar);
            infoProgress.Maximum = 2;
            time.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {   
            if (infoProgress.Value == 100)
            {
                time.Stop();
                infoProgress.Visible = false;
                infoProgress.Value = 0;
            }

            infoProgress.Value = infoProgress.Maximum;
            infoProgress.Maximum = infoProgress.Maximum - 1;
            infoProgress.Maximum += 2;

            if (infoProgress.Value > 70)
            {
                infoProgress.Maximum = 101;
                infoProgress.Value = 101;
                infoProgress.Maximum = 100;
            }
        }

        private void allNotes_Click(object sender, EventArgs e)
        {
            infoProgress.Visible = true;
            Note.currentNote.Content = content.Text;
            generateReport();
        }

        private void deleteNote_Click(object sender, EventArgs e)
        {
            Note.notes.Remove(Note.notes.Find(x => x.noteLabel == (Label)(((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl)));
            filter_personal_CheckedChanged(sender, e);
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTask nt = new NewTask();
            nt.Show();
        }

        private void newWorkNote_MouseEnter(object sender, EventArgs e)
        {
            info.Text = "Create a New Work Note";
        }

        private void newWorkNote_MouseExit(object sender, EventArgs e)
        {
            info.Text = "";
        }

        private void newPersonalNote_MouseEnter(object sender, EventArgs e)
        {
            info.Text = "Create a New Personal Note";
        }

        private void newPersonalNote_MouseExit(object sender, EventArgs e)
        {
            info.Text = "";
        }

        private void searchNotes_MouseEnter(object sender, EventArgs e)
        {
            info.Text = "Search for Notes";
        }

        private void searchNotes_MouseExit(object sender, EventArgs e)
        {
            info.Text = "";
        }

        private void filter_MouseEnter(object sender, EventArgs e)
        {
            info.Text = "Filter the Notes";
        }

        private void filter_MouseExit(object sender, EventArgs e)
        {
            info.Text = "";
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences p = new Preferences();
            p.Show();
        }
    }
}
