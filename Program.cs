using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    class Program
    {
        static void Main(string[] args)

        {  //Entrada de Dados

            Console.WriteLine("Digite o nome da pessoa 1");
            var nome1 = Console.ReadLine();

            Console.WriteLine("Digite o nome da pessoa 2");
            var nome2 = Console.ReadLine();

            Console.WriteLine("Digite o nome da pessoa 3");
            var nome3 = Console.ReadLine();

            Console.WriteLine("Digite o nome da pessoa 4");
            var nome4 = Console.ReadLine();

            //Trocas de nomes

           
           

           

            Console.WriteLine("Ordem Invertida: ");

            //Armazena o nome 1
            var auxiliar = nome1;

            //Troca o nome 1 pelo nome 4
            nome1 = nome4;

            //Troca o nome 4 pelo guardado na auxiliar

            nome4 = auxiliar;

            //Armazena o nome 2
            auxiliar = nome2;

            //Troca o nome 2 pelo nome 3
            nome2 = nome3;

            // Troca o nome 3 pelo guarado na auxiliar
            nome3 = auxiliar;
           
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

            Console.ReadKey();




        }
    }
}
