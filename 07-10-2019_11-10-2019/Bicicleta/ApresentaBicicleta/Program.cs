using CadastroDeBicicleta.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeBicicleta.Model;

namespace ApresentaBicicleta
{
   public class Program
    {
        static BicicletasController bicicletasController = new BicicletasController();
        static void Main(string[] args)
        {
            bicicletasController.InserirBicicleta(new Bicicleta() { Modelo = "Giraya", Marca = "Avassaladoreon" , Valor = 750.55 });

            Console.WriteLine("Bicicletas cadastradas:");
            
            bicicletasController.GetBicicletas().ToList().ForEach
                (b => Console.WriteLine($"Id: {b.Id} Modelo: {b.Modelo} Marca: {b.Marca} Valor: {b.Valor}"));

            Console.ReadKey();

        }
    }
}
