using System;
using System.Globalization;

namespace Uri_1001
{
    class Program{
        static void Main(string[] args){
            int N, quociente, resto, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + "nota(s) de " + nota + ",00");



        }
    }
}
