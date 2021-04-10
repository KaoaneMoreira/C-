using System;
using System.Globalization;

namespace Estrutura__faca_enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;

            do
            {
                Console.WriteLine("Informe a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                F = 9.0 * C / 5.0 + 32;

                Console.WriteLine("Equivalente em Fahrenhiet: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n)?");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');

        }
    }
}
