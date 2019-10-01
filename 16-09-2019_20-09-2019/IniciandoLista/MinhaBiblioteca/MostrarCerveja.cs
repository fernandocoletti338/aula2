using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostrarCerveja
    {
        public static void listaCerveja()
        {
            var listaAmada = new List<string>();

            listaAmada.Add("Skol");
            listaAmada.Add("Original");
            listaAmada.Add("Corona");
            listaAmada.Add("Brahma");
            listaAmada.Add("Budweiser");

            listaAmada.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
