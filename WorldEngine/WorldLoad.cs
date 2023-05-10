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

        public static List<string[]> ReadCSVFile(string fileName)
        {
            List<string[]> data = new List<string[]>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    data.Add(line.Split(','));
                }
            }

                return data;
        }
        public static void LoadItems()
        {
            inputFile = File.OpenText(@"CSVFiles\items.csv");

            i = 0;

            if (i == 0)
            {
                inputFile.ReadLine();
            }
            while (!inputFile.EndOfStream)
            {

            }
            //while (!inputFile.EndOfStream)
            //{
            //    World.items[i] = inputFile.ReadLine();
            //    i++;
            //}

            //i = 0; //reset running i var

            //inputFile.Close();

            //inputFile = File.OpenText(@"TextFiles\ItemsPotsTreasureWeapons\ItemDescs.txt");

            //while (!inputFile.EndOfStream)
            //{
            //    World.itemDescs[i] = inputFile.ReadLine();
            //    i++;
            //}
            //inputFile.Close();

        }

        public static void LoadPotions()
        {
            i = 0;
            inputFile = File.OpenText(@"TextFiles\ItemsPotsTreasureWeapons\Potions.txt");

            while (!inputFile.EndOfStream)
            {
                World.potions[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
            i = 0;

            inputFile = File.OpenText(@"TextFiles\ItemsPotsTreasureWeapons\PotionDescs.txt");

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
            inputFile = File.OpenText(@"TextFiles\ItemsPotsTreasureWeapons\Treasures.txt");

            while (!inputFile.EndOfStream)
            {
                World.treasures[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
            i = 0;

            inputFile = File.OpenText(@"TextFiles\ItemsPotsTreasureWeapons\TreasureDescs.txt");

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
            inputFile = File.OpenText(@"TextFiles\ItemsPotsTreasureWeapons\Weapons.txt");

            while (!inputFile.EndOfStream)
            {
                World.weapons[i] = inputFile.ReadLine();
                World.weaponDmg[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
            i = 0;

            inputFile = File.OpenText(@"TextFiles\ItemsPotsTreasureWeapons\WeaponDescs.txt");

            while (!inputFile.EndOfStream)
            {
                World.weaponDescs[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
        }

        public static void LoadRooms()
        {
            i = 0;
            inputFile = File.OpenText(@"TextFiles\RoomsAndLocations\Rooms.txt");

            while (!inputFile.EndOfStream)
            {
                World.rooms[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
            i = 0;

            inputFile = File.OpenText(@"TextFiles\RoomsAndLocations\RoomDescs.txt");

            while (!inputFile.EndOfStream)
            {
                World.roomDescs[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
        }

        public static void LoadMobs()
        {
            i = 0;
            inputFile = File.OpenText(@"TextFiles\Mobs\Mobs.txt");

            while (!inputFile.EndOfStream)
            {
                World.mobs[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
            i = 0;

            inputFile = File.OpenText(@"TextFiles\Mobs\MobDescs.txt");

            while (!inputFile.EndOfStream)
            {
                World.mobDescs[i] = inputFile.ReadLine();
                i++;
            }
            inputFile.Close();
        }
    }
}
