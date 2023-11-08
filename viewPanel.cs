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
    public partial class viewPanel : UserControl
    {
        NoteManager NoteManager = null;

        public viewPanel()
        {
            InitializeComponent();

        }

        public void SetManager(NoteManager noteManager)
        {
            this.NoteManager = noteManager;
            foreach (Note note in NoteManager.listOfNotes)
            {
                availableListBox.Items.Add($"{note.Category}: {note.Title}");
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
                messageTextBox.Text = note.Message;
            }
        }



    }
}
