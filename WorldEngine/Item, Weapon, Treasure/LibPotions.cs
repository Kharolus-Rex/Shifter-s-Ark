using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinConsole
{
    class LibPotions
    {
        public static void PotionsList()
        {
            //init potions
            string potion1, potion2;
            string potion1Desc, potion2Desc;

            StreamReader inputFile;

            inputFile = File.OpenText("Potions.txt");

            //define
            potion1 = inputFile.ReadLine();
            potion1Desc = inputFile.ReadLine();
            potion2 = inputFile.ReadLine();
            potion2Desc = inputFile.ReadLine();

            inputFile.Close();

            Console.WriteLine("\nPotions that currently exist are:\n" + potion1 + ": " + potion1Desc + "\n" + potion2 + ": " + potion2Desc+ ".\n");

        }
    }
}
