using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public static class World
    {
        //rooms lists
        public static List<Room> rooms = new List<Room>();

        //weapons lists
        public static List<Weapon> weapons = new List<Weapon>();

        //treasures lists
        public static List<Treasure> treasures = new List<Treasure>();

        //potions lists
        public static List<Potion> potions = new List<Potion>();

        //items lists
        public static List<Item> items = new List<Item>();

        //mobs lists
        public static List<Mob> mobs = new List<Mob>();
        //attribute weapon is stored as an int, the same int that will match a weaponID. cross reference with a search algorithm later.

        public static List<Player> players = new List<Player>();

        //CURRENT ROOM WILL BE DISPLAYED BY A METHOD.
    }
}
