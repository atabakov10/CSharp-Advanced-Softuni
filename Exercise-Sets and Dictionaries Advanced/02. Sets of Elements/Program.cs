﻿using System;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input.Split(' ')[0]);
            int m = int.Parse(input.Split(' ')[1]);

            var firstSet = new HashSet<int>();
            for (int i = 1; i <= n; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            var secondSet = new HashSet<int>();
            for (int i = 1; i <= m; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(String.Join(" ", firstSet));
        }
    }
}
