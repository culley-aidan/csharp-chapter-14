using System;
using System.IO;
using System.Text.RegularExpressions;

namespace FindCustomerRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("..\\..\\..\\..\\..\\WriteCustomerRecords\\WriteCustomerRecords\\Customers.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            Console.Write("Enter ID: ");
            string id = Console.ReadLine(), currentLine = reader.ReadLine();
            
            while (!string.IsNullOrEmpty(currentLine))
            {
                if (Regex.IsMatch(currentLine, id))
                {
                    Console.WriteLine($"Found customer {currentLine}");
                    break;
                }
                currentLine = reader.ReadLine();
            }
            file.Close();
            reader.Close();
        }
    }
}
