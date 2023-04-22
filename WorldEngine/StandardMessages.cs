﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class StandardMessages
    {
        public static void NormalState()
        {
            //Console.WriteLine("You are currently in the " + World.rooms[World.RoomTracker] + ".");
            //Console.WriteLine("Please enter a command. Possible options: north, south, inventory, rooms, mobs, treasure\n");
            string action;
            action = Console.ReadLine().ToLower();
            do
            {
                Console.WriteLine("You are currently in the " + World.rooms[World.RoomTracker] + ".");
                Console.WriteLine("Please enter a command. Possible options: north, south, inventory, rooms, mobs, treasure\n");

                switch (action)
                {
                    case "north":
                    case "n":
                    case "south":
                    case "s":
                        Exploration.Movement(action);
                        break;

                    case "inventory":
                    case "inv":
                        Console.WriteLine("In your inventory you currently have:");
                        for (int i = 0; i < World.items.Length; i++)
                        {
                            Console.WriteLine($"{World.items[i]}. {World.itemDescs[i]}");
                        }
                        for (int i = 0; i < World.weapons.Length; i++)
                        {
                            Console.WriteLine($"{World.weapons[i]}. {World.weaponDescs[i]} It deals {World.weaponDmg[i]}");
                        }
                        for (int i = 0; i < World.potions.Length; i++)
                        {
                            Console.WriteLine($"{World.potions[i]}. {World.potionDescs[i]}");
                        }
                        for (int i = 0; i < World.treasures.Length; i++)
                        {
                            Console.WriteLine($"{World.treasures[i]}. {World.treasureDescs[i]}");
                        }
                        break;
                }

                action = Console.ReadLine().ToLower();

            } while (action != "exit");
        }
    }
}
