using System;
using System.IO;

namespace TestFileAndDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a directory, type end to quit >> ");
            string directory = Console.ReadLine();
            while (directory.ToLower() != "end")
            {
                bool exists = Directory.Exists(directory);
                Console.WriteLine($"Directory exists? {exists.ToString()}");
                if (exists) {
                    foreach(string str in Directory.GetFiles(directory)) {
                        Console.WriteLine($"\t{str}");
                    }
                }
                Console.Write("Enter a directory, type end to quit >> ");
                directory = Console.ReadLine();
            }
        }
    }
}
