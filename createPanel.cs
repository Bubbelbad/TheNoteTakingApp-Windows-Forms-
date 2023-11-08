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
    public partial class createPanel : UserControl
    {
        NoteManager NoteManager = null;
        ToolStripStatusLabel ToolStripStatusLabel1 = null;

        string author;
        string title;
        string category;
        string message;
        bool secret;

        public createPanel()
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


        private void button1_Click(object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            string title = titleTextBox.Text;
            string category = categoryComboBox.Text;
            string message = messageTextBox.Text;
            bool secret = secretCheckBox.Checked;

            NoteManager.CreateNote(author, title, category, message, secret);
            ToolStripStatusLabel1.Text = "Success!";

            authorTextBox.Clear();
            titleTextBox.Clear();
            categoryLabel = default;
            messageTextBox.Clear();
            secretCheckBox.Checked = false;
        }


    }
}
