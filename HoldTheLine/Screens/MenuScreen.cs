using HoldTheLine.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
                ContinueButton.Visible = false;
                ContinueButton.Enabled = false;
            }
            else if (saveClass.savequestionmark == "1")
            {
                ContinueButton.Visible = true;
                ContinueButton.Enabled = true;
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new SideScreen());
            saveClass.savequestionmark = "0";
            saveClass.side = "None";
            saveClass.informOthers = "0";
            saveClass.matthieuInformed = "0";
            saveClass.lochInformed = "0";
            saveClass.booze = "0";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
