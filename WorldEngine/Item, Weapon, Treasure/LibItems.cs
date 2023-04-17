using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinConsole
{
    class LibItems
    {
        public static void ItemList()
        {
            //init
            string item1, item2, item3, item4;
            string item1Desc, item2Desc, item3Desc, item4Desc;

            StreamReader inputFile;

            inputFile = File.OpenText("Items.txt");

            //define
            item1 = inputFile.ReadLine();
            item1Desc = inputFile.ReadLine();
            item2 = inputFile.ReadLine();
            item2Desc = inputFile.ReadLine();
            item3 = inputFile.ReadLine();
            item3Desc = inputFile.ReadLine();
            item4 = inputFile.ReadLine();
            item4Desc = inputFile.ReadLine();

            inputFile.Close();

            Console.WriteLine("\nCurrent items needed for various reasons are:\n" + item1 + ": " + item1Desc + "\n" + item2 + ": " + item2Desc + "\n" + item3 + ": " + item3Desc + "\n" + item4 + ": " + item4Desc + "\n");

        }
    }
}
