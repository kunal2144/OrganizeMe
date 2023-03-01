using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizeMe
{
    [DataContract]
    public class Note
    {
        [JsonProperty("id")][DataMember]
        public int Id { get; set; }

        [JsonProperty("title")][DataMember]
        public string Title { get; set; }

        [JsonProperty("content")][DataMember]
        public string Content { get; set; }

        [JsonProperty("created_at")][DataMember]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")][DataMember]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("type")][DataMember]
        public string Type { get; set; }
        
        public Label noteLabel;

        public static List<Note> notes = new List<Note>();
        public static int count
        {
            get { return notes.Count; }
        }
        public static Note currentNote;

        [JsonConstructor]
        public Note(int id, string title, string content, DateTimeOffset dateCreated, DateTimeOffset updatedAt, string type)
        {
            Id = id;
            Title = title;
            Content = content;
            CreatedAt = dateCreated;
            UpdatedAt = updatedAt;
            Type= type;
            this.noteLabel = Notes.instance.createNewLabel(title);
            currentNote = this;
            notes.Add(this);
        }

        new public static string ToString()
        {
            string notes = "";
            foreach (Note note in Note.notes)
            {
                notes += $"{{\"id\": {note.Id}, \"title\": \"{note.Title}\", \"content\": \"{note.Content}\", \"created_at\": \"{note.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss zzz")}\", \"updated_at\": \"{note.UpdatedAt.ToString("yyyy-MM-dd HH:mm:ss zzz")}\", \"type\": \"{note.Type}\"}},";
            }

            notes = notes.Substring(0, notes.Length - 1);

            return notes;
        }
    }
}
