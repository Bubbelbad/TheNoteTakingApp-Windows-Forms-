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
    public partial class ExportForm : Form
    {

        string folderPath;

        public ExportForm()
        {
            InitializeComponent();
        }

        public string FileInput()
        {
            string file = fileTextBox.Text;

            return "hihi";
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderPath = fbd.SelectedPath;
                    folderPathLabel.Text = folderPath.ToString();
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
          //  if (folderPathLabel.Text != "" && folderPath != "")
          //  {
          //      return folderPathLabel.Text + folderPath;
          //  }
          //  else
          //  {
          //      return folderPathLabel.Text;
          //  }
        }
    }
}
