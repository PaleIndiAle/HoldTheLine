using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HoldTheLine.Classes
{
    internal class saveClass
    {
        public static string savequestionmark, side, informOthers, matthieuInformed, lochInformed, firstLoch, booze;

        public void LoadSave()
        {
            //Reads an XML FILE for level that player is on
            XmlReader reader = XmlReader.Create($"Resources/savefile.xml");

            while (reader.Read())
            {
                savequestionmark = reader.ReadString();

                if (savequestionmark == "1")
                {
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

                    reader.Close();
                }
                else if (savequestionmark == "0")
                {
                    reader.Close();
                }
            }
        }
    }
}
