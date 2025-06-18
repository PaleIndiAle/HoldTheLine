using HoldTheLine.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace HoldTheLine.Screens
{
    public partial class GameScreen : UserControl
    {
        public static bool leftArrowDown = false;
        public static bool rightArrowDown = false;

        int x = 0;
        int y = 370;
        int speed = 10;

        public GameScreen()
        {
            this.Focus();
            InitializeComponent();
            gameTimer.Start();

            FrontBox.Parent = BackBox;
            playerBox.Parent = FrontBox;
            EdwinBox.Parent = FrontBox;
            MatthieuBox.Parent = FrontBox;
            LochlanBox.Parent = FrontBox;

            BackBox.Image = HoldTheLine.Properties.Resources.HTLMapBack;
            FrontBox.Image = HoldTheLine.Properties.Resources.HTLMapFront;
            playerBox.Image = HoldTheLine.Properties.Resources.Idle;
            EdwinBox.Image = HoldTheLine.Properties.Resources.L;
            MatthieuBox.Image = HoldTheLine.Properties.Resources.NPCIdle;
            LochlanBox.Image = HoldTheLine.Properties.Resources.Lo;
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = true;
                    break;
                case Keys.D:
                    rightArrowDown = true;
                    break;
                case Keys.Escape:
                    gameTimer.Stop();
                    saveClass.SaveSave();
                    Application.Exit();
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = false;
                    break;
                case Keys.D:
                    rightArrowDown = false;
                    break;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(playerBox.Image, x, y, Width, Height);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (leftArrowDown == true && x > 0)
            {
                playerBox.Image = HoldTheLine.Properties.Resources.Left;
                x--;
            }
            else if (rightArrowDown == true && x < 2000)
            {
                playerBox.Image = HoldTheLine.Properties.Resources.Right;
                x++;
            }
            else if (leftArrowDown == false && rightArrowDown == false)
            {
                playerBox.Image = HoldTheLine.Properties.Resources.Idle;
            }
        }
    }
}
