using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17
{
    internal class ContaBancaria
    {
        private decimal Saldo = 0;

        public void Depositar(decimal deposito)
        {
            Saldo += deposito;
        }

        public void Sacar (decimal amount)
        {
            if (amount > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                Saldo -= amount;
                Console.WriteLine($"{amount} sacado com sucesso");
            }

        }

        public decimal ConsultarSaldo() {
            Console.WriteLine($"O seu saldo é {Saldo}");
            return Saldo;}

    }
}
