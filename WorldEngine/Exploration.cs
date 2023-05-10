using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Exploration
    {
        //Initial spawn point for the player's journey.
        public static void ExploreStart()
        {
            Console.WriteLine($"You begin your journey in the {World.rooms[World.RoomTracker]}. {World.rooms[World.RoomTracker].Description}. What would you like to do?");
            Console.WriteLine("Please enter a command. Possible options: north, south, inventory, weapons, potions, mobs, treasure.\nType exit to leave the realm.\n");
        }

        //Contains the switch statement to decide if the user is able to move or not.
        //TODO - Add east and west options. Also remember that the Room class is gonna be a biiiiiitch to do.
        public static void Movement(string Direction)
        {
            switch (Direction)
            {
                case "north":
                case "n":
                    if (World.RoomTracker == 5)
                    {
                        Console.WriteLine("\nThere is only a solid wall of stone in your path. You cannot travel this way.");
                        break;
                    }
                    World.RoomTracker++;
                    break;
                case "south":
                case "s":
                    if (World.RoomTracker == 0)
                    {
                        Console.WriteLine("\nThere is only a solid wall of stone in your path. You cannot travel this way.");
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
