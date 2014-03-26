using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i<= 1000; i++)
            {
                sum=0;
                for(int n =1; n<i; n++)
                {
                    if(i%n == 0)
                    {
                        sum = n + sum;
                    }
                }
                if (sum == i)
                    Console.WriteLine(sum);
            }
        }
    }
}
 