using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.AdicionarCerveja(new Cerveja()
            {
                Id = cervejaController.GetCervejas().Count + 1,
                Nome = "Giomar",
                Litros = 0.600,
                Alcool = 8,
                Valor = 15
            });

            cervejaController.GetCervejas().ForEach(x => Console.WriteLine($" ID {x.Id} Cerveja {x.Nome} Valor {x.Valor.ToString("C")} Teor Alcoolico {x.Alcool}"));

            Console.WriteLine("Total Litro:" + cervejaController.RetornarValorEmLitros());
            Console.WriteLine("Total Valor:" + cervejaController.RetornarValor().ToString("C"));

            Console.ReadKey();
        }
    }
}
