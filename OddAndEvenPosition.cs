using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_and_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;
            double oddMin = double.MaxValue;
            double evenMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double inputNum = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += inputNum;
                    if (inputNum < evenMin)
                    {
                        evenMin = inputNum;
                    }
                    if (inputNum > evenMax)
                    {
                        evenMax = inputNum;
                    }
                }
                else
                {
                    oddSum += inputNum;
                    if (inputNum < oddMin)
                    {
                        oddMin = inputNum;
                    }
                    if (inputNum > oddMax)
                    {
                        oddMax = inputNum;
                    }
                }
            }
            Console.WriteLine("OddSum=" + oddSum);

            if (oddMin > 1000000000.0 || oddMin < -1000000000.0)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin=" + oddMin);
            }


            if (oddMax > 1000000000.0 || oddMax < -1000000000.0)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax=" + oddMax);
            }


            Console.WriteLine("EvenSum=" + evenSum);

            if (evenMin > 1000000000.0 || evenMin < -1000000000.0)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin=" + evenMin);
            }

            if (evenMax > 1000000000.0 || evenMax < -1000000000.0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax=" + evenMax);
            }
        }
    }
}
