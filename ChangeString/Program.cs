using System;
using System.IO.Compression;
using System.Net.Sockets;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Escreva algo: ");
            string f = Console.ReadLine();

            Console.WriteLine("Escreva uma letra: ");
            string l = Console.ReadLine();
            Convert.ToChar(l);
            


            foreach (char c in  f)
            {
                if ( l == "") 
                {
                    Console.WriteLine("x");
                }
                Console.WriteLine(f);
                break;
            }

           
            

        }
    }
}
