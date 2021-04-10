using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i<n; i++) {
                string[] line = Console.ReadLine().Split(',');
                string name = line[0];
                double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService cs = new CalculationService();

            Product max = cs.Max(list);

            Console.WriteLine("MAX: ");
            Console.WriteLine(max);
        }
    }
}
