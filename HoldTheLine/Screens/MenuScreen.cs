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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
            saveClass.LoadSave();
            
            if (saveClass.savequestionmark == "0")
            {
                ContinueButton.BackColor = Color.Gray;
                ContinueButton.Enabled = false;
            }
            else if (saveClass.savequestionmark == "1")
            {
                ContinueButton.BackColor = Color.White;
                ContinueButton.Enabled = true;
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (saveClass.side == "Allies")
            {
                Form1.ChangeScreen(this, new GameScreen());
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new SideScreen());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
