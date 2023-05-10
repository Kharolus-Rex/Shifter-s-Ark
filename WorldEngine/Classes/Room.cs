using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Room
    {
        private int _idNumber;
        private string _name;
        private string _description;
        private int _north;
        private int _south;
        private int _east;
        private int _west;//TODO - Come back and redo this as directions, North, South, East, West. Different attributes. If no exit lies in that direction, set to -1.
        private List<Potion> _potions;
        private List<Weapon> _weapons;
        private List<Mob> _mobs;
        private List<Treasure> _treasures;
        private List<Item> _items;

        //TODO - DO LITERALLY EVERYTHING ELSE FIRST, THEN COME FINISH ROOMS.

        public Room(int idNumber, string name, string description, int north, int south, int east, int west, List<Potion> potions, List<Weapon> weapons, List<Mob> mobs, List<Treasure> treasures, List<Item> items)
        {
            IdNumber = idNumber;

            Name = name;

            Description = description;

            North = north;

            South = south;

            East = east;

            West = west;

            Potions = potions;

            Weapons = weapons;

            Mobs = mobs;
        }

        public int IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int North { get { return _north; } set { _north = value; } }
        public int South { get { return _south; } set { _south = value; } }
        public int East { get { return _east; } set { _east = value; } }
        public int West { get { return _west; } set { _west = value; } }
        public List<Potion> Potions { get { return _potions; } set { _potions = value; } }
        public List<Weapon> Weapons { get { return _weapons; } set { _weapons = value; } }
        public List<Mob> Mobs { get { return _mobs; } set { _mobs = value; } }
        public List<Treasure> Treasures { get { return _treasures; } set { _treasures = value; } }
        public List<Item> Items { get { return _items; } set { _items = value; } }
    }
}