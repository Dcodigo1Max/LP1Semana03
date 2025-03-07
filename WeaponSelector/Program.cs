using System;

namespace WeaponSelector
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            EnemyType enemy = Enum.Parse<EnemyType>(args[0]);
            Weapons weapon = ParseWeapons(args);
            bool dies = WeaponsKillEnemy(enemy, weapon);
            DisplayResult(enemy, dies);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the weapon.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The weapons.</returns>
        private static Weapons ParseWeapons(string[] args)
        {
            
            Weapons weapon = Weapons.None | Weapons.Garlic | Weapons.SilverBullet | Weapons.HolyWater;

            



        }

        /// <summary>
        /// Is the enemy killed with any of the weapons?
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="weapons">The weapons used to try and kill the enemy.</param>
        /// <returns>Wether the enemy was killed or not.</returns>
        private static bool WeaponsKillEnemy(EnemyType enemy, Weapons weapons)
        {
            
            if (enemy.HasFlag(EnemyType.Ghost) && weapons.HasFlag(Weapons.HolyWater))
            {
                Console.WriteLine("Ghost dies");
            }
            else
                {
                    Console.WriteLine("Ghost survives");
                }   


            if (enemy.HasFlag(EnemyType.Zombie) && weapons.HasFlag(Weapons.Garlic))
            {
                    Console.WriteLine("Zombie dies");
            }else if(enemy.HasFlag(EnemyType.Zombie) && weapons.HasFlag(Weapons.Garlic))
             {
                Console.WriteLine("Zombie dies");
             }


            if (enemy.HasFlag(EnemyType.Werewolf) && weapons.HasFlag(Weapons.SilverBullet))
            {

            }


            if (enemy.HasFlag(EnemyType.Vampire) && weapons.HasFlag(Weapons.SilverBullet))
            {

            }





        }

        /// <summary>
        /// Display information on wether the enemy was killed or not.
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        private static void DisplayResult(EnemyType enemy, bool survives)
        {

            if ()


            Console.WriteLine("");




        }
    }
}
