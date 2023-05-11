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
        public static void GameplayLoop()
        {
            Room room = World.FindRoomByID(World.players[0].Location);
            string action;
            action = Console.ReadLine().ToLower();
            do
            {
                room = World.FindRoomByID(World.players[0].Location);
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
                        Exploration.Movement(action, room);
                        break;

                    case "inventory":
                    case "inv":
                        if (World.players[0].Potions != null && World.players[0].Potions.Count > 0)
                        {
                            foreach (Potion potion in World.players[0].Potions)
                            {
                                Console.WriteLine(potion.Name);
                            }
                        }
                        if (World.players[0].Items != null && World.players[0].Items.Count > 0)
                        {
                            foreach (Item item in World.players[0].Items)
                            {
                                Console.WriteLine(item.Name);
                            }
                        }
                        if (World.players[0].Weapons != null && World.players[0].Weapons.Count > 0)
                        {
                            foreach (Weapon weapon in World.players[0].Weapons)
                            {
                                Console.WriteLine(weapon.Name);
                            }
                        }
                        if (World.players[0].Treasures != null && World.players[0].Treasures.Count > 0)
                        {
                            foreach (Treasure treasure in World.players[0].Treasures)
                            {
                                Console.WriteLine(treasure.Name);
                            }
                        }
                        break;

                    case "attack":
                        SimpleCombat.CombatRevised(World.players[0], room.Mobs[0]); //calls current player and mob in current room with player.
                        break;

                    case "collect":
                        Exploration.CollectThings();
                        break;

                    case "heal":
                        SimpleCombat.OOCHealingPotion();
                        break;

                    case "look":
                        LookState();
                        break;

                    default:
                        Console.WriteLine("\nYour body refuses to follow that action through.");
                        break;
                }

                //Console.WriteLine($"\nYou are currently in the {}."); //TODO - COME FIX THIS LATER
                StandardMessages.NormalState(World.players[0]);

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

        public static void NormalState(Player player)
        {
            Room room = World.FindRoomByID(World.players[0].Location);
            Console.WriteLine($"\nYou are currently in {room.Name}");
            Console.WriteLine($"{room.Description}");
            Console.WriteLine($"Current HP: {player.HP}");
            Console.WriteLine("Please enter a command. Possible options: north, south, east, west, inventory, attack, collect, heal, look.\nType exit to leave the realm.\n");
        }

        public static void LookState()
        {

            Room room = World.FindRoomByID(World.players[0].Location);
            //display mobs
            Console.WriteLine(); //for spacing purposes

            if (room.Mobs != null && room.Mobs.Count > 0)
            {
                Console.WriteLine("Mobs:");
                foreach (Mob mob in room.Mobs)
                {
                    Console.WriteLine($" - {mob.Name}");
                }
            }

            //display items
            if (room.Items != null && room.Items.Count > 0)
            {
                Console.WriteLine("Items:");
                foreach (Item item in room.Items)
                {
                    Console.WriteLine($" - {item.Name}");
                }
            }

            //display weapons
            if (room.Weapons != null && room.Weapons.Count > 0)
            {
                Console.WriteLine("Weapons:");
                foreach (Weapon weapon in room.Weapons)
                {
                    Console.Write($" - {weapon.Name}");
                }
            }
        }
    }
}
