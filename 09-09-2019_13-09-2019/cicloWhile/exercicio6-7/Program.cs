using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6 - Criar um console app que quando informado o texto contendo banana ele troque esta informação
//por laranja.
namespace exercicio6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o texto");
            var texto = Console.ReadLine();
            var textoAlterado = texto.Replace("banana", "laranja");

            Console.WriteLine(textoAlterado);
            Console.ReadKey();
        }
    }
}
