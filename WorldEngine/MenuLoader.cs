using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEngine;

namespace WinConsole
{
    public class MenuLoader
    {
        public static void MenuLoadMain()
        {
            string response;

            Console.WriteLine("Welcome to the Aether, Traveler. Want to see what new world I'm crafting?\nPlease, tell me what you'd like to see or know.\n");

            Console.WriteLine("1) Rooms\n2) Weapons\n3) Potions\n4) Treasures\n5) Items\n6) Mobs\n7) Test combat\n8) Leave the Aether\n");

            Console.Write("Response => ");

            response = Console.ReadLine();

            while (response != "8")
            {
                switch (response)
                {
                    case "1":
                        //TODO - LIST ROOMS VIA WORLD CALL
                        foreach (string room in World.rooms)
                        {
                            Console.WriteLine(room);
                        }
                        break;

                    case "2":
                        //TODO - LIST WEAPONS VIA WORLD CALL
                        break;

                    case "3":
                        //TODO - LIST POTIONS VIA WORLD CALL
                        break;

                    case "4":
                        //TODO - LIST TREASURES VIA WORLD CALL
                        break;

                    case "5":
                        //TODO - LIST ITEMS VIA WORLD CALL
                        break;

                    case "6":
                        //TODO - LIST MOBS VIA WORLD CALL
                        break;

                    case "7":
                        SimpleCombat.CombatTest();
                        break;

                    //AFTER ALL OF THESE CASES RUN POST-CHANGES TO CALLS:
                    //TODO - ADD A CASE TO CHOOSE TO TEST COMBAT OR TO EXPLORE

                    default:
                        Console.WriteLine("The world didn't like that answer. Try again!");
                        break;
                }
                Console.WriteLine("Is there anything else you'd like to see, Traveler?\n");
                Console.Write("Response => ");

                response = Console.ReadLine();
            }

            if (response == "8")
            {
                Console.WriteLine("\nGoodbye! Next time I should have much more for you to see, Traveler!\n");
                Console.Write("Press the Enter key to exit.");
                Console.ReadLine();
            }

        }
    }
}
