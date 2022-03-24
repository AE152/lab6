using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace lab6.Models
{
    interface INoteStateHandler
    {
        public void AddNewNoteToFile(string Date, string Name, string Text, int ID);
        public void GetAllNotes(string Date, ObservableCollection<NoteState> ListForWriting);
    }
    

}
