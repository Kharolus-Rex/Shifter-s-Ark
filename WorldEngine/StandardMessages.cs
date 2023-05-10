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
                        SimpleCombat.CombatRevised(World.players[0], World.rooms[World.players[0].Location].Mobs[0]); //calls current player and mob in current room with player.
                        break;

                    case "collect":
                        Exploration.CollectThings();
                        break;

                    case "heal":
                        SimpleCombat.OOCHealingPotion();
                        break;

                    case "look":
                        Room room = World.FindRoomByID(World.players[0].Location);
                        LookState(room);
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
            //Console.WriteLine($"You are currently in {room.Name}"); come back for this
            Console.WriteLine($"You are currently in {room.Name}");
            Console.WriteLine($"{room.Description}");
            Console.WriteLine($"Current HP: {player.HP}");
            Console.WriteLine("Please enter a command. Possible options: north, south, east, west, inventory, attack, collect, heal, look.\nType exit to leave the realm.\n");
        }

        public static void LookState(Room room)
        { 
            //display mobs
            Console.WriteLine("Mobs:");
            if (room.Mobs != null)
            {
                foreach (Mob mob in room.Mobs)
                {
                    Console.WriteLine($" - {mob.Name}");
                }
            }

            //display items
            Console.WriteLine("Items:");
            foreach (Item item in room.Items)
            {
                Console.WriteLine($" - {item.Name}");
            }

            //display weapons
            Console.WriteLine("Weapons:");
            foreach (Weapon weapon in room.Weapons)
            {
                Console.Write($" - {weapon.Name}");
            }
        }
    }
}
