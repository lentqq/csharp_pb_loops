using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_EEven_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += inputNumber;
                }
                else
                {
                    oddSum += inputNumber;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes Sum = " + evenSum);
            }
            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No Diff = " + diff);
            }

        }
    }
}
