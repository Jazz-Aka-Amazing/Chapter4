using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum50.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}