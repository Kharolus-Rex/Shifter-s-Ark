using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinConsole
{
    public class LibMobs
    {
        public static void MobsList()
        {
            //init
            string mob1, mob2, mob3, mob4, mob5;
            string mob1Desc, mob2Desc, mob3Desc, mob4Desc, mob5Desc;

            StreamReader inputFile;

            inputFile = File.OpenText("Mobs.txt");

            //define
            mob1 = inputFile.ReadLine();
            mob1Desc = inputFile.ReadLine();
            mob2 = inputFile.ReadLine();
            mob2Desc = inputFile.ReadLine();
            mob3 = inputFile.ReadLine();
            mob3Desc = inputFile.ReadLine();
            mob4 = inputFile.ReadLine();
            mob4Desc = inputFile.ReadLine();
            mob5 = inputFile.ReadLine();
            mob5Desc = inputFile.ReadLine();

            Console.WriteLine("\nThe creatures I have crafted thus far are:\n" + mob1 + ": " + mob1Desc + "\n" + mob2 + " " + mob2Desc + "\n" + mob3 + ": " + mob3Desc + "\n" + mob4 + ": " + mob4Desc + "\n" + mob5 + ": " + mob5Desc + "\n");
        }
    }
}
