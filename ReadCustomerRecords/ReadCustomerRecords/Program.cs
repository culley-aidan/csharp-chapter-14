using System;
using System.IO;

namespace ReadCustomerRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("..\\..\\..\\..\\..\\WriteCustomerRecords\\WriteCustomerRecords\\Customers.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            Console.Write("customer information: ");
            Console.Write(reader.ReadLine());
            file.Close();
            reader.Close();
        }
    }
}
