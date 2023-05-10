using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEngine
{
    public class SimpleCombat
    {

        private static Random random = new Random();
        //This is still only to prove that the combat system works.
        //TODO - After Classes are made and lists initialized, come back and refit this to function with the new Classes and tokenization of damage.
        //public static void CombatTest()
        //{
        //    //init rand
        //    Random rand = new Random();

        //    //init HP vars
        //    int playerHP = 100;
        //    int mobHP = 100;

        //    //weapon dice vars
        //    string playerRoll = "1d8";
        //    string mobRoll = "1d4";

        //    //init dmg string tokens
        //    String[] playerRange = playerRoll.Split('d');
        //    String[] mobRange = mobRoll.Split('d');
        //    int playerDMG;
        //    int mobDMG;

        //    Console.WriteLine("Welcome to the combat test! Rigged? Yes. Do I care? Not in the slightest!\nLet's begin.\n");

        //    int roundTrack = 0;

        //    while (playerHP > 0 || mobHP > 0)
        //    {
        //        //roundTracker
        //        ++roundTrack;

        //        if (roundTrack == 1)
        //        {
        //            Console.WriteLine("Combat begins!\n");
        //        }

        //        Console.WriteLine("Player attacks!");
        //        playerDMG = rand.Next(int.Parse(playerRange[0]), int.Parse(playerRange[1]) + 1);
        //        mobHP -= playerDMG;
        //        Console.WriteLine("You hit the enemy for " + playerDMG + " damage!");

        //        Console.WriteLine("Enemy attacks!");
        //        mobDMG = rand.Next(int.Parse(mobRange[0]), int.Parse(mobRange[1]) + 1);
        //        playerHP -= mobDMG;
        //        Console.WriteLine("The enemy hit you for " + mobDMG + " damage!");

        //        if (playerHP == 0)
        //        {
        //            Console.WriteLine("Oops! You died! It's fine, most of the damage was psychic anyways, no physical harm.");

        //            break;
        //        }
        //        else if (mobHP == 0)
        //        {
        //            Console.WriteLine("About time! It's dead. Not that it was real or truly alive. I think? Eh, semantics at this point. Good job!");
        //            Console.WriteLine("You cleared combat in " + roundTrack + " rounds!");
        //            break;
        //        }
        //    }

        //}

        public static void CombatRevised(Player player, Mob mob)
        {
            while (true)
            {
                //player turn
                int playerDamage = CalculateDamage(player.Weapons[0]);
                mob.HP -= playerDamage;
                Console.WriteLine($"{player.Name} dealt {playerDamage} {player.Weapons[0].DamageType} damage to {mob.Name}");
                if (mob.HP <= 0)
                {
                    Console.WriteLine($"{mob.Name} is slain!");
                    World.rooms[World.players[0].Location].Mobs.RemoveAt(0);
                    //removes mob from room permanently. or until next game load rn. may change later.
                    return;
                }

                //mob turn
                int mobDamage = CalculateDamage(mob.MobWeapon);
                player.HP -= mobDamage;
                Console.Write($"{mob.Name} deals {mobDamage} {mob.MobWeapon.DamageType} damage to {player.Name}");
                if (player.HP <= 0)
                {
                    Console.WriteLine($"{player.Name} is slain! Game over!");
                    StandardMessages.ExitState();
                    //force closes game when slain for now. Implement checkpoints later in game creation.
                }
            }
        }

        public static int CalculateDamage(Weapon weapon)
        {
            string[] damageTokens = weapon.Damage.Split('d');
            int numberOfDice = int.Parse(damageTokens[0]);
            int diceSize = int.Parse(damageTokens[1]);

            int totalDamage = 0;
            for (int i = 0; i < numberOfDice; i++)
            {
                totalDamage += random.Next(1, diceSize + 1);
            }

            return totalDamage;
        }

        public static void OOCHealingPotion()
        {
            const int HealingID = 01;

            var healingPotion = World.players[0].Potions.FirstOrDefault(potion => potion.IdNumber == HealingID);
            if (healingPotion == null)
            {
                Console.WriteLine("You don't have any healing potions. Go find some!");
                return;
            }

            World.players[0].HP += healingPotion.ValChange;
            Console.WriteLine($"You used a healing potion. You now have {World.players[0].HP} HP.");

            World.players[0].Potions.Remove(healingPotion);
        }
    }
}
