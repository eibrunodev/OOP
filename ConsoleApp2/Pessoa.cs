using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pessoa
    {
        public int codPessoa { get; set; } 
        public string nome { get; set; }
        public string endereco { get; set; }
        public int idade { get; set; } 
        public int sexo { get; set; }
    }

    enum Sexo
    {
        Masculino,
        Feminino,
        Outro
    };


}
