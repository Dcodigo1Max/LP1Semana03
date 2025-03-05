using System;
using System.ComponentModel.DataAnnotations;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            

            foreach (string w in args)
            {
                
                if (w.Length>3)
                {
                 Console.WriteLine(args);
                }
                
                if (w.Length>=8)
                {
                    Console.Write("[EARLY STOP]");
                    break;
                }

                else
                {
                    break;
                }
                
                
            } 




        }
    }
}
