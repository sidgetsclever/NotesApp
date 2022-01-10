using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApp.Models
{
    public class Note
    {
        public int id { get; set; }
        public string NoteTitle { get; set; }
        public string NoteBody { get; set; }

        public Note()
        {

        }
    }
}
