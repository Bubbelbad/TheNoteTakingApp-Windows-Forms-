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
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Note note in NoteManager.listOfNotes)
            {
                availableListBox.Items.Add($"Autor: {note.Title} Title: {note.Title}");
            }
        }

    }
}
