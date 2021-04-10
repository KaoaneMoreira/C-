using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] line = Console.ReadLine().Split(' ');
            M = int.Parse(line[0]);
            N = int.Parse(line[1]);

            int[,] A = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                string[] line2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(line2[j]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
