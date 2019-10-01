using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostrarCarro
    {
        public static void marcaCarros()
        {
            var listaCarros = new List<string>();

            listaCarros.Add("Tucson");
            listaCarros.Add("Pajero");
            listaCarros.Add("Sportage");
            listaCarros.Add("Troller");
            listaCarros.Add("Gol");

            listaCarros.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
