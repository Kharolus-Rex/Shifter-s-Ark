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

            StreamReader inputFile;

            inputFile = File.OpenText("Potions.txt");

            //define
            potion1 = inputFile.ReadLine();
            potion2 = inputFile.ReadLine();

            inputFile.Close();

            Console.WriteLine("\nPotions that currently exist are " + potion1 + " and " + potion2 + ".\n");

        }
    }
}
