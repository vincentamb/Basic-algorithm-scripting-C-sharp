﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine("Enter string:");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("String is Palindrome\nEntered String Was: {0}\nReverse string is: {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome\nEntered String Was: {0}\nReverse string is: {1}", s, revs);
            }
            Console.ReadLine();
        }
    }
}
