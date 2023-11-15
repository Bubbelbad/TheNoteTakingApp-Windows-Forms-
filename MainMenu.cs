using System.Text.Json;

namespace TheNoteTakingApp__Windows_Forms_
{
    public partial class MainMenu : Form
    {

        //Att fixa:
        // - Fixa så att theme åtminstone ändrar bakgrund 
        // - Gör klart så man kan välja mapp när man exporterar Text
        // - Fixa en funktion för att exportera Json

        //Att använda när jag kommer tillabak och kodar json imorgon; 

        //public void Json()
        //{
        //    using System.Text.Json;
        //    using System.Text.Json.Serialization;
        //
        //    List<data> _data = new List<data>();
        //    _data.Add(new data()
        //    {
        //        Id = 1,
        //        SSN = 2,
        //        Message = "A Message"
        //    });
        //
        //    string json = JsonSerializer.Serialize(_data);
        //    File.WriteAllText(@"D:\path.json", json);
        //}

        NoteManager noteManager1;
        public MainMenu()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NoteManager noteManager = new NoteManager();
            noteManager1 = noteManager;
            noteManager.Load();
            //  noteManager.CreateNote("Ernest", "Carthusians", "Poem", false, "We fling up flowers and laugh, we laugh across the wine;\r\n   " +
            //     "With wine we dull our souls and careful strains of art;\r\nOur cups are polished skulls round which the roses twine:\r\n   " +
            //     "None dares to look at Death who leers and lurks apart.\r\n \r\nMove on, white company, whom that has not sufficed!\r\n   " +
            //     "Our viols cease, our wine is death, our roses fail:\r\nPray for our heedlessness, O dwellers with the Christ!\r\n   " +
            //     "Though the world fall apart, surely ye shall prevail. ");
            //
            //  noteManager.CreateNote("Dan", "Diversehandlaren", "Kväde", true, "Stor och stursk har du blivit bakom din disk, den höga,\r\n" +
            //      "ingenting mer än salt och ovett har du åt kunden mer,\r\noch att krusa dig och din dräng lönar numera föga,\r\n" +
            //      "bara allt värre blir du, mer surt du på människan ser.\r\n\r\nSäg, var kom du ifrån, Noaksson med humöret,\r\n" +
            //      "du som vrålar ditt nej åt var blygsam fråga om mat?\r\nAnnorlunda du var förrän det blev ont om smöret,\r\n" +
            //      "nöden som gjort oss mjuka, har gjort dig morsk och kavat.\r\n\r\nSäg mig, har du gjort goda affärer, har du satt pängar på banken?\r\n" +
            //      "Tänker du låta pojken studera till doktor eller till präst?\r\n" +
            //      "Sparkad i ändan av kristidsturen tror du väl snart för fanken " +
            //      "att en monark du kan bli på salt och surkål och jäst.\r\n");

            toolStripStatusLabel1.Text = "Ready";
            createPanel1.ImportToolStrip(toolStripStatusLabel1);
            homePanel1.Visible = true;
            deletePanel1.Visible = false;
            createPanel1.Visible = false;
            viewPanel1.Visible = false;
            createPanel1.SetManager(noteManager);
            viewPanel1.SetManager(noteManager);
            deletePanel1.SetManager(noteManager);
            viewPanel1.SetCreatePanel(createPanel1);
        }


        private void homeBtn_Click(object sender, EventArgs e)
        {
            homePanel1.Visible = true;
            deletePanel1.Visible = false;
            createPanel1.Visible = false;
            viewPanel1.Visible = false;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {

            homePanel1.Visible = false;
            deletePanel1.Visible = false;
            createPanel1.Visible = false;
            viewPanel1.Visible = true;
            viewPanel1.RefreshListBox(); //Gör så att ListBox blir refreshad varje gång jag går in i ViewPanel

        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            homePanel1.Visible = false;
            deletePanel1.Visible = false;
            createPanel1.Visible = true;
            viewPanel1.Visible = false;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            homePanel1.Visible = false;
            deletePanel1.Visible = true;
            createPanel1.Visible = false;
            viewPanel1.Visible = false;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A note taking app by Bubbelbad @ Github\n\n");
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void switchThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void exportToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportForm exportForm = new ExportForm();
            exportForm.ShowDialog();
            noteManager1.ExportToText();
        }

        private void toJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportForm exportForm = new ExportForm();
            exportForm.ShowDialog();
            noteManager1.ExportToJson();
        }
    }
}