using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Exploration
    {
        public static void ExploreStart()
        {
            Console.WriteLine($"You begin your journey in the {World.rooms[World.RoomTracker]}. {World.roomDescs[World.RoomTracker]}. What would you like to do?");
            Console.WriteLine("Please enter a command. Possible options: north, south, inventory, rooms, mobs, treasure\n");
        }
        public static void Movement(string Direction)
        {
            switch (Direction)
            {
                case "north":
                case "n":
                    World.RoomTracker++;
                    break;
                case "south":
                case "s":
                    if (World.RoomTracker == 0)
                    {
                        Console.WriteLine("There is only a solid wall of stone in your path. You cannot travel this way.");
                        break;
                    }
                    World.RoomTracker--;
                    break;
                default:
                    Console.WriteLine("A wall of force blocks your movement in that direction. Where else could you go?");
                    break;
            }
            return;
        }

    }
}
