using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4 - Criar um console app que apresente a quantidade total de caracteres que contém em um texto informado
//pelo usuário.
namespace exercicio4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira uma palavra:");
            var texto = Console.ReadLine();
            var qtdCaracter = texto.Length;
            Console.WriteLine($"o texto contem {qtdCaracter} caracteres.");
            Console.ReadKey();


        }
    }
}
