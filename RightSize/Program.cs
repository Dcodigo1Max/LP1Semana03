using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
           

            foreach (string w in args)
            {

                int t = w.Length;
                
                
                
                if (t>=8)
                {
                    Console.Write("[EARLY STOP]");
                    break;
                }

                if (t>3)
                {
                 Console.WriteLine(w);
                }
            
                
                
                
            } 




        }
    }
}
