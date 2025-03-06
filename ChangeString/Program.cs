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
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            
            string f2 = f.Replace(c, 'x');


            Console.WriteLine($"= {f2}");



           

           
            

        }
    }
}
