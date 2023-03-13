/* *
 * 2/26/23
 * CSC 153
 * Connor Naylor
 * This will be the long time project for C# programming.
 * This project will last at least one year if not more.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic variables for sprint 1
            //rooms
            //string room1 = "Sewer Entrance";
            //string room2 = "Sewer Hall T";
            //string room3 = "Sewer Gang Base"; //actually a trap room
            //string room4 = "Gaol Cell"; //older spelling of jail to match setting
            //string room5 = "Gang Hallway";
            //string room6 = "Gang Office"; //the little goblin isn't a goblin

            //weapons
            //string weapon1 = "greatsword";
            //string weapon2 = "longsword";
            //string weapon3 = "rapier";
            //string weapon4 = "casting focus"; //TODO screw around with spell casting if I'm feeling spicy
            //string weapon5 = "dagger";

            //potions
            //string potion1 = "Minor Healing";
            //string potion2 = "Minor Invisibility";

            //treasures
            //string treasure1 = "longsword +1";
            //string treasure2 = "scroll of Magic Missile";
            //string treasure3 = "scroll of ???"; //blood curse, nasty effect that triggers a set time after death. turbo zombies, basically

            //items
            //string item1 = "cell key";
            //string item2 = "torch";
            //string item3 = "moldy bone"; //reference to my Growing Legend: Moldy Bone. Picked 3 high difficulty locks back-to-back with a moldy bone after getting gaoled by enemy. Expertise is borked.
            //string item4 = "archaic mark"; //tied to scroll of ???, as far as story goes

            //mobs
            //string mob1 = "goblin";
            //string mob2 = "orc";
            //string mob3 = "goliath";
            //string mob4 = "goblin?"; //little too well spoken for a goblin. and quite a bloody feast it has
            //string mob5 = "barghest"; //shapeshift go brr
        
            //generic menu for Sprint 1
            string response;

            Console.WriteLine("Welcome to the Aether, traveler. Want to see what new world I'm crafting?\nPlease, tell me what you'd like to see or know.\n");

            //time for the menu writeline

            Console.WriteLine("1) Rooms\n2) Weapons\n3) Potions\n4) Treasures\n5) Items\n6) Mobs\n7) Leave the Aether\n");
            
            Console.Write("Response => ");

            response = Console.ReadLine();

            while (response != "7")
            {
                switch (response)
                {
                    case "1":
                        Console.WriteLine("\nOk. The following rooms exist: \nFirst, we have the Sewer Entrance, Sewer Hall, and Sewer Common Room.");
                        Console.WriteLine("Next we have the Gaol Cell, a Gang Hallway, and a Gang Office.\n");
                        break;

                    case "2":
                        Console.WriteLine("\nCurrently I have crafted a greatsword, longsword, rapier and dagger.\nI also made a casting focus, for when I eventually craft a magic system for people.\n");
                        break;

                    case "3":
                        Console.WriteLine("\nPotions that currently exist are minor healing and invisibility.\n");
                        break;

                    case "4":
                        Console.WriteLine("\nCurrent treasures are scrolls of Magic Missile, a longsword +1, and a scroll whos effects I will leave a mystery!\n");
                        break;

                    case "5":
                        Console.WriteLine("\nCurrent items needed for various reasons are a cell key, torch, a moldy bone, and an archaic mark of some kind.\n");
                        break;

                    case "6":
                        Console.WriteLine("\nThe creatures I have crafted thus far are goblins, orcs, goliaths, something that looks like a goblin, and a fiery hound from not the mortal plane!\nI'll leave that last one open to interpretation, traveler.\n");
                        break;

                    case "7":
                        Console.WriteLine("\nGoodbye! Next time I should have much more for you to see, traveler!");
                        break;
                }
            }

            Console.ReadLine();


        }
    }
}
