using System;
using System.Globalization;
using System.Text;

namespace exe_fixacao
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) :this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo = (Saldo - 5.00) - saque;
        }


        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
