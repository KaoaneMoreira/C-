using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha, senha_correta;

            senha_correta = 2002;
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida!");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido.");
        }
    }
}
