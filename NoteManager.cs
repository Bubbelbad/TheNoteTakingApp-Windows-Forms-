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
        public string path = "notes.csv";

        public void CreateNote (string author, string title, string category, bool secret, string message)
        {
            listOfNotes.Add(new Note(author, title, category, secret, message));
        }


        //Not sure if I should keep this function. 
        public void SaveAll()
        {
            StreamWriter streamWriter = new StreamWriter(path, false);
            foreach (Note note in listOfNotes)
            {
                streamWriter.WriteLine(note.GetCSV());
            }
            streamWriter.Close();
        }



        //Save the most recent created note in CSV
        public void SaveRecentNote()
        {
            StreamWriter streamWriter = new StreamWriter(path, true); //Boolean here is to append instead of overwrite
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
                        bool secret = Convert.ToBoolean(strings[3]);
                        string message = strings[4];
                        message.Replace("|", ",");
                        message.Replace("#,", "\r\n");

                        Note note = new Note(author, title, category, secret, message);
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



        public void DeleteNoteCSV(int index)
        {
            List<string> linesList = File.ReadAllLines(path).ToList();
            try
            {
                linesList.RemoveAt(index);
                File.WriteAllLines(path, linesList);
            }
            catch
            {
                return;
            }   
        }
    }
}
