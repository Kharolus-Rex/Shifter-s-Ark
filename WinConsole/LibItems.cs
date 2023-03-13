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

            StreamReader inputFile;

            inputFile = File.OpenText("Items.txt");

            //define
            item1 = inputFile.ReadLine();
            item2 = inputFile.ReadLine();
            item3 = inputFile.ReadLine();
            item4 = inputFile.ReadLine();

            inputFile.Close();

            Console.WriteLine("\nCurrent items needed for various reasons are a " + item1 + ", " + item2 + ", a " + item3 + " and an " + item4 + ".\n");

        }
    }
}
