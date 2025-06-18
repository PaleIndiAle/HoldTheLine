using HoldTheLine.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoldTheLine.Screens
{
    public partial class SideScreen : UserControl
    {
        public SideScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveClass.side = "Allies";
            saveClass.savequestionmark = "1";
            Form1.ChangeScreen(this, new GameScreen());
        }
    }
}
