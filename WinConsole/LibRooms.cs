using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinConsole
{
    class LibRooms
    {
        public static void RoomsList()
        {
            // TODO Add streamreader and read text files to room variables

            //room variables
            string room1, room2, room3, room4, room5, room6;

            StreamReader inputFile;

            inputFile = File.OpenText("Rooms.txt");

            //define rooms
            room1 = inputFile.ReadLine();
            room2 = inputFile.ReadLine();
            room3 = inputFile.ReadLine();
            room4 = inputFile.ReadLine();
            room5 = inputFile.ReadLine();
            room6 = inputFile.ReadLine();

            //Console.WriteLine("\nOk. The following rooms exist: \nFirst, we have the Sewer Entrance, Sewer Hall, and Sewer Common Room.");
            //Console.WriteLine("Next we have the Gaol Cell, a Gang Hallway, and a Gang Office.\n");

            //close file
            inputFile.Close();

            //output lines
            Console.WriteLine("\nOk. I have crafted the following rooms for this project of mine.");
            Console.WriteLine("I have crafted a " + room1 + ", " + room2 + ", " + room3 + ", " + room4 + ", " + room5 + "and a " + room6 + ".\n");

        }
    }
}
