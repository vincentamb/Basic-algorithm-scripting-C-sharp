using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num, fact;
            Console.WriteLine("Enter the Number:");
            num = int.Parse(Console.ReadLine());
            fact = num;
            for (i = num - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of Given Number is: " + fact);
            Console.ReadLine();
        }
    }
}
