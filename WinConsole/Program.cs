/* *
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
            //Load stuff that falls under bare essentials
            WorldLoad.LoadItems();
            WorldLoad.LoadPotions();
            WorldLoad.LoadTreasures();
            WorldLoad.LoadWeapons();
            WorldLoad.LoadMobs();
            WorldLoad.LoadRooms();
            WorldLoad.LoadPlayer();

            //initialize simple exploration and standard/idle view
            //PlayerSaveLoad.PlayerCheck(); Will impliment later. Player will be hard coded for now.
            StandardMessages.NormalState(World.players[0]);
            StandardMessages.GameplayLoop();
            StandardMessages.ExitState();
        }
    }
}
