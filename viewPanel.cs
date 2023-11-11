using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNoteTakingApp__Windows_Forms_
{
    public partial class ViewPanel : UserControl
    {
        NoteManager NoteManager = null;



        public ViewPanel()
        {
            InitializeComponent();

        }



        //Importing the same Manager as every panel has to edit the notes
        public void SetManager(NoteManager noteManager)
        {
            this.NoteManager = noteManager;
            foreach (Note note in NoteManager.listOfNotes)
            {
                availableListBox.Items.Add($"{note.Title}");
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = availableListBox.SelectedIndex;
            if (index > -1)
            {
                Note note = NoteManager.listOfNotes[index];

                title2.Text = note.Title;
                author2.Text = note.Author;
                category2.Text = note.Category;
                messageTextBox.Text = note.Message.Replace("|", ",");
                messageTextBox.Text = note.Message.Replace("#", "\r\n");
            }
        }



        public void RefreshListBox()
        {
            availableListBox.Items.Clear();
            int index = 0;
            foreach (Note note in NoteManager.listOfNotes)
            {
                try
                {
                    if (note.Title == availableListBox.Items[index].ToString())
                    {
                        index++;
                    }
                }
                catch
                {
                    availableListBox.Items.Add($"{note.Title}");
                    index++;
                }
            }

        }


        //Load function - Här ska man kunna hämta filer med olika note-objekt.
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            NoteManager.Load();
            RefreshListBox();
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = availableListBox.SelectedIndex;
            if ( index > -1 )
            {
                NoteManager.DeleteNoteCSV(index); 
                NoteManager.listOfNotes.RemoveAt(index);
                availableListBox.Items.RemoveAt(index);
                RefreshListBox();
            }
        }
    }
}
