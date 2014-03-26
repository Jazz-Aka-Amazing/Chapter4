using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRateLoop.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double n;
            String input;
            while (true)
            {
                Console.WriteLine(" Enter a pay rate");
                input = Console.ReadLine();
                n = Convert.ToDouble(input);

                sum = n + sum;
                if (n < 5.65 || n > 49.99)
                {
                    break;
                }
            }
        }
    }
}

