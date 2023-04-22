using System;
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

                        Exploration.Movement(action);
                        break;

                    case "inventory":
                    case "inv":

                        Console.WriteLine("\nIn your inventory you currently have:");
                        for (int i = 0; i < World.items.Length; i++)
                        {
                            Console.WriteLine($"{World.items[i]}. {World.itemDescs[i]}");
                        }
                        break;

                    case "weapons":
                        Console.WriteLine("\nIn your inventory you currently have:");
                        for (int i = 0; i < World.weapons.Length; i++)
                        {
                            Console.WriteLine($"{World.weapons[i]}. {World.weaponDescs[i]} It deals {World.weaponDmg[i]} damage.");
                        }
                        break;

                    case "potions":
                    case "pots":
                        Console.WriteLine("\nIn your inventory you currently have:");
                        for (int i = 0; i < World.potions.Length; i++)
                        {
                            Console.WriteLine($"{World.potions[i]}. {World.potionDescs[i]}");
                        }
                        break;

                    case "treasure":
                        Console.WriteLine("You have the following treasures:");
                        for (int i = 0; i < World.treasures.Length; i++)
                        {
                            Console.WriteLine($"{World.treasures[i]}. {World.treasureDescs[i]}");
                        }
                        break;

                    case "mobs":

                        Console.WriteLine("\nThere are various mobs around, such as:");
                        for (int i = 0; i < World.mobs.Length; i++)
                        {
                            Console.WriteLine($"{World.mobs[i]}. {World.mobDescs[i]}");
                        }
                        break;

                    default:

                        Console.WriteLine("\nYour body refuses to follow that action through.");
                        break;
                }

                Console.WriteLine($"\nYou are currently in the {World.rooms[World.RoomTracker]}.");
                Console.WriteLine("Please enter a command. Possible options: north, south, inventory, weapons, potions, mobs, treasure.\nType exit to leave the realm.\n");

                action = Console.ReadLine().ToLower();

            } while (action != "exit");
        }

        public static void ExitState()
        {
            Console.WriteLine("\nA portal opens beneath you, dropping you into a vast expanse. Enjoy the fall!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
