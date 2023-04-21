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
            string weapon1Desc, weapon2Desc, weapon3Desc, weapon4Desc, weapon5Desc;
            string weapon1DMG, weapon2DMG, weapon3DMG, weapon4DMG, weapon5DMG;

            StreamReader inputFile;

            inputFile = File.OpenText("Weapons.txt");

            //define
            weapon1 = inputFile.ReadLine();
            weapon1Desc = inputFile.ReadLine();
            weapon1DMG = inputFile.ReadLine();
            weapon2 = inputFile.ReadLine();
            weapon2Desc = inputFile.ReadLine();
            weapon2DMG = inputFile.ReadLine();
            weapon3 = inputFile.ReadLine();
            weapon3Desc = inputFile.ReadLine();
            weapon3DMG = inputFile.ReadLine();
            weapon4 = inputFile.ReadLine();
            weapon4Desc = inputFile.ReadLine();
            weapon4DMG = inputFile.ReadLine();
            weapon5 = inputFile.ReadLine();
            weapon5Desc = inputFile.ReadLine();
            weapon5DMG = inputFile.ReadLine();

            inputFile.Close();

            Console.WriteLine("\nCurrent weapons available are:\n" + weapon1 + ": " + weapon1Desc + "\n" + weapon2 + ": " + weapon2Desc + "\n" + weapon3 + ": " + weapon3Desc + "\n" + weapon4 + ": " + weapon4Desc + "\n" + weapon5 + ": " + weapon5Desc + "\n");
        }
    }
}
