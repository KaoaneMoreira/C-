using System;
using System.Globalization;

namespace exe_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n): ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S'){
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: " + conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(dep);
            Console.WriteLine("Dados atualizados: " + conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saq);
            Console.WriteLine("Dados atualizados: " + conta);

        }
    }
}
