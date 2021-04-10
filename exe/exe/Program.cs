using System;

namespace exe
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
