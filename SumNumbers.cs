﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sum += inputNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
