using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sum += inputNumber;

                if (inputNumber > max)
                    max = inputNumber;
            }
            if (sum == 2 * max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                int diff = Math.Abs(2 * max - sum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diff);
            }
        }
    }
}
