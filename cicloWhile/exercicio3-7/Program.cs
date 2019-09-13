using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3 - Criar um console app que solicite o nome e a idade, e após informar nome e idade o mesmo
//deverá apresentar quando maior ou igual a 18 anos a seguinte informação:
//"Parabéns {nome} você já esta na fase adulta."
//caso menor de 18 anos o mesmo deverá apresentar a seguinte informação:
////"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade."
namespace exercicio3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual seu nome e sua idade?");
            var nome = Console.ReadLine();
            var idade = int.Parse (Console.ReadLine());
            Console.WriteLine($"seu nome é {nome} e sua idade é {idade}.");

            if (idade >= 18)
            {
                Console.WriteLine($"Parabéns {nome} você já esta na fase adulta.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");
                Console.ReadLine();
            }

        }
    }
}
