﻿using System;
using System.IO;

namespace CreateNameFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("Names.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            string[] names = { "Anthony", "Belle", "Carolyn", "David", "Edwin", "Frannie", "Gina", "Hannah", "Inez", "Juan" };
            for (int x = 0; x < names.Length; ++x)
            {
                writer.WriteLine(names[x]);
            }
            writer.Close();
            file.Close();
        }
    }
}
