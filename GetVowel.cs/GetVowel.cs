using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel.cs
{
    class GetVowel
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String input;
                Console.WriteLine("Enter a Vowel");
                input = Console.ReadLine().ToLower();
                if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
                {
                    Console.WriteLine("Enter another");
                }
                else if (input != "a" || input != "e" || input != "i" || input != "o" || input != "u")
                {
                    break;
                }
            }
        }
    }
}
