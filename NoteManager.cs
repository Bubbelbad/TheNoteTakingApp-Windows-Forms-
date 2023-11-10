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


        public void CreateNote (string author, string title, string category, string message, bool secret)
        {
            listOfNotes.Add(new Note(author, title, category, message, secret));
        }



        public string path = "notes.csv";
        public void SaveAll()
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (Note note in listOfNotes)
            {
                streamWriter.WriteLine(note.GetCSV());
            }
            streamWriter.Close();
        }


        //Save the most recent created note
        public void SaveRecentNote()
        {
            StreamWriter streamWriter = new StreamWriter(path);
            int index = listOfNotes.Count - 1;
            streamWriter.WriteLine(listOfNotes[index].GetCSV());
            streamWriter.Close();
        }



        //To load all notes from csv
        public void Load()
        {
            listOfNotes.Clear();
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                try
                {
                    while (line != null)
                    {
                        string[] strings = line.Split(",");
                        string author = strings[0];
                        string title = strings[1];
                        string category = strings[2];
                        string message = strings[3];
                        bool secret = Convert.ToBoolean(strings[4]);

                        Note note = new Note(author, title, category, message, secret);
                        listOfNotes.Add(note);

                        line = reader.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
