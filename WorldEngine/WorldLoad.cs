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
            using (var reader = new StreamReader("./CSVFiles/rooms.csv"))
            {
                //skip the first line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var row = reader.ReadLine().Split(',');

                    List<int> exits = new List<int>();

                    int id = int.Parse(row[0]);
                    string name = row[1];
                    string description = row[2];
                    exits.Add(int.Parse(row[3]));
                    exits.Add(int.Parse(row[4]));
                    exits.Add(int.Parse(row[5]));
                    exits.Add(int.Parse(row[6]));
                    int potions = int.Parse(row[7]);
                    int weapons = int.Parse(row[8]);
                    int mobs = int.Parse(row[9]);
                    int treasures = int.Parse(row[10]);
                    int items = int.Parse(row[11]);

                    List<Potion> potion = new List<Potion> { World.potions.FirstOrDefault(p => p.IdNumber == potions) };
                    List<Weapon> weapon = new List<Weapon> { World.weapons.FirstOrDefault(w => w.IdNumber == weapons) };
                    List<Mob> mob = new List<Mob> { World.mobs.FirstOrDefault(m => m.IdNumber == mobs) };
                    List<Treasure> treasure = new List<Treasure> { World.treasures.FirstOrDefault(t => t.IdNumber == treasures) };
                    List<Item> item = new List<Item> { World.items.FirstOrDefault(i => i.IdNumber == items) };

                    Room room = new Room(id, name, description, exits, potion, weapon, mob, treasure, item);
                    World.rooms.Add(room);
                }
            }
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

        public static void LoadPlayer()
        {
            using (var reader = new StreamReader("./CSVFiles/players.csv"))
            {
                //skip first
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var data = reader.ReadLine().Split(',');

                    int idNumber = int.Parse(data[0]);
                    string name = data[1];
                    string password = data[2];
                    string race = data[3];
                    string playerClass = data[4];
                    int hp = int.Parse(data[5]);
                    int ac = int.Parse(data[6]);
                    int location = int.Parse(data[7]);
                    int items = int.Parse(data[8]);
                    int potions = int.Parse(data[9]);
                    int weapons = int.Parse(data[10]);
                    int treasures = int.Parse(data[11]);
                    string quests = data[12];

                    List<Item> item = new List<Item> { World.items.FirstOrDefault(i => i.IdNumber == items) };
                    List<Potion> potion = new List<Potion> { World.potions.FirstOrDefault(p => p.IdNumber == potions) };
                    List<Weapon> weapon = new List<Weapon> { World.weapons.FirstOrDefault(w => w.IdNumber == weapons) };
                    List<Treasure> treasure = new List<Treasure> { World.treasures.FirstOrDefault(t => t.IdNumber == treasures) };
                    List<string> quest = new List<string>();

                    Player player = new Player(idNumber, name, password, race, playerClass, hp, ac, location, item, potion, weapon, treasure, quest);
                    World.players.Add(player);
                }
            }
        }
    }
}
