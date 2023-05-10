﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class StandardMessages
    {
        //NormalState is basic travel.
        public static void CheckAction() //TODO - REDO NORMSTATE to be up to date with requirements. such as players CURRENT inventory.
        {
            string action;
            action = Console.ReadLine().ToLower();
            do
            {
                switch (action)
                {
                    case "north":
                    case "n":
                    case "south":
                    case "s":
                    case "east":
                    case "e":
                    case "west":
                    case "w":
                        Exploration.Movement(action);
                        break;

                    case "inventory":
                    case "inv":

                        Console.WriteLine("\nWhat would you like to look for?\nPlease enter potions, items, weapons or treasures.\n");
                        action = Console.ReadLine().ToLower();

                        switch (action)
                        {
                            case "potions":
                            case "pots":
                                //TODO - run through inven potions.
                                break;
                            case "items":
                                //TODO - run through inven items.
                                break;
                            case "weapons":
                                //TODO - run through inven weapons.
                                break;
                            case "treasures":
                                //TODO - run through inven treasures.
                                break;
                            default: //simple default to inform user of incorrect input.
                                Console.WriteLine("\nYou can't seem to find anything by that name or concept.");
                                break;
                        }
                        break;
                    //    Console.WriteLine("\nIn your inventory you currently have:");
                    //    for (int i = 0; i < World.items.Count; i++)
                    //    {
                    //        Console.WriteLine($"{World.items[i]}. {World.items[i].Description}");
                    //    }
                    //    break;

                    //case "weapons":
                    //    Console.WriteLine("\nIn your inventory you currently have:");
                    //    for (int i = 0; i < World.weapons.Count; i++)
                    //    {
                    //        Console.WriteLine($"{World.weapons[i]}. {World.weapons[i].Description} It deals {World.weapons[i].Damage} damage.");
                    //    }
                    //    break;

                    //case "potions":
                    //case "pots":
                    //    Console.WriteLine("\nIn your inventory you currently have:");
                    //    for (int i = 0; i < World.potions.Count; i++)
                    //    {
                    //        Console.WriteLine($"{World.potions[i]}. {World.potions[i].Description}");
                    //    }
                    //    break;

                    //case "treasure":
                    //    Console.WriteLine("You have the following treasures:");
                    //    for (int i = 0; i < World.treasures.Count; i++)
                    //    {
                    //        Console.WriteLine($"{World.treasures[i]}. {World.treasures[i].Description}");
                    //    }
                    //    break;

                    //case "mobs":

                    //    Console.WriteLine("\nThere are various mobs around, such as:");
                    //    for (int i = 0; i < World.mobs.Count; i++)
                    //    {
                    //        Console.WriteLine($"{World.mobs[i]}. {World.mobs[i].Description}");
                    //    }
                    //    break;

                    default:

                        Console.WriteLine("\nYour body refuses to follow that action through.");
                        break;
                }

                //Console.WriteLine($"\nYou are currently in the {}."); //TODO - COME FIX THIS LATER
                Console.WriteLine("Please enter a command. Possible options: north, south, inventory, weapons, potions, mobs, treasure.\nType exit to leave the realm.\n");

                action = Console.ReadLine().ToLower();

            } while (action != "exit");
        }

        //ExitState is when the user explicitly exits the game.
        public static void ExitState()
        {
            Console.WriteLine("\nA portal opens beneath you, dropping you into a vast expanse. Enjoy the fall!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        //public static void DisplayCurrentRoom()
        //{
        //    int location = 
        //    Room currentRoom = World.rooms.FirstOrDefault()
        //}
        //TODO - FINISH CURRENT ROOM STUFF AFTER PLAYER IS DONE COMPLETELY.
    }
}
