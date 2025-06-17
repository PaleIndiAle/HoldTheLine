using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace HoldTheLine.Screens
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();

            FrontBox.Parent = BackBox;
            playerBox.Parent = BackBox;
            playerBox.Location = new Point(20, 20);

            BackBox.Image = HoldTheLine.Properties.Resources.HTLMapBack;
            FrontBox.Image = HoldTheLine.Properties.Resources.HTLMapFront;
            playerBox.Image = HoldTheLine.Properties.Resources.Idle;
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.A:
            //        leftArrowDown = true;
            //        break;
            //    case Keys.D:
            //        rightArrowDown = true;
            //        break;
            //    case Keys.W:
            //        upArrowDown = true;
            //        break;
            //    case Keys.S:
            //        downArrowDown = true;
            //        break;
            //}
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
