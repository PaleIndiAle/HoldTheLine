using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HoldTheLine.Screens
{
    public partial class GameOverScreen : UserControl
    {
        SoundPlayer whistling = new SoundPlayer(Properties.Resources.Whistle);

        public GameOverScreen()
        {
            InitializeComponent();
            whistling.Play();
        }
    }
}
