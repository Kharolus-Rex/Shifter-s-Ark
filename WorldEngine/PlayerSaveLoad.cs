using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorldEngine
{
    public class PlayerSaveLoad
    {
        public static Player LoadPlayerData(string playerName)
        {
            string filePath = "./CSVFiles/players.csv";
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] data = line.Split(',');

                        if (data[1] == playerName)
                        {
                            int idNumber = int.Parse(data[0]);
                            string name = data[1];
                            string password = data[2];
                            string race = data[3];
                            string playerClass = data[4];
                            int hp = int.Parse(data[5]);
                            int ac = int.Parse(data[6]);
                            int location = int.Parse(data[7]);
                            int items = int.Parse(data[8]);
                            int potions = int.Parse(data[9]);
                            int weapons = int.Parse(data[10]);
                            int treasures = int.Parse(data[11]);
                            string quests = data[12];

                            List<Item> item = new List<Item> { World.items.FirstOrDefault(i => i.IdNumber == items) };
                            List<Potion> potion = new List<Potion> { World.potions.FirstOrDefault(p => p.IdNumber == potions) };
                            List<Weapon> weapon = new List<Weapon> { World.weapons.FirstOrDefault(w => w.IdNumber == weapons) };
                            List<Treasure> treasure = new List<Treasure> { World.treasures.FirstOrDefault(t => t.IdNumber == treasures) };
                            List<string> quest = new List<string>();

                            return new Player(idNumber, name, password, race, playerClass, hp, ac, location, item, potion, weapon, treasure, quest);
                        }
                    }
                }
            }
            return null;

        }
        public static void SavePlayerData(Player player)
        {
            string filePath = "./CSVFiles/players.csv";
            bool playerExists = false;

            List<string> lines = new List<string>();
            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] data = lines[i].Split(',');

                    if (data[1] == player.Name)
                    {
                        //lines[i] = $"{player stuff}";
                        playerExists = true;
                        break;
                    }
                }
            }

            if (!playerExists)
            {
                string newLine = $"{player.IdNumber}, {player.Name}, {player.Password}, {player.Race}, {player.PlayerClass}, {player.HP}, {player.AC}, {player.Location}, {player.Items}, {player.Potions}, {player.Weapons}, {player.Treasures}, {player.Quests}";
                lines.Add(newLine);
            }

            File.WriteAllLines(filePath, lines);
        }
        public static void PlayerCheck(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string playerName = Console.ReadLine();

            Player player = LoadPlayerData(playerName);
        }
    }
}
