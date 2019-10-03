using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarIteirosPrimitivos();
            SomaInteirosLista();
            SomaBalasListaDeCriancas();

            Console.ReadKey();
        }

        private static void SomarIteirosPrimitivos()
        {
            //qdo utilizamos "[]" em um tipo "primitivo" podemos criar uma coleçõa destes  valores
            int[] colecaoInteiros = new int[5]
            //aqui carregamos nossa coleção de valores
            {1,2,3,4,5};

            Console.WriteLine(colecaoInteiros.Sum());

        }
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {
                1,2,3,4,5,6,7,8,8,9,10,11,12
            };

            Console.WriteLine(listaDeInteiros.Sum());
        }

        private static void SomaBalasListaDeCriancas()
        {
            List<Crianca> criancas = new List<Crianca>()
            {
            new Crianca()
            {
                Nome = "Joazinha",
                Balas = 9
            },
            new Crianca()
            {
                Nome = "Pedrinho",
                Balas = 68
            }
            };
            Console.WriteLine("Quantidade total de balas das criancinhas levaram da venda");
            Console.WriteLine(criancas.Sum(x => x.Balas));
        }
    }
}
