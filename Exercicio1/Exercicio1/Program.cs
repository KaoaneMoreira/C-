using System;
using System.Globalization;

namespace Exercicio1{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Entre com seu nome completo: ");
            string fullname = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int room = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string lastname = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(fullname);
            Console.WriteLine(room);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastname);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
