﻿/* *
 * 2/26/23
 * CSC 153
 * Connor Naylor
 * This will be the long time project for C# programming.
 * This project will last at least one year if not more.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldEngine;

namespace WinConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldLoad.LoadItems();
            WorldLoad.LoadPotions();
            WorldLoad.LoadTreasures();
            WorldLoad.LoadWeapons();
            WorldLoad.LoadRooms();

            MenuLoader.MenuLoadMain();

        }
    }
}
