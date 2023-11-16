using System.Text.Json;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TheNoteTakingApp__Windows_Forms_
{
    public partial class MainMenu : MaterialForm
    {

        NoteManager noteManager1;

        public MainMenu()
        {
            InitializeComponent();

            //Adding MaterialSkinManager to easily change the theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Amber500, Accent.Amber400, TextShade.BLACK);
            this.Text = "The Note Taking App";
            this.Top = 0;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            NoteManager noteManager = new NoteManager();
            noteManager1 = noteManager;
            noteManager.Load();

            toolStripStatusLabel1.Text = "Ready";
            createPanel1.ImportToolStrip(toolStripStatusLabel1);
            viewPanel1.ImportToolStrip(toolStripStatusLabel1);
            homePanel1.ImportToolStrip(toolStripStatusLabel1);
            homePanel1.Visible = true;
            createPanel1.Visible = false;
            viewPanel1.Visible = false;
            createPanel1.SetManager(noteManager);
            viewPanel1.SetManager(noteManager);
            viewPanel1.SetCreatePanel(createPanel1);
        }


        private void homeBtn_Click(object sender, EventArgs e)
        {
            homePanel1.Visible = true;
            createPanel1.Visible = false;
            viewPanel1.Visible = false;
            homePanel1.SetStatusLabel();
        }


        private void viewBtn_Click(object sender, EventArgs e)
        {

            homePanel1.Visible = false;
            createPanel1.Visible = false;
            viewPanel1.Visible = true;
            viewPanel1.RefreshListBox();
            viewPanel1.SetStatusLabel();
        }


        private void createBtn_Click(object sender, EventArgs e)
        {

            homePanel1.Visible = false;
            createPanel1.Visible = true;
            viewPanel1.Visible = false;
            createPanel1.SetStatusLabel();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A note taking app by Bubbelbad @ Github\n\n");
        }


        //Exit program through toolstrip file menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


        //To open new CSV-file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\Users\SOS23\source\repos\TheNoteTakingApp (Windows Forms)\bin\Debug\net6.0-windows";
            openFileDialog1.Filter = "All files (*.*)|*.*|CSV File (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                noteManager1.ChangePath(openFileDialog1.FileName);
                noteManager1.Load();
                viewBtn_Click(sender, e);
            }
        }


        //Opening dialog to ExportForm
        private void exportToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportForm exportForm = new ExportForm();
            exportForm.SetManager(noteManager1);
            exportForm.ShowDialog();
        }


        //Opening dialig to ExportJsonForm
        private void toJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportJsonForm exportJsonForm = new ExportJsonForm();
            exportJsonForm.SetManager(noteManager1);
            exportJsonForm.ShowDialog();
        }
    }
}