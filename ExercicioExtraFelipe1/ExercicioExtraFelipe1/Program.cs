using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExtraFelipe1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string> { "Fernando", "Sheila", "Gabriel", "Cleiton", "Giomar", "Cleidson",
                "Erineldson", "Jocieldson", "Pedro", "Cleonison"};
            foreach (var nome in nomes) ;

            Console.WriteLine(nomes);

            Console.ReadKey();

        }
    }
}
