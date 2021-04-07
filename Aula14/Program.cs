using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {

            //Treinamento -  Aula14, inserir dados, tipo string, concatenação
            //Jonas Valereo - Técnico em informática

            //Declarando as variaveis

            string nome;
            string sobrenome;
            


            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();


            //imprimir saida de dados no console, método WhriteLine

            Console.WriteLine("Meu nome: " + nome);
            Console.WriteLine("Meu sobrenome: " + sobrenome);



            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();


            //Fim do progama
        }
    }
}
