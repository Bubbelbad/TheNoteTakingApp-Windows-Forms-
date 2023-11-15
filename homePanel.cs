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
    public partial class homePanel : UserControl
    {
        public homePanel()
        {
            InitializeComponent();
            label1.Text = text1;
        }

        string text1 = "This is a Note Taking App made for a school assignment. \n\n" +
                       "There are a few things besides the obvious that you can do: \n\n" +
                       "- Under the tab File -> Open, you can open other CSV-files\n" +
                       "- Export gives you the possibility to export the current file to text or json\n" +
                       "- Tools menu gives you the option to change the theme (bit basic tho)\n";


    }
}
