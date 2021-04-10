using System;
using System.Globalization;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            double[] vet;
            vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet[N] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
