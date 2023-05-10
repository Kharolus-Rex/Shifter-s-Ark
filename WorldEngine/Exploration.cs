using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class Exploration
    {
        //Contains the switch statement to decide if the user is able to move or not.
        public static void Movement(string Direction)
        {
            switch (Direction)
            {
                case "north":
                case "n":
                    if (World.rooms[World.players[0].Location].Exits[0] == -1)
                    {
                        Console.WriteLine("\nA wall is in that direction. You can't break that wall!");
                        break;
                    }
                    else
                    {
                        World.players[0].Location = World.rooms[World.players[0].Location].Exits[0]; //updates player location with next room, which is what the exit[0] is, the north exit.
                    }
                    break;
                case "south":
                case "s":
                    if (World.rooms[World.players[0].Location].Exits[1] == -1)
                    {
                        Console.WriteLine("\nA wall is in that direction. You can't break that wall!");
                        break;
                    }
                    else
                    {
                        World.players[0].Location = World.rooms[World.players[0].Location].Exits[1]; //updates player location with next room, which is what the exit[1] is, the south exit.
                    }
                    break;
                case "east":
                case "e":
                    if (World.rooms[World.players[0].Location].Exits[2] == -1)
                    {
                        Console.WriteLine("\nA wall is in that direction. You can't break that wall!");
                        break;
                    }
                    else
                    {
                        World.players[0].Location = World.rooms[World.players[0].Location].Exits[2]; //updates player location with next room, which is what the exit[2] is, the east exit.
                    }
                    break;
                case "west":
                case "w":
                    if (World.rooms[World.players[0].Location].Exits[3] == -1)
                    {
                        Console.WriteLine("\nA wall is in that direction. You can't break that wall!");
                        break;
                    }
                    else
                    {
                        World.players[0].Location = World.rooms[World.players[0].Location].Exits[3]; //updates player location with next room, which is what the exit[3] is, the west exit.
                    }
                    break;
                default:
                    Console.WriteLine("A wall of force blocks your movement in that direction. Where else could you go?");
                    break;
            }
            return;
        }

        public static void CollectThings()
        {
            for (int i = 0; i < )
        }

    }
}
