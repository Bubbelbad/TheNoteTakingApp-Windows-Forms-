namespace TheNoteTakingApp__Windows_Forms_
{
    public partial class MainMenu : Form
    {

        //Att fixa:
        // - Se till att filerna sparas korrekt. Nu sparas inte l�ngre nya filer. �r det verkligen smart att spara b�de p� knappen och System.Env.Exit()?
        // - Finslipa interface. Kanske �ndra f�rger? DarkTheme vore att f�redra. 
        // - Skapa en funktion f�r att exportera b�de CSV och Json
        // - Skapa en dialogruta som �ppnas, d�r man kan v�lja vilka flier som ska importeras. (B�de Json och CSV t�nker jag.)



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
            //   noteManager.CreateNote("Ernest", "Carthusians", "Poem", false, "We fling up flowers and laugh, we laugh across the wine;\r\n   " +
            //      "With wine we dull our souls and careful strains of art;\r\nOur cups are polished skulls round which the roses twine:\r\n   " +
            //      "None dares to look at Death who leers and lurks apart.\r\n \r\nMove on, white company, whom that has not sufficed!\r\n   " +
            //      "Our viols cease, our wine is death, our roses fail:\r\nPray for our heedlessness, O dwellers with the Christ!\r\n   " +
            //      "Though the world fall apart, surely ye shall prevail. ");
            // 
            //  noteManager.CreateNote("Dan", "Diversehandlaren", "Kv�de", true, "Stor och stursk har du blivit bakom din disk, den h�ga,\r\n" +
            //      "ingenting mer �n salt och ovett har du �t kunden mer,\r\noch att krusa dig och din dr�ng l�nar numera f�ga,\r\n" +
            //      "bara allt v�rre blir du, mer surt du p� m�nniskan ser.\r\n\r\nS�g, var kom du ifr�n, Noaksson med hum�ret,\r\n" +
            //      "du som vr�lar ditt nej �t var blygsam fr�ga om mat?\r\nAnnorlunda du var f�rr�n det blev ont om sm�ret,\r\n" +
            //      "n�den som gjort oss mjuka, har gjort dig morsk och kavat.\r\n\r\nS�g mig, har du gjort goda aff�rer, har du satt p�ngar p� banken?\r\n" +
            //      "T�nker du l�ta pojken studera till doktor eller till pr�st?\r\n" +
            //      "Sparkad i �ndan av kristidsturen tror du v�l snart f�r fanken " +
            //      "att en monark du kan bli p� salt och surk�l och j�st.\r\n");

            toolStripStatusLabel1.Text = "Ready";
            createPanel1.ImportToolStrip(toolStripStatusLabel1);
            homePanel1.Visible = true;
            deletePanel1.Visible = false;
            createPanel1.Visible = false;
            viewPanel1.Visible = false;
            createPanel1.SetManager(noteManager);
            viewPanel1.SetManager(noteManager);
            deletePanel1.SetManager(noteManager);
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
            viewPanel1.RefreshListBox(); //G�r s� att ListBox blir refreshad varje g�ng jag g�r in i ViewPanel

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
            MessageBox.Show("This is a note taking app by Bubbelbad\n\n");
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteManager1.SaveAll();
            System.Environment.Exit(0);
        }

        private void switchThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}