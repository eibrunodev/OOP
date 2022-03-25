using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numero = 0;
            //string texto = "Olá Mundo";
            //DateTime dataAtual = DateTime.Now;

            //Console.WriteLine(texto);  
            //Console.WriteLine(dataAtual);
            //Console.WriteLine(numero);


            ////Classe Randon 

            //Random r = new Random();
            //int num = r.Next();
            //Console.WriteLine(num);

            //Classe pessoa
            Pessoa objPessoa = new Pessoa();

            objPessoa.codPessoa = 1;
            objPessoa.nome = "Bruno";
            objPessoa.endereco = "AV Contorno xxxx";
            objPessoa.sexo = (int)Sexo.Masculino;
            objPessoa.idade = 28;

            //Segundo objeto Pessoa

            Pessoa objtPessoa2 = new Pessoa();

           objtPessoa2.codPessoa = 2;
           objtPessoa2.nome = "Janny";
           objtPessoa2.endereco = "Rua Joaquina sem rumo";
           objtPessoa2.sexo = (int)Sexo.Feminino;
           objtPessoa2.idade = 28;

            ////Pessoa 01 
            //Console.WriteLine("COD: "+objPessoa.codPessoa.ToString());
            //Console.WriteLine("Nome: "+objPessoa.nome);
            //Console.WriteLine("Sexo: "+objPessoa.sexo);
            //Console.WriteLine("Endereço: "+objPessoa.endereco);
            //Console.WriteLine("Idade: "+objPessoa.idade);

            //Console.WriteLine("------------------------------------");
            ////Pessoa 02

            //Console.WriteLine("COD: "+objtPessoa2.codPessoa.ToString());
            //Console.WriteLine("Nome: "+ objtPessoa2.nome);
            //Console.WriteLine("Sexo: "+ objtPessoa2.sexo);
            //Console.WriteLine("Endereço: "+ objtPessoa2.endereco);
            //Console.WriteLine("Idade: "+ objtPessoa2.idade);


            //Retorna os mesmos valores de cima assim : 

            var listaRetorno = getPropertyValues(objPessoa);

            //percorre a lista 

            foreach (var item in listaRetorno)
            {
                Console.WriteLine(item.Value.ToString());
            }

            //percorre a lista 2 

            var listaRetorno2 = getPropertyValues(objtPessoa2);
            foreach(var item in listaRetorno2)
            {
                Console.WriteLine(item.Value.ToString());
            }

            //metodo que retorna os valores

        }


        public static Dictionary<string, object> getPropertyValues(object o)
        {
             Dictionary<string,object> propertyValues  = new Dictionary<string,object>();
             Type objectType = o.GetType();
            System.Reflection.PropertyInfo[] properties = objectType.GetProperties();
            foreach (System.Reflection.PropertyInfo property in properties)
            {
                propertyValues.Add(property.Name, property.GetValue(o, null));
            }
            return propertyValues;
        }

    }
}
