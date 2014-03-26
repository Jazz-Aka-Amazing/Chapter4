using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquares.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum = i * 2;
                Console.WriteLine("{0}. {1}", i, sum);

            }
        }
    }
}
