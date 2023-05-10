using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public static class World
    {

        //TODO - Convert all this into singular lists containing new Classes for each item. room list, weapon list, etc.

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

        //current room tracker, as this will likely be used in multiple places at once. it should be outside other methods and classes
        public static int RoomTracker = 0; //initialized as 0 as that is the starting index for this list.
    }
}
