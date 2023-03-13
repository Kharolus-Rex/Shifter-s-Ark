using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinConsole
{
    class LibWeapons
    {
        public static void WeaponsList()
        {
            //init weapons
            string weapon1, weapon2, weapon3, weapon4, weapon5;

            StreamReader inputFile;

            inputFile = File.OpenText("Weapons.txt");

            //define
            weapon1 = inputFile.ReadLine();
            weapon2 = inputFile.ReadLine();
            weapon3 = inputFile.ReadLine();
            weapon4 = inputFile.ReadLine();
            weapon5 = inputFile.ReadLine();

            inputFile.Close();

            Console.WriteLine("\nCurrent weapons available are a " + weapon1 + ", " + weapon2 + ", " + weapon3 + ", " + weapon4 + " and a " + weapon5 + ".\n");
        }
    }
}
