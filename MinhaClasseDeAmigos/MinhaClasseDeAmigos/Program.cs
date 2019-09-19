using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaClasseDeAmigos
{
    class Program
    {
        static void Main(string[] args)
        {
            var classeDeAmigos = new List<Amigos>();

            classeDeAmigos.Add(new Amigos()
            {
                Nome = "Gabriel",
                TempoAmizade = 13
            });
            classeDeAmigos.Add(new Amigos()
            {
                Nome = "Diogo",
                TempoAmizade = 10
            });
            classeDeAmigos.Add(new Amigos()
            {
                Nome = "Edna",
                TempoAmizade = 8
            });

            classeDeAmigos.ForEach(i => Console.WriteLine($"Meu amigo(a) se chama {i.Nome} e temos {i.TempoAmizade} anos de amizade."));

            Console.ReadKey();
        }
    }
}
