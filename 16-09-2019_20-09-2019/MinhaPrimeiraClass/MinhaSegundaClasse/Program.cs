using MinhaSegundaClasse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaCestaDeFrutas = new List<CestaDeFrutas>();

            minhaCestaDeFrutas.Add(new CestaDeFrutas()
            {
                Nome = "Banana",
                Quantidade = 5

            });

            minhaCestaDeFrutas.Add(new CestaDeFrutas()
            {
                Nome = "Laranja",
                Quantidade = 2
            });
            minhaCestaDeFrutas.ForEach(i => Console.WriteLine(($"Nome {i.Nome} Quant {i.Quantidade}")));

            Console.ReadKey();

        }
    }
}
