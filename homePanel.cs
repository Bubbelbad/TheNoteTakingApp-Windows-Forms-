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
                       "Make sure to check out the tool strip menu:  \n\n" +
                       "• Open - lets the user open other CSV-files in the library\n" +
                       "• Export - gives you the possibility to export the current \n  open file to text or json\n" +
                       "• Change theme - gives you the option to change the theme \n  (at least the background)\n";


    }
}
