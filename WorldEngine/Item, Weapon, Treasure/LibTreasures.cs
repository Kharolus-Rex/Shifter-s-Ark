using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinConsole
{
    class LibTreasures
    {
        public static void TreasuresList()
        {
            //variables
            string treasure1, treasure2, treasure3;
            string treasure1Desc, treasure2Desc, treasure3Desc;

            StreamReader inputFile;

            inputFile = File.OpenText("Treasures.txt");

            //define treasures
            treasure1 = inputFile.ReadLine();
            treasure1Desc = inputFile.ReadLine();
            treasure2 = inputFile.ReadLine();
            treasure2Desc = inputFile.ReadLine();
            treasure3 = inputFile.ReadLine();
            treasure3Desc = inputFile.ReadLine();

            inputFile.Close();

            //writeline statement
            Console.WriteLine("\nThe current treasure I have crafted are:\n" + treasure1 + ": " + treasure1Desc + "\n" + treasure2 + ": " + treasure2Desc + "\n" + treasure3 + ": " + treasure3Desc + "\n");
        }
    }
}
