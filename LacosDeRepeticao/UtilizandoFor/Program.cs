using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoFor
{
    class Program
    {
        static void Main(string[] args)
        {

            var nome = "Meu nome é Fernando Coletti e meu nome era pra ser Ferdinando";
            var countFind = 0;
            Console.WriteLine("Encontre uma palavra:");
            var palavra = Console.ReadLine();


            for (int i = 0; i < (nome.Length -2); i++)
            {
                var palavraParaComparar = nome[i].ToString() +
                    nome[i + 1].ToString() +
                    nome[i + 2].ToString();

                if (palavra == palavraParaComparar) countFind++;

            }

            Console.WriteLine($"quantidade total de '{palavra}' {countFind}");

            Console.ReadKey();
        }
    }
}
