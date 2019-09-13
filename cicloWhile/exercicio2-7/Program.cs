using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2 - Criar um console app que apresente as boas vindas, solicite o nome do usuário.completo e
//mostre uma mensagem de boas vindas com o nome do usuário.

namespace exercicio2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("seja bem vindo");
            Console.WriteLine("qual seu nome completo?");
            var nome = Console.ReadLine();
            Console.WriteLine($"seja bem vindo {nome}.");
            Console.ReadKey();
            
        }
    }
}
