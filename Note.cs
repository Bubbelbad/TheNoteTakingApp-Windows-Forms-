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

        public Note(string author, string title, string category, string message, bool secret)
        {
            this.Author = author;
            this.Title = title; 
            this.Category = category;
            this.Message = message;
            this.Secret = secret;
        }

        public string GetInfo()
        {
            return $"Name: {Title}\n" +
                   $"Category: {Category}";
        }
    }
}
