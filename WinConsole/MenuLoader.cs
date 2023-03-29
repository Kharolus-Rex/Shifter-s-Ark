using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsole
{
    class MenuLoader
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
                        LibRooms.RoomsList();
                        break;

                    case "2":
                        LibWeapons.WeaponsList();
                        break;

                    case "3":
                        LibPotions.PotionsList();
                        break;

                    case "4":
                        LibTreasures.TreasuresList();
                        break;

                    case "5":
                        LibItems.ItemList();
                        break;

                    case "6":
                        LibMobs.MobsList();
                        break;

                    case "7":
                        SimpleCombat.CombatTest();
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
