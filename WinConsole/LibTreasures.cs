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

            StreamReader inputFile;

            inputFile = File.OpenText("Treasures.txt");

            //define treasures
            treasure1 = inputFile.ReadLine();
            treasure2 = inputFile.ReadLine();
            treasure3 = inputFile.ReadLine();

            inputFile.Close();

            //writeline statement
            Console.WriteLine("\nThe current treasure I have crafted are " + treasure1 + ", " + treasure2 + " and " + treasure3 + ", the effects of which shall remain a mystery!\n");
        }
    }
}
