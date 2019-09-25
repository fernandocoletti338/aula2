using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq//agregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe",
                "Giomar",
                "Euricledson",
                "Adagoberto",
                "Ezebio",
                "Irineudson"
            };

            var texto = listaDeNomes.Aggregate((nome1, nome2) => nome1 + ";" + nome2);

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
