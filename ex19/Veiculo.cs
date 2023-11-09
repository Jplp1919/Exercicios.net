using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex19
{
    internal class Veiculo
    {
        decimal Velocidade { get; set; }

        public void Acelerar()
        {
            if (Velocidade == null) { 
            Velocidade = 0;
            }
            Velocidade += 1;
            Console.WriteLine("Acelerando");
            Console.WriteLine($"Velocidade -> {Velocidade}");

        }

        public void Parar () {
            Console.WriteLine("Parando");
            Velocidade = 0;
        }


    }
}
