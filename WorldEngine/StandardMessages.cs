using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class StandardMessages
    {
        //NormalState is basic travel.
        public static void CheckAction()
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
                        foreach (Potion potion in World.players[0].Potions)
                        {
                            Console.WriteLine(potion.Name);
                        }
                        foreach (Item item in World.players[0].Items)
                        {
                            Console.WriteLine(item.Name);
                        }
                        foreach (Weapon weapon in World.players[0].Weapons)
                        {
                            Console.WriteLine(weapon.Name);
                        }
                        foreach (Treasure treasure in World.players[0].Treasures)
                        {
                            Console.WriteLine(treasure.Name);
                        }
                        break;

                    case "attack":
                        SimpleCombat.CombatTest();
                        break;

                    case "collect":
                        Exploration.CollectThings();
                        //TODO - Take items currently in room and add to inventory.
                        break;

                    default:
                        Console.WriteLine("\nYour body refuses to follow that action through.");
                        break;
                }

                //Console.WriteLine($"\nYou are currently in the {}."); //TODO - COME FIX THIS LATER
                Console.WriteLine("Please enter a command. Possible options: north, south, east, west, inventory, attack, collect.\nType exit to leave the realm.\n");

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
    }
}
