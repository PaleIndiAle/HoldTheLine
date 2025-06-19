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
        bool Talking = false;
        bool Understood = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);

        int x = 0;
        int y = 370;
        int speed = 10;

        int Edwin, Matthieu, Lochlan = 0;

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
                case Keys.Enter:
                    Understood = true;
                    break;
                case Keys.Escape:
                    gameTimer.Stop();
                    saveClass.SaveSave();
                    Application.Exit();
                    break;
                case Keys.Space:
                    bool Talking = true;
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
                case Keys.Enter:
                    Understood = false;
                    break;
                case Keys.Escape:
                    break;
                case Keys.Space:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Lochlan == 1 || Lochlan == 3 && saveClass.booze == "0")
            {
                CharacterNameLabel.Text = "Sergeant Lochlan";
                ChatLabel.Text = "Here ya are laddie!\nMake sure to bring it back when you're done with it.";
                saveClass.booze = "1";
                if (Lochlan == 1)
                {
                    Lochlan++;
                }
                button1.Visible = false;
                button2.Visible = false;
            }
            else if (Lochlan == 2 && saveClass.lochInformed == "1" && saveClass.booze == "1")
            {
                CharacterNameLabel.Text = "Sergeant Lochlan";
                ChatLabel.Text = "Alright then laddie.";
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Lochlan == 1)
            {
                CharacterNameLabel.Text = "Sergeant Lochlan";
                ChatLabel.Text = "Suit yourself laddie.";
                Lochlan++;
                button1.Visible = false;
                button2.Visible = false;
            }
            else if (Lochlan == 2)
            {
                CharacterNameLabel.Text = "Sergeant Lochlan";
                ChatLabel.Text = "Ey, I've heard about the attack.\nTell that English bastard that I'm prepared.";
                saveClass.lochInformed = "1";
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(playerBox.Image, x, y, Width, Height);

            if (Talking == true)
            {
                e.Graphics.FillRectangle(whiteBrush, 0, 576, 820, 244);
            }

            Refresh();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (leftArrowDown == true && x > 0)
            {
                playerBox.Image = HoldTheLine.Properties.Resources.Left;
                x -= speed;
            }
            else if (rightArrowDown == true && x < 2000)
            {
                playerBox.Image = HoldTheLine.Properties.Resources.Right;
                x += speed;
            }
            else if (leftArrowDown == false && rightArrowDown == false)
            {
                playerBox.Image = HoldTheLine.Properties.Resources.Idle;
            }

            if (playerBox.Location == EdwinBox.Location && Talking == true)
            {
                if (saveClass.informOthers == "0")
                {
                    CharacterNameLabel.Visible = true;
                    ChatLabel.Visible = true;
                    CharacterNameLabel.Text = "";
                    ChatLabel.Text = "Lieutenant Edwin was checking his pocket watch when he noticed me,\ngesturing me over while he got his whistle ready.";
                    Edwin++;
                }
                else if (Understood == true && saveClass.informOthers == "0" && Edwin == 1)
                {
                    CharacterNameLabel.Text = "Lieutenant Edwin";
                    ChatLabel.Text = "Get ready ol' chap,\nwe'll be going over the top soon and give those huns hell.";
                    Edwin++;
                }
                else if (Understood == true && saveClass.informOthers == "0" && Edwin == 2)
                {
                    CharacterNameLabel.Text = "Lieutenant Edwin";
                    ChatLabel.Text = "You could go tell the others to start getting ready.";
                    Edwin = 0;
                }
                else if (saveClass.informOthers == "1")
                {
                    CharacterNameLabel.Visible = true;
                    ChatLabel.Visible = true;
                    CharacterNameLabel.Text = "";
                    ChatLabel.Text = "Lieutenant Edwin noticed me looking at him and stared back coldly,\nstill with his whistle in his mouth.";
                    Edwin++;
                }
                else if (Understood == true && saveClass.informOthers == "1" && Edwin == 1)
                {
                    CharacterNameLabel.Text = "Lieutenant Edwin";
                    ChatLabel.Text = "Well?";
                    Edwin++;
                }
                else if (Understood == true && saveClass.informOthers == "1" && saveClass.matthieuInformed == "1" && saveClass.lochInformed == "1" && Edwin == 2)
                {
                    CharacterNameLabel.Text = "";
                    ChatLabel.Text = "You nod and Lieutenant Edwin nods back before getting ready on the wooden ladder,\nit rickets as he puts pressure on a step.";
                    Edwin = 0;
                }
                else if (Understood == true && saveClass.informOthers == "1" && Edwin == 3)
                {
                    Form1.ChangeScreen(this, new GameOverScreen());
                }
                else if (Understood == true && saveClass.informOthers == "1" && Edwin == 2)
                {
                    CharacterNameLabel.Text = "";
                    ChatLabel.Text = "You shake your head as Lieutenant Edwin scoffs.\nHe picks up his pocket watch again to inspect the time,\nthe small hand ticking down ever so slowly as you walked away.";
                    Edwin = 0;
                }

                if (Understood == true && Edwin == 0)
                {
                    Talking = false;
                    CharacterNameLabel.Visible = false;
                    ChatLabel.Visible = false;
                    CharacterNameLabel.Text = "";
                    ChatLabel.Text = "";
                }
            }

            if (playerBox.Location == MatthieuBox.Location && Talking == true)
            {
                if (Matthieu == 0)
                {
                    CharacterNameLabel.Visible = true;
                    ChatLabel.Visible = true;
                    CharacterNameLabel.Text = "Corporal Matthieu";
                    ChatLabel.Text = "Si tu n'as rien d'important,\nlaisse-moi tranquille.";
                    Matthieu++;
                }
                else if (Understood == true && saveClass.informOthers == "0" && Matthieu == 1)
                {
                    Talking = false;
                    CharacterNameLabel.Visible = false;
                    ChatLabel.Visible = false;
                    CharacterNameLabel.Text = "";
                    ChatLabel.Text = "";
                    Matthieu = 0;
                }
                else if (Understood == true && saveClass.informOthers == "1" && Matthieu == 1)
                {
                    CharacterNameLabel.Text = "";
                    ChatLabel.Text = "You try to inform Matthieu about the upcoming offensive in the best french you can,\nbut it is clear that he is not impressed.";
                    Edwin++;
                }
                else if (Understood == true && saveClass.informOthers == "1" && Matthieu == 2)
                {
                    CharacterNameLabel.Text = "Corporal Matthieu";
                    ChatLabel.Text = "Ton français est horrible, mais je comprends qu'on va bientôt attaquer. Je vais me préparer.";
                    saveClass.matthieuInformed = "1";
                    Matthieu++;
                }
                else if (saveClass.matthieuInformed == "1" && Matthieu == 3)
                {
                    CharacterNameLabel.Visible = true;
                    ChatLabel.Visible = true;
                    CharacterNameLabel.Text = "Corporal Matthieu";
                    ChatLabel.Text = "Va trouver quelqu'un d'autre à déranger.";
                }

                if (Understood == true && Matthieu == 3)
                {
                    Talking = false;
                    CharacterNameLabel.Visible = false;
                    ChatLabel.Visible = false;
                    CharacterNameLabel.Text = "";
                    ChatLabel.Text = "";
                }

                if (playerBox.Location == LochlanBox.Location && Talking == true)
                {
                    if (Lochlan == 0)
                    {
                        CharacterNameLabel.Visible = true;
                        ChatLabel.Visible = true;
                        CharacterNameLabel.Text = "Sergeant Lochlan";
                        ChatLabel.Text = "Ey there laddie, want a drink?";
                        Lochlan++;
                    }
                    else if (Understood == true && Lochlan == 1)
                    {
                        Talking = false;
                        CharacterNameLabel.Visible = false;
                        ChatLabel.Visible = false;
                        CharacterNameLabel.Text = "";
                        ChatLabel.Text = "Accept or Decline?";
                        button1.Visible = true;
                        button2.Visible = true;
                        button1.Text = "Accept";
                        button2.Text = "Decline";
                    }
                    else if (Lochlan == 2)
                    {
                        CharacterNameLabel.Text = "Sergeant Lochlan";
                        ChatLabel.Text = "How can I help ya laddie?";
                        if (saveClass.booze == "0")
                        {
                            button1.Visible = true;
                            button1.Text = "Alcohol?";
                        }
                        else if (saveClass.lochInformed == "0")
                        {
                            button2.Visible = true;
                            button2.Text = "Offensive";
                        }
                        else if (saveClass.lochInformed == "1" && saveClass.booze == "1")
                        {
                            button1.Visible = true;
                            button1.Text = "Nothing";
                        }
                    }

                    if (Understood == true && Lochlan == 2)
                    {
                        Talking = false;
                        CharacterNameLabel.Visible = false;
                        ChatLabel.Visible = false;
                        CharacterNameLabel.Text = "";
                        ChatLabel.Text = "";
                    }
                }
            }
        }
    }
}
