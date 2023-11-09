using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16
{
    internal class Circulo
    {
        public double Raio { get; set; }

        public double Diametro { get; set; }

        public double Area { get; set;}

        public double Perimetro { get; set; }

        public const double PI = 3.14;
        

        public double calculateArea(double raio)
        {
            Raio = raio;
           Area = (raio * raio) * PI;

            return Area;

        }

        public double calculatePerimetro(double raio)
        {
            Raio = raio;
            Diametro = raio * 2;

            Perimetro = PI * Diametro;

            return Perimetro;

        }

    }
}
