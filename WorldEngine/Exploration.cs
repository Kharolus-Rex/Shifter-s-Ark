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
            Console.WriteLine("Please enter a command. Possible options: north, south, east, west, inventory, weapons, potions, mobs, treasure.\nType exit to leave the realm.\n");
        }

        //Contains the switch statement to decide if the user is able to move or not.
        //TODO - Add east and west options. Also remember that the Room class is gonna be a biiiiiitch to do.
        public static void Movement(string Direction)
        {
            //if (currentRoom.Direction(direction) == -1)
            //{
            //    Console.WriteLine("\nA wall is in that direction. You can't break that wall!");
            //    return;  TODO - THIS WILL BE IMPLIMENTED LATER
            //}
            switch (Direction)
            {
                case "north":
                case "n":
                    //TODO - and IF statement to all of these to check for a -1 nextRoom/direction value to display default message.
                    //TODO - come back and input this stuff after Player class is finished. Fk.
                case "south":
                case "s":
                    //TODO - come back and input this stuff after Player class is finished.
                    //will be something like:
                    /* player.location = room.south;
                     * currentLocation/roomTracker = player.location;
                     * display standard entry message when entering the room
                     */
                case "east":
                case "e":
                    //TODO - come back after Player is finished and works with rooms.
                    break;
                case "west":
                case "w":
                    //TODO - same as above.
                    break;
                default:
                    Console.WriteLine("A wall of force blocks your movement in that direction. Where else could you go?");
                    break;
            }
            return;
        }

    }
}
