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
    public partial class CreatePanel : UserControl
    {
        NoteManager NoteManager;
        ToolStripStatusLabel ToolStripStatusLabel1;
        public bool edit = false;
        public int editId;

        public CreatePanel()
        {
            InitializeComponent();
        }


        public void SetManager(NoteManager noteManager)
        {
            this.NoteManager = noteManager;
        }


        public void ImportToolStrip(ToolStripStatusLabel toolStripStatusLabel1)
        {
            this.ToolStripStatusLabel1 = toolStripStatusLabel1;
        }

        public void SetStatusLabel()
        {
            ToolStripStatusLabel1.Text = "create page";
        }


        //Function to save the current written note: 
        private void button1_Click(object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            string title = titleTextBox.Text;
            string category = categoryComboBox.Text;
            string message = messageTextBox.Text;
            message = message.Replace(",", "|"); //Replacing commas and new lines to be able to save as CSV
            message = message.Replace("\r\n", "#");
            bool secret = false;
            if (secretCheckBox.Checked)
            {
                secret = true;
            }

            if (edit == true)
            {
                NoteManager.ReplaceEditedNote(editId, author, title, category, secret, message);
                edit = false;
            }
            else
            {
                NoteManager.CreateNote(author, title, category, secret, message);
                NoteManager.SaveRecentNote();
            }

            ToolStripStatusLabel1.Text = "Success!";
            authorTextBox.Clear();
            titleTextBox.Clear();
            categoryComboBox.SelectedIndex = -1;
            messageTextBox.Clear();
            secretCheckBox.Checked = false;
        }


        public void EditNote(Note note)
        {
            edit = true;
            authorTextBox.Text = note.Author;
            titleTextBox.Text = note.Title;
            categoryComboBox.Text = note.Category;
            messageTextBox.Text = note.Message;
            editId = note.Id;

            if (note.Secret)
            {
                secretCheckBox.Checked = true;
            }
        }
    }
}
