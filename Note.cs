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

        public Note(string author, string title, string category, bool secret, string message)
        {
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
            return Author + "," + Title + "," + Category + "," + Secret + "," + Message;
        }
    }
}
