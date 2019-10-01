using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7 - Criar um console app conte a quantidade de "a","e","i","o" e "u" dentro de um texto informado
//pelo usuário.

namespace exercicio7_7
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("informe a frase");
            var frase = Console.ReadLine();

            var counta = frase.Split('a').Length - 1;
            var counte = frase.Split('e').Length - 1;
            var counti = frase.Split('i').Length - 1;
            var counto = frase.Split('o').Length - 1;
            var countu = frase.Split('u').Length - 1;

            Console.WriteLine($"qtd de 'a' encontrado é:{counta}");
            Console.WriteLine($"qtd de 'a' encontrado é:{counte}");
            Console.WriteLine($"qtd de 'a' encontrado é:{counti}");
            Console.WriteLine($"qtd de 'a' encontrado é:{counto}");
            Console.WriteLine($"qtd de 'a' encontrado é:{countu}");

            Console.ReadKey();
        }
    }
}
