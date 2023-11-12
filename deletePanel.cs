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
    public partial class DeletePanel : UserControl
    {
        NoteManager NoteManager = null;
        ToolStripStatusLabel ToolStripStatusLabel1 = null;

        public DeletePanel()
        {
            InitializeComponent();
        }

        public void SetManager(NoteManager noteManager)
        {
            this.NoteManager = noteManager;
        }
    }
}
