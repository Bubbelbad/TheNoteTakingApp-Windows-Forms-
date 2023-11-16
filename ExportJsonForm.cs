using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TheNoteTakingApp__Windows_Forms_
{
    public partial class ExportJsonForm : MaterialForm
    {
        string filePath;
        string fileName;
        NoteManager noteManager;


        public ExportJsonForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Amber500, Accent.Amber400, TextShade.BLACK);
            this.Text = "The Note Taking App";
            this.Top = 0;
        }


        //Importing notemanager and 
        public void SetManager(NoteManager noteManager1)
        {
            noteManager = noteManager1;
        }


        //To get the file ending right
        public string AddFileEnding()
        {
            fileName = fileTextBox.Text + ".json";
            return fileName;
        }


        //To choose dialog window - choosing directory for file
        private void folderButton_Click_1(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    filePath = fbd.SelectedPath;
                    folderPathLabel.Text = filePath.ToString();
                    AddFileEnding();
                }
            }
        }


        //Making sure all the info is there before exporting Json
        private void exportButton_Click(object sender, EventArgs e)
        {
            if (folderPathLabel.Text != "" && filePath != "" && fileTextBox.Text != "")
            {
                bool status = noteManager.ExportToJson(fileName, filePath);
                if (!status)
                {
                    MessageBox.Show("Not a valid file name or folder path - try again");
                    fileTextBox.Text = "";
                    folderPathLabel.Text = "";
                }
                else
                {
                    Close();
                }
            }
            else if (fileTextBox.Text == "")
            {
                fileErrorLabel.Text = "Write a file name";
            }
            else if (folderPathLabel.Text == "")
            {
                directoryErrorLabel.Text = "Choose directory";
            }
        }
    }
}
