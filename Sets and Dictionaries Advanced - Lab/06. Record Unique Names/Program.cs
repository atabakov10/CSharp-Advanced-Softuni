﻿using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            int numberOfNames = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfNames; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
