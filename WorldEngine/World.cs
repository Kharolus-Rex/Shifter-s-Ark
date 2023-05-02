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
        public static string[] rooms = new string[6];
        public static string[] roomDescs = new string[6];

        //weapons lists
        public static string[] weapons = new string[5];
        public static string[] weaponDmg = new string[5];
        public static string[] weaponDescs = new string[5];
        //public static List<Weapon> weapons = new List<Weapon>();

        //treasures lists
        public static string[] treasures = new string[3];
        public static string[] treasureDescs = new string[3];

        //potions lists
        public static string[] potions = new string[2];
        public static string[] potionDescs = new string[2];

        //items lists
        public static string[] items = new string[4];
        public static string[] itemDescs = new string[4];

        //mobs lists
        public static string[] mobs = new string[5];
        public static string[] mobDescs = new string[5];

        //current room tracker, as this will likely be used in multiple places at once. it should be outside other methods and classes
        public static int RoomTracker = 0; //initialized as 0 as that is the starting index for this list.
    }
}
