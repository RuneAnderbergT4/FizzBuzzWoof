﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWoof
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzWoof = new FizzBuzzWoof();

            List<double> times = new List<double>();

            for (int t = 0; t < 1000; t++)
            {
                var start = DateTime.Now;

                for (int i = 0; i <= 100000; i++)
                {
                    fizzBuzzWoof.Convert(i);
                }

                times.Add((DateTime.Now - start).TotalMilliseconds);
            }

            Console.WriteLine(times.Min());
            Console.WriteLine(times.Max());
            Console.WriteLine(times.Average());

            Console.ReadKey();
        }
    }
}
