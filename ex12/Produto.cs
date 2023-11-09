using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    public class Produto
    {
        public String Nome { get; set; }
        public double Preço { get; set; }

        public int Estoque { get; set; }


        public Produto(String nome, double preço, int estoque) { 
        
            Nome = nome;
            Preço = preço; 
            Estoque = estoque;

        }
    }
}
