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
        NoteManager noteManager;

        public ExportForm()
        {
            InitializeComponent();
        }

        public void SetManager(NoteManager noteManager1)
        {
            noteManager = noteManager1;
        }


        public void FileInput()
        {
            fileName = fileTextBox.Text + ".txt";
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
            //Now this function actually creates a File in the bin... But not where I want to!
            //Anyway, how do I get the noteManager in here so that I can call .ExportToText();?
            if (folderPathLabel.Text != "" && filePath != "")
            {
                File.Create(fileName).Close();
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    //Here now...how do I connect it? 
                }
                
            }
            else if (folderPathLabel.Text == "")
            {
                
            }
            else if (fileName == "")
            {

            }
        }
    }
}
