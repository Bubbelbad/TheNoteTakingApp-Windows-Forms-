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

        string text1 = "This is a Note Taking App made as a school assignment. \n\n" +
                       "It was a great way to use file handling and getting into \ngraphic design.\n" +
                       "The hardest part was understanding how to save message \n" +
                       "as CSV, as it included commas and line change.\n" +
                       "Saving the .txt and .json with a chosen path was also \n" +
                       "a satisfying mystery to solve!\n\n\n\n" +
                       "Make sure to check out the tool strip menu:  \n\n" +
                       "• Open - lets the user open other CSV-files in the library\n" +
                       "• Export - gives you the possibility to export the current \n  open file to text or json\n";


    }
}
