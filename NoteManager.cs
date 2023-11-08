using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteTakingApp__Windows_Forms_
{
    public class NoteManager
    {

        public List<Note> listOfNotes = new List<Note>();


        public void CreateNote (string name, string category, string message, bool secret)
        {
            listOfNotes.Add(new Note(name, category, message, secret));
        }
    }
}
