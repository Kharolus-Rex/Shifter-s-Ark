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
                Console.WriteLine($"{mob.Name} deals {mobDamage} {mob.MobWeapon.DamageType} damage to {player.Name}");
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
                Console.WriteLine("\nYou don't have any healing potions. Go find some!");
                return;
            }

            World.players[0].HP += healingPotion.ValChange;
            Console.WriteLine($"\nYou used a healing potion. You now have {World.players[0].HP} HP.");

            World.players[0].Potions.Remove(healingPotion);
        }
    }
}
