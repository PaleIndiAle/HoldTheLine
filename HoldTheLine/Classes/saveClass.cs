using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HoldTheLine.Classes
{
    internal class saveClass
    {
        public static string savequestionmark, side, informOthers, matthieuInformed, lochInformed, firstLoch, booze;

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

                    reader.ReadToNextSibling("firstLoch");
                    firstLoch = reader.ReadString();

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
            writer.WriteElementString("firstLoch", firstLoch);
            writer.WriteElementString("booze", booze);

            writer.WriteEndElement();
            writer.Close();
        }
    }
}
