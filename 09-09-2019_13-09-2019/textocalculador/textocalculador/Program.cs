using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textocalculador
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "oi meu nome Felipe e logo eu Felipe tenho vontade de codar durante minha vida";

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: { primeiroTexto.Length} caracteres.");

            primeiroTexto = primeiroTexto.Replace("Felipe", "1").Replace("codar", "2");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: { primeiroTexto.Length} caracteres.");
            Console.ReadKey();




        }
    }
}
