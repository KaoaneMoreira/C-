using System;
using System.Globalization;

namespace exercicio_estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            String[] vet = Console.ReadLine().Split(' ');
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());
            conta = 50.0;

            if (minutos > 100)
            {
                conta = conta + (minutos - 100) * 2.0;
            }

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
