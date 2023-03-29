using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsole
{
    class SimpleCombat
    {
        public static void simpleCombat()
        {
            //init rand
            Random rand = new Random();

            //init HP vars
            int playerHP = 100;
            int mobHP = 100;

            //weapon dice vars
            string playerRoll = "1d8";
            string mobRoll = "1d4";

            //init dmg string tokens
            String[] playerRange = playerRoll.Split('d');
            String[] mobRange = mobRoll.Split('d');
            int playerDMG;
            int mobDMG;

            Console.WriteLine("Welcome to the combat test! Rigged? Yes. Do I care? Not in the slightest!\nLet's begin.\n");

            int roundTrack = 0;

            while (playerHP > 0 || mobHP > 0)
            {
                //roundTracker
                ++roundTrack;

                if (roundTrack == 1)
                {
                    Console.WriteLine("Combat begins!\n");
                }

                Console.WriteLine("Player attacks!");
                playerDMG = rand.Next(int.Parse(playerRange[0]), int.Parse(playerRange[1]) + 1);
                mobHP -= playerDMG;
                Console.WriteLine("You hit the enemy for " + playerDMG + " damage!");

                Console.WriteLine("Enemy attacks!");
                mobDMG = rand.Next(int.Parse(mobRange[0]), int.Parse(mobRange[1]) + 1);
                playerHP -= mobDMG;
                Console.WriteLine("The enemy hit you for " + mobDMG + " damage!");

                if (playerHP == 0)
                {
                    Console.WriteLine("Oops! You died! It's fine, most of the damage was psychic anyways, no physical harm.");

                    break;
                }
                else if (mobHP == 0)
                {
                    Console.WriteLine("About time! It's dead. Not that it was real or truly alive. I think? Eh, semantics at this point. Good job!");
                    Console.WriteLine("You cleared combat in " + roundTrack + " rounds!");
                    break;
                }
            }

        }
    }
}
