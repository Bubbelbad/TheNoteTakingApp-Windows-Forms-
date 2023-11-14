using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteTakingApp__Windows_Forms_
{
    public class Note
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Message { get; set; }
        public bool Secret { get; set; }
        public int Id { get; set; }


        public static int nextId = 1;



        public Note(string author, string title, string category, bool secret, string message)
        {
            this.Id = nextId++;
            this.Author = author;
            this.Title = title; 
            this.Category = category;
            this.Secret = secret;
            this.Message = message;
        }

        public string GetCSV()
        {
            Message = Message.Replace(",", "|");
            Message = Message.Replace("\r\n", "#");
            return Id + "," + Author + "," + Title + "," + Category + "," + Secret + "," + Message;
        }

        public string GetText()
        {
            Message = Message.Replace("|", ",");
            Message = Message.Replace("#", "\r\n");
            return $"Author: {Author} \n" +
                   $"Title: {Title}\n" +
                   $"Category: {Category}\n" +
                   $"Secret: {Secret} \n\n" +
                   $"Message: \n{Message}\n\n" +
                   "-----------\n\n";

        }

        public string GetJson()
        {
            return "this will be json file";
        }



    }
}
