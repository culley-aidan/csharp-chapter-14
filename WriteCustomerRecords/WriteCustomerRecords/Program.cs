using System;
using System.IO;

namespace WriteCustomerRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("..\\..\\..\\Customers.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            Console.Write("Enter ID number: ");
            int.TryParse(Console.ReadLine(), out int id);
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Amount Owed");
            double.TryParse(Console.ReadLine(), out double owed);
            Customer tmp = new Customer(id, name, owed);
            writer.WriteLine($"{tmp.IDNumber},{tmp.Name},{tmp.AmountOwed}");
            writer.Close();
            file.Close();
        }
        class Customer
        {
            public int IDNumber { get; set; }
            public string Name { get; set; }
            public double AmountOwed { get; set; }
            public Customer(int id, string name, double owed)
            {
                IDNumber = id;
                Name = name;
                AmountOwed = owed;
            }
        }
    }
}
