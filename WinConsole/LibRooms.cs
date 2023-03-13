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

            while (!inputFile.EndOfStream)
            {
                //define rooms
                // TODO Expand list as more rooms are added
                room1 = inputFile.ReadLine();
                room2 = inputFile.ReadLine();
                room3 = inputFile.ReadLine();
                room4 = inputFile.ReadLine();
                room5 = inputFile.ReadLine();
                room6 = inputFile.ReadLine();
            }

            //close file
            inputFile.Close();

            Console.WriteLine("\nOk. The following rooms exist: \nFirst, we have the " + room1 + ", " + room2 + ", and " + room3 + ".");
            Console.WriteLine("Next we have the " + room4 + ", " + room5 + ",and " + room6 + ".\n");
        }
    }
}
