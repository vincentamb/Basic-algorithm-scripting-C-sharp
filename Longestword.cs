using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            var input = Console.ReadLine();
            string[] input1 = input.Split(' ');
            var longestWord = input1.OrderByDescending(n => n.Length).First();
            Console.WriteLine("Longest word is: " + longestWord);
            Console.ReadLine();
        }
    }
}
