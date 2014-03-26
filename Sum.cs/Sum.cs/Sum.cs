using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum.cs
{
    class Sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n;
            String input;

            while (true)
            {
                Console.WriteLine("Enter a Number:");
                input = Console.ReadLine();
                n = Convert.ToInt32(input);

                if (input == "999")
                {
                    break;
                }

                sum = n + sum;
            }
            Console.WriteLine(sum);
        }
    }
}
