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
            noteManager.CreateNote("Victor", "Roses", "Poem", "All roses are red, almost.", true);
            noteManager.CreateNote("Dan", "Diversehandlaren", "Kväde", "Stor och stursk har du blivit bakom din disk, den höga,\r\n" +
                "ingenting mer än salt och ovett har du åt kunden mer,\r\noch att krusa dig och din dräng lönar numera föga,\r\n" +
                "bara allt värre blir du, mer surt du på människan ser.\r\n\r\nSäg, var kom du ifrån, Noaksson med humöret,\r\n" +
                "du som vrålar ditt nej åt var blygsam fråga om mat?\r\nAnnorlunda du var förrän det blev ont om smöret,\r\n" +
                "nöden som gjort oss mjuka, har gjort dig morsk och kavat.\r\n\r\nSäg mig, har du gjort goda affärer, har du satt pängar på banken?\r\n" +
                "Tänker du låta pojken studera till doktor eller till präst?\r\n" +
                "Sparkad i ändan av kristidsturen tror du väl snart för fanken " +
                "att en monark du kan bli på salt och surkål och jäst.\r\n", true);
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