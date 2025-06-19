using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HoldTheLine.Classes
{
    internal class saveClass
    {
        public static string savequestionmark, side, informOthers, matthieuInformed, lochInformed, booze;

        public static void LoadSave()
        {
            //Reads save file
            XmlReader reader = XmlReader.Create($"Resources/savefile.xml", null);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    savequestionmark = reader.ReadString();

                    reader.ReadToNextSibling("side");
                    side = reader.ReadString();

                    reader.ReadToNextSibling("informOthers");
                    informOthers = reader.ReadString();

                    reader.ReadToNextSibling("matthieuInformed");
                    matthieuInformed = reader.ReadString();

                    reader.ReadToNextSibling("lochInformed");
                    lochInformed = reader.ReadString();

                    reader.ReadToNextSibling("booze");
                    booze = reader.ReadString();
                }
                reader.Close();
            }
        }

        public static void SaveSave()
        {
            XmlWriter writer = XmlWriter.Create($"Resources/savefile.xml");

            writer.WriteStartElement("PlayerSave");

            writer.WriteElementString("savequestionmark", savequestionmark);
            writer.WriteElementString("side", side);
            writer.WriteElementString("informOthers", informOthers);
            writer.WriteElementString("matthieuInformed", matthieuInformed);
            writer.WriteElementString("lochInformed", lochInformed);
            writer.WriteElementString("booze", booze);

            writer.WriteEndElement();
            writer.Close();
        }
    }

    //public partial class GameScreen : UserControl
    //{
    //    public static bool leftArrowDown = false;
    //    public static bool rightArrowDown = false;

    //    int x = 0;
    //    int y = 370;
    //    int speed = 10;

    //    public GameScreen()
    //    {
    //        this.Focus();
    //        InitializeComponent();
    //        gameTimer.Start();

    //        FrontBox.Parent = BackBox;
    //        playerBox.Parent = FrontBox;
    //        EdwinBox.Parent = FrontBox;
    //        MatthieuBox.Parent = FrontBox;
    //        LochlanBox.Parent = FrontBox;

    //        BackBox.Image = HoldTheLine.Properties.Resources.HTLMapBack;
    //        FrontBox.Image = HoldTheLine.Properties.Resources.HTLMapFront;
    //        playerBox.Image = HoldTheLine.Properties.Resources.Idle;
    //        EdwinBox.Image = HoldTheLine.Properties.Resources.L;
    //        MatthieuBox.Image = HoldTheLine.Properties.Resources.NPCIdle;
    //        LochlanBox.Image = HoldTheLine.Properties.Resources.Lo;
    //    }

    //    private void GameScreen_KeyDown(object sender, KeyEventArgs e)
    //    {
    //        switch (e.KeyCode)
    //        {
    //            case Keys.A:
    //                leftArrowDown = true;
    //                break;
    //            case Keys.D:
    //                rightArrowDown = true;
    //                break;
    //            case Keys.Escape:
    //                gameTimer.Stop();
    //                saveClass.SaveSave();
    //                Application.Exit();
    //                break;
    //        }
    //    }

    //    private void GameScreen_KeyUp(object sender, KeyEventArgs e)
    //    {
    //        switch (e.KeyCode)
    //        {
    //            case Keys.A:
    //                leftArrowDown = false;
    //                break;
    //            case Keys.D:
    //                rightArrowDown = false;
    //                break;
    //        }
    //    }

    //    private void GameScreen_Paint(object sender, PaintEventArgs e)
    //    {
    //        e.Graphics.DrawImage(playerBox.Image, x, y, Width, Height);
    //    }

    //    private void gameTimer_Tick(object sender, EventArgs e)
    //    {
    //        if (leftArrowDown == true && x > 0)
    //        {
    //            playerBox.Image = HoldTheLine.Properties.Resources.Left;
    //            x--;
    //        }
    //        else if (rightArrowDown == true && x < 2000)
    //        {
    //            playerBox.Image = HoldTheLine.Properties.Resources.Right;
    //            x++;
    //        }
    //        else if (leftArrowDown == false && rightArrowDown == false)
    //        {
    //            playerBox.Image = HoldTheLine.Properties.Resources.Idle;
    //        }
    //    }
    //}
}
