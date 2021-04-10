

namespace membros_estaticos
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quantidade, double cotacao)
        {
            double total = cotacao * quantidade;
            return total + total * Iof / 100.0;
        }
    }
}
