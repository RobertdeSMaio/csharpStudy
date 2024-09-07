using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pessoa.Models //modelo para se reutilizar
{
    public class PessoaFisica //como e a pessoa | classe
    {
        
        public string Nome {get; set;}
        public int Idade {get; set;}

        public void Apresentar()//o que ela vai fazer | metodos
        {
            Console.WriteLine($"Ola, meu nome e {Nome}, e tenho {Idade} anos");
        }
    }
}