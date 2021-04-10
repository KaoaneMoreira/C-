using System;
using System.Globalization;

namespace exe_complementares
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int M = int.Parse(line[0]);
            int N = int.Parse(line[1]);

            int[,] A = new int[M, N];
            int[,] B = new int[M, N];
            int[,] C = new int[M, N];

            for (int i=0; i<M; i++)
            {
                line = Console.ReadLine().Split(' ');
                for (int j=0; j<N; j++)
                {
                    A[i, j] = int.Parse(line[j]);
                }
            }

            for (int i=0; i<M; i++)
            {
                line = Console.ReadLine().Split(' ');
                for (int j=0; j<N; j++)
                {
                    B[i, j] = int.Parse(line[j]);
                }
            }

            for (int i=0; i<M; i++)
            {
                for (int j=0; j<N; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (int i=0; i<M; i++)
            {
                for (int j=0; j<N; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
            }

        }

    }
}
