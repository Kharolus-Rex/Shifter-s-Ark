using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorldEngine
{
    public class WorldLoad
    {
        private static StreamReader inputFile;
        private static int i;
        public static void LoadItems()
        {
            inputFile = File.OpenText("Items.txt");

            i = 0;

            while (!inputFile.EndOfStream)
            {
                World.items[i] = inputFile.ReadLine();
                i++;
            }

            i = 0; //reset running i var

            inputFile.Close();

            inputFile = File.OpenText("ItemDescs.txt");

            while (!inputFile.EndOfStream)
            {
                World.itemDescs[i] = inputFile.ReadLine();
                i++;
            }

        }

        public static void LoadPotions()
        {

        }

        //TODO - potions, treasures, weapons and their descriptions too
    }
}
