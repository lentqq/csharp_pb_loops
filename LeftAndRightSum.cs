using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                leftSum += inputNumber;
            }

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                rightSum += inputNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", rightSum);
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}
