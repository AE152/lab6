using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Models
{
    public class NoteState
    {      

        public string Title { get; set; } // Name of Note, Default Name = "Note #{uid}"
        public string Text { get; set; }
        public DateTimeOffset Date { get; set; }

        public NoteState(string name, string description, DateTimeOffset date)
        {
            Date = date;
            Text = description;
            Title = name;
        }
    }
}
