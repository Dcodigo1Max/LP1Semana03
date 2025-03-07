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
              Stealh =1 << 1,
              AutoHeal =1 << 2,
              DoubleJump=1 << 3,

           }
        private static void Main(string[] args)
        {

          Perks myperks = Perks.WarpShift | Perks.Stealh | Perks.AutoHeal | Perks.DoubleJump;

          myperks ^=Perks.WarpShift;

          myperks ^=Perks.Stealh;
          
          myperks ^=Perks.AutoHeal;
          
          myperks ^=Perks.DoubleJump;

          
          
          string part = "";

          for (int u =0; u <args.Length; u ++)
          {
            
            part = args[u];
          }

          myperks =0;

          foreach(string u in myperks)
          {

          }

          Console.WriteLine(myperks);



          /*

          if ()
          {
            Console.WriteLine("!Not gonna make it!");
          }

          if ()
          {
              Console.WriteLine("!Silent jumper!");
          }
           */
           
           
           
           
           
           
        }
    }
}
