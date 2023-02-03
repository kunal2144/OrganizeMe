using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizeMe
{
    public class Note
    {
        public readonly int id;
        public readonly string dateCreated;
        public readonly string type;
        public string content;
        public Label noteLabel;
        public static List<Note> notes = new List<Note>();
        public static int count
        {
            get { return notes.Count; }
        }
        public static Note currentNote;

        public Note(int id, string dateCreated, string content, string type, Label noteLabel)
        {
            this.id = id;
            this.dateCreated = dateCreated;
            this.content = content;
            this.noteLabel = noteLabel;
            this.type = type;
            currentNote = this;
            notes.Add(this);
        }
    }
}
