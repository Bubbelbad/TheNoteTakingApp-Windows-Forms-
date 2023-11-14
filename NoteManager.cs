using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteTakingApp__Windows_Forms_
{
    public class NoteManager
    {

        public List<Note> listOfNotes = new List<Note>();
        public static string path = "notes.csv";

        public void CreateNote (string author, string title, string category, bool secret, string message)
        {
            listOfNotes.Add(new Note(author, title, category, secret, message));
        }


        public void ReplaceEditedNote(int editId, string author, string title, string category, bool secret, string message)
        {
            foreach (Note note in listOfNotes)
            {
                if (note.Id == editId)
                {
                    note.Author = author;
                    note.Title = title;
                    note.Category = category;
                    note.Secret = secret;
                    note.Message = message;
                }
            }
            File.Create(path).Close(); //Erasing all the previous text in path
            using (StreamWriter sw = new StreamWriter(path, true)) //Rewriting with the edited note updated.
            {
                foreach (Note note in listOfNotes)
                {
                    sw.WriteLine(note.GetCSV());
                }
            }
            Load();
        }

        //Save the most recent created note in CSV
        public void SaveRecentNote()
        {
            StreamWriter streamWriter = new StreamWriter(path, true); //Boolean here is to append instead of overwrite
            int index = listOfNotes.Count - 1;
            streamWriter.WriteLine(listOfNotes[index].GetCSV());
            streamWriter.Close();
        }



        //To load all notes from CSV-file
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
                        string author = strings[1];
                        string title = strings[2];
                        string category = strings[3];
                        bool secret = Convert.ToBoolean(strings[4]);
                        string message = strings[5];
                        message.Replace("|", ","); //Here I convert back the symbols from the CSV that I changed. 
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


        public void ExportToText()
        {
            string fileName = "newTest.txt";
            File.Create(fileName).Close(); //Erasing all the previous text in path
            using (StreamWriter sw = new StreamWriter(fileName)) //Rewriting with the edited note updated.
            {
                foreach (Note note in listOfNotes)
                {
                    sw.WriteLine(note.GetText());
                }
            }
            // Console.WriteLine("Name your file");
            // string fileName = Console.ReadLine();
            // string fileName = "newTest.txt";
            //            // if (!File.Exists(fileName))
            // {
            //     var myFile = File.Create(fileName);
            //     myFile.Close();
            // }
            //            // using (StreamWriter writer = new StreamWriter(fileName))
            // {
            //     foreach (Note textnote in listOfNotes)
            //     {
            //         writer.WriteLine(textnote.GetText);
            //     }
            // }
        }

        public void ChangePath(string newPath)
        {
            path = newPath;  
        }
    }
}
