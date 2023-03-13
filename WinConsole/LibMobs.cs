using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinConsole
{
    class LibMobs
    {
        public static void MobsList()
        {
            //init
            string mob1, mob2, mob3, mob4, mob5;

            StreamReader inputFile;

            inputFile = File.OpenText("Mobs.txt");

            //define
            mob1 = inputFile.ReadLine();
            mob2 = inputFile.ReadLine();
            mob3 = inputFile.ReadLine();
            mob4 = inputFile.ReadLine();
            mob5 = inputFile.ReadLine();

            Console.WriteLine("\nThe creatures I have crafted thus far are " + mob1 + ", " + mob2 + ", " + mob3 + ", a " + mob4 + " and a " + mob5 + ".\nI'll leave those last two open to interpretation, Traveler.\n");
        }
    }
}
