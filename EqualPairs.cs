using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int pairsSum = 0;
            int maxDiff = 0;
            int diff = 0;
            int previousSum = 0;

            for (int i = 0; i < n; i++)
            {
                previousSum = pairsSum;

                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());


                pairsSum = num1 + num2;
                diff = Math.Abs(pairsSum - previousSum);
                if (diff > maxDiff && i >= 1)
                    maxDiff = diff;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value= " + pairsSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff= " + maxDiff);
            }
        }
    }
}
