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
            inputFile.Close();

        }

        public static void LoadPotions()
        {
            i = 0;
            inputFile = File.OpenText("Potions.txt");

            while (!inputFile.EndOfStream)
            {
                World.potions[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
            i = 0;

            inputFile = File.OpenText("PotionDescs.txt");

            while (!inputFile.EndOfStream)
            {
                World.potionDescs[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
        }

        public static void LoadTreasures()
        {
            i = 0;
            inputFile = File.OpenText("Treasures.txt");

            while (!inputFile.EndOfStream)
            {
                World.treasures[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
            i = 0;

            inputFile = File.OpenText("TreasureDescs.txt");

            while (!inputFile.EndOfStream)
            {
                World.treasureDescs[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
        }

        public static void LoadWeapons()
        {
            i = 0;
            inputFile = File.OpenText("Weapons.txt");

            while (!inputFile.EndOfStream)
            {
                World.weapons[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
            i = 0;

            inputFile = File.OpenText("WeaponDescs.txt");

            while (!inputFile.EndOfStream)
            {
                World.weaponDescs[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
        }

        //TODO - ADD ROOMS LOADER
    }
}
