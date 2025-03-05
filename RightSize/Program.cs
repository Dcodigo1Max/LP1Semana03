using System;
using System.ComponentModel.DataAnnotations;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            string word = Console.ReadLine();

            foreach (string w in word)
            {
                
                if (w.Length in words>3)
                {
                 Console.WriteLine(word);
                }
                
                else
                {
                    break;
                }
                
                
            } 




        }
    }
}
