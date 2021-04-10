using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();

            Console.Write("Nome: ");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Entre com as 3 notas do alun: ");
            al.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota final: " + al.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (al.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram: " + al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
