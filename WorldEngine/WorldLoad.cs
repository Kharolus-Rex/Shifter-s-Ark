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
            //take two
            //TAKE TWO WORKED AAAAAAAAYYYYYYYYYYYYY
            using (StreamReader reader = new StreamReader("./CSVFiles/rooms.csv"))
            {
                List<Room> rooms = new List<Room>();

                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var data = reader.ReadLine().Split(',');

                    int id = int.Parse(data[0]);
                    string name = data[1];
                    string description = data[2];
                    List<int> Exits = new List<int> { int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]) };
                    int potions = data[7] != "" ? potions = int.Parse(data[7]) : potions = 0;
                    int weapons = data[8] != "" ? weapons = int.Parse(data[8]) : weapons = 0;
                    int mobs = data[9] != "" ? mobs = int.Parse(data[9]) : mobs = 0;
                    int treasures = data[10] != "" ? treasures = int.Parse(data[10]) : treasures = 0;
                    int items = data[11] != "" ? items = int.Parse(data[11]) : items = 0;

                    

                    List<Potion> potion = data[7] != "0" ? new List<Potion> { World.potions.FirstOrDefault(p => p.IdNumber == potions) } : new List<Potion>();
                    List<Weapon> weapon = data[8] != "0" ? new List<Weapon> { World.weapons.FirstOrDefault(w => w.IdNumber == weapons) } : new List<Weapon>();
                    List<Mob> mob = data[9] != "0" ? new List<Mob> { World.mobs.FirstOrDefault(m => m.IdNumber == mobs) } : new List<Mob>();
                    List<Treasure> treasure = data[10] != "0" ? new List<Treasure> { World.treasures.FirstOrDefault(t => t.IdNumber == treasures) } : new List<Treasure>();
                    List<Item> item = data[11] != "0" ? new List<Item> { World.items.FirstOrDefault(i => i.IdNumber == items) } : new List<Item>();


                    Room room = new Room(id, name, description, Exits, potion, weapon, mob, treasure, item);
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
                    int items = data[8] != "" ? items = int.Parse(data[8]) : items = 0;
                    int potions = data[9] != "" ? potions = int.Parse(data[9]) : potions = 0;
                    int weapons = data[10] != "" ? weapons = int.Parse(data[10]) : weapons = 0;
                    int treasures = data [11] != "" ? treasures = int.Parse(data[11]) : treasures = 0;
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
