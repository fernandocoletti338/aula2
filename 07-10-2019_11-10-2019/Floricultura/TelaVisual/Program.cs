using CatalagoFlores.Controller;
using CatalagoFlores.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaVisual
{
    public class Program
    {
        static FloresController floresController = new FloresController();
        static void Main(string[] args)
        {

            floresController.CadastrarFlor(new Flores() { Nome = "TESTE" , Quantidade = 1} );
            Console.WriteLine("Lista de flores ORDENADAS:");
            floresController.RetornarFloresOrdenadoPorQuantidade().ForEach(p => Console.WriteLine(p.Nome));
            Console.WriteLine("Quantidade total de Flores :");
            Console.WriteLine(floresController.RetornarOTotalDeFlores());
            Console.ReadKey();

        }
    }
}
