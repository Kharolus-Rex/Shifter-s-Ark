using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Player
    {
        private int _idNumber;
        private string _name;
        private string _password; //include formatting during initial character creation
        private string _race;
        private string _class;
        private int _HP;
        private int _AC;
        private string _location; //TODO - room ID. cross reference using search algorithm
        private List<Item> _items;
        private List<Potion> _potions;
        private List<Weapon> _weapons;
        private List<Treasure> _treasures;
        private List<string> _quests;

        public Player(int idNumber, string name, string password, string race, string Class, int hp, int ac, string location, List<Item> items, List<Potion> potions, List<Weapon> weapons, List<Treasure> treasures, List<string> quests)
        {
            IdNumber = idNumber;

            Name = name;

            Password = password;

            Race = race;

            CLass = Class;

            HP = hp;

            AC = ac;

            Location = location;

            Items = items;

            Potions = potions;

            Weapons = weapons;

            Treasures = treasures;

            Quests = quests;
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string Race { get { return _race; } set { _race = value; } }
        public string CLass { get { return _class; } set { _class = value; } }
        public int HP { get { return _HP; } set { _HP = value; } }
        public int AC { get { return _AC; } set { _AC = value; } }
        public string Location { get { return _location; } set { _location = value; } }
        public List<Item> Items { get { return _items; } set { _items = value; } }
        public List<Potion> Potions { get { return _potions; } set { _potions = value; } }
        public List<Weapon> Weapons { get { return _weapons; } set { _weapons = value; } }
        public List<Treasure> Treasures { get { return _treasures; } set { _treasures = value; } }
        public List<string> Quests { get { return _quests; } set { _quests = value; } }
    }
}