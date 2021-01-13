using System;
using System.Globalization;

namespace Exercicio2{
    class Program{
        static void Main(string[] args){
            double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double preco = area * precoMetroQuadrado;

            Console.WriteLine();
            Console.WriteLine( "AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
