using HoldTheLine.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace HoldTheLine
{
    public partial class Form1 : Form
    {
        public static bool Termination;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
        }

        public static void ChangeScreen(UserControl current, UserControl next)
        {
            Form f = current.FindForm();
            f.Controls.Remove(current);

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2, (f.ClientSize.Height - next.Height) / 2);
            next.Focus();
            f.Controls.Add(next);
        }
    }
}
