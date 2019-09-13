using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5 - Criar um console app que apresente o primeiro e o ultimo caractere de uma palavra informada.
namespace exercicio5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe uma palavra");
            var texto = Console.ReadLine();
            var primeiraletra = texto[0].ToString();
            Console.WriteLine(texto.Length);
            var ultimaletra = texto[texto.Length - 1].ToString();
            Console.WriteLine($"a primeira letra do texto é {primeiraletra}");
            Console.WriteLine($"a ultima letra do texto é {ultimaletra}");
            Console.ReadLine();
        }
    }
}
