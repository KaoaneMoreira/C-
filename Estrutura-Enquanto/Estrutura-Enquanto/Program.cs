using System;
using System.Globalization;

namespace Estrutura_Enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont = 0;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0.0;

            while (idade >= 0)
            {
                soma = idade + soma;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = soma / cont;
            Console.WriteLine();
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
