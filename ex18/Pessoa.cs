using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }
        public string Cidade { get; set;}



    public  Pessoa() { }

    

        public  Pessoa(string nome, int idade, string cidade)
        {
            Nome = nome;
            Idade = idade;
            Cidade = cidade;
            
            
        }


        public void mostrarInformações()
        {
            Console.WriteLine($@"Nome: {Nome}; Idade: {Idade}; Cidade: {Cidade}; ");
        }


    }
}
