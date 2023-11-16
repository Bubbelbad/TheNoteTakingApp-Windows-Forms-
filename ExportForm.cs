using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace TheNoteTakingApp__Windows_Forms_
{
    public partial class ExportForm : Form
    {

        string filePath;
        string fileName;
        bool textOrJsonBoolean;
        NoteManager noteManager;

        public ExportForm()
        {
            InitializeComponent();
        }

        public void SetManager(NoteManager noteManager1, bool textOrJson)
        {
            noteManager = noteManager1;
            textOrJsonBoolean = textOrJson;
        }


        public string FileInput()
        {
            if (textOrJsonBoolean)
            {
                fileName = fileTextBox.Text + ".txt";
                return fileName;
            }
            else
            {
                fileName = fileTextBox.Text + ".json";
                return fileName;
            }
        }


        private void folderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    filePath = fbd.SelectedPath;
                    folderPathLabel.Text = filePath.ToString();
                    FileInput();
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (folderPathLabel.Text != "" && filePath != "")
            {

                noteManager.ExportToText(fileName, filePath);
            }
            else if (folderPathLabel.Text == "")
            {

            }
            else if (fileName == "")
            {

            }
            Close();
        }
    }
}
