namespace TheNoteTakingApp__Windows_Forms_
{
    public partial class MainMenu : Form
    {


        public MainMenu()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NoteManager noteManager = new NoteManager();
            noteManager.Load();
            noteManager.CreateNote("Ernest", "Carthusians", "Poem", "We fling up flowers and laugh, we laugh across the wine;\r\n   " +
                "With wine we dull our souls and careful strains of art;\r\nOur cups are polished skulls round which the roses twine:\r\n   " +
                "None dares to look at Death who leers and lurks apart.\r\n \r\nMove on, white company, whom that has not sufficed!\r\n   " +
                "Our viols cease, our wine is death, our roses fail:\r\nPray for our heedlessness, O dwellers with the Christ!\r\n   " +
                "Though the world fall apart, surely ye shall prevail. ", true);

            noteManager.CreateNote("Dan", "Diversehandlaren", "Kv�de", "Stor och stursk har du blivit bakom din disk, den h�ga,\r\n" +
                "ingenting mer �n salt och ovett har du �t kunden mer,\r\noch att krusa dig och din dr�ng l�nar numera f�ga,\r\n" +
                "bara allt v�rre blir du, mer surt du p� m�nniskan ser.\r\n\r\nS�g, var kom du ifr�n, Noaksson med hum�ret,\r\n" +
                "du som vr�lar ditt nej �t var blygsam fr�ga om mat?\r\nAnnorlunda du var f�rr�n det blev ont om sm�ret,\r\n" +
                "n�den som gjort oss mjuka, har gjort dig morsk och kavat.\r\n\r\nS�g mig, har du gjort goda aff�rer, har du satt p�ngar p� banken?\r\n" +
                "T�nker du l�ta pojken studera till doktor eller till pr�st?\r\n" +
                "Sparkad i �ndan av kristidsturen tror du v�l snart f�r fanken " +
                "att en monark du kan bli p� salt och surk�l och j�st.\r\n", true);

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
            //H�r vill jag kunna refresha f�nstret med alla notes! Men hur?
            //G�r det att skapa en referens fr�n d�r dessa panels skapas och anv�nda i varje enskilt interface?

            homePanel1.Visible = false;
            deletePanel1.Visible = false;
            createPanel1.Visible = false;
            viewPanel1.Visible = true;
            viewPanel1.RefreshListBox();

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
            System.Environment.Exit(0);
        }
    }
}