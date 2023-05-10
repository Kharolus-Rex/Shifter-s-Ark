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
        public static void LoadItems()
        {
            using (var reader = new StreamReader("./CSVFiles/items.csv"))
            {
                //skip the first line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string description = row[2];
                    int price = int.Parse(row[3]);
                    string questItem = row[4];
                    string required = row[5];

                    //create/recreate item dynamically as lines are read
                    Item item = new Item(id, name, description, price, questItem, required);
                    World.items.Add(item);
                }
            }
        }

        public static void LoadPotions()
        {
            using (var reader = new StreamReader("./CSVFiles/potions.csv"))
            {
                //skip first line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string description = row[2];
                    int price = int.Parse(row[3]);
                    int valChange = int.Parse(row[4]);

                    Potion potion = new Potion(id, name, description, price, valChange);
                    World.potions.Add(potion);
                }
            }
        }

        public static void LoadTreasures()
        {
            using (var reader = new StreamReader("./CSVFiles/treasures.csv"))
            {
                //skip first line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string description = row[2];
                    int price = int.Parse(row[3]);
                    string questItem = row[4];

                    Treasure treasure = new Treasure(id, name, description, price, questItem);
                    World.treasures.Add(treasure);
                }
            }
        }

        public static void LoadWeapons()
        {
            using (var reader = new StreamReader("./CSVFiles/weapons.csv"))
            {
                //skip first line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string description = row[2];
                    string damage = row[3];
                    string damageType = row[4];
                    int price = int.Parse(row[5]);

                    Weapon weapon = new Weapon(id, name, description, damage, damageType, price);
                    World.weapons.Add(weapon);
                }
            }
        }

        public static void LoadRooms()
        {
            //TODO - FILL IN LOADROOM METHOD
        }

        public static void LoadMobs()
        {
            using (var reader = new StreamReader("./CSVFiles/mobs.csv"))
            {
                //skip first line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string description = row[2];
                    string race = row[3];
                    string CLass = row[4];
                    int HP = int.Parse(row[5]);
                    int AC = int.Parse(row[6]);
                    int weaponID = int.Parse(row[7]);

                    Weapon weapon = World.weapons.FirstOrDefault(w => w.IdNumber == weaponID);

                    Mob mob = new Mob(id, name, description, race, CLass, HP, AC, weapon);
                    World.mobs.Add(mob);
                }
            }
        }
    }
}
