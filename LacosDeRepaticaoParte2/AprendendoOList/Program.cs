using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoOList
{
    class Program
    {
        private static List<string> minhaLista = new List<string>()
            {
                "Felipe",
                "Irineu",
                "Serilop"
            };
        static void Main(string[] args)
        {
            adicionarItensALista();

            ListaInformacoes();

            Console.ReadKey();
        }
        private static void adicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("informe o nome:");
            minhaLista.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Deseja informar mais valores? sim(S) não(N)");

            if(Console.ReadLine().ToLower() == "s")
                adicionarItensALista();

            
        }

        /// <summary>
        /// metodo que mostra a lista 
        /// </summary>
        private static void ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados a lista:");
            foreach (var item in minhaLista)
                Console.WriteLine($"Nome: {item} foi adicionado a lista");
        }
    }
}
