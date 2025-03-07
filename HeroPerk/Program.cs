using System;
using System.Security;

namespace HeroPerk
{
    public class Program
    {

           [Flags]
           enum Perks
           {
              WarpShift =1 << 0,
              Stealth =1 << 1,
              AutoHeal =1 << 2,
              DoubleJump=1 << 3,

           }
        private static void Main(string[] args)
        {

          Perks myperks = 0;
          string part = "";

            for (int u =0; u <args.Length; u ++)
          {
            
            part += args[u];
          }


          //Perks myperks = Perks.WarpShift | Perks.Stealth | Perks.AutoHeal | Perks.DoubleJump;

         



          foreach(Char argumento in part)
          {
             if (argumento.Equals('w') == true)
                {
                  myperks ^= Perks.WarpShift;
                }
                 else if (argumento.Equals('s') == true)
                {
                    myperks ^= Perks.Stealth;
                }
                else if (argumento.Equals('a') == true)
                {
                    myperks ^= Perks.AutoHeal;
                }
                else if (argumento.Equals('d') == true)
                {
                    myperks ^= Perks.DoubleJump;
                }
                else
                {
                    Console.WriteLine("!Unknown perk!");
                    return;
                }
            }
              if(myperks.HasFlag(Perks.AutoHeal) | myperks.HasFlag(Perks.Stealth) | myperks.HasFlag(Perks.DoubleJump) |
                myperks.HasFlag(Perks.WarpShift))
                {
                    Console.WriteLine(myperks);
                }
            else
            {
                Console.WriteLine("!No perks at all!");
            }
            if (myperks.HasFlag(Perks.Stealth) & myperks.HasFlag(
            Perks.DoubleJump))
            {
                Console.WriteLine("!Silent jumper!");
            }
            if ((myperks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("!Not gonna make it!");
            }           
        }
    }
}
