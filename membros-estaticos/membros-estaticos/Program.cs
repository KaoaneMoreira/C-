using System;
using System.Globalization;

namespace membros_estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar: ");
            double quantia = double.Parse(Console.ReadLine());

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Total em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
