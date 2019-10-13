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

            var menu = int.MinValue;

            while (menu != 0)
            {
                Console.WriteLine("Escolha uma opção do menu");
                Console.WriteLine("1 - Cadastrar Bicicleta");
                Console.WriteLine("0 - Sair");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        InserirBicicleta();
                        break;
                    default:
                        Console.WriteLine("opção Invalida");
                        break;
                }
            }
            /* bicicletasController.InserirBicicleta(new Bicicleta() { Modelo = "Giraya", Marca = "Avassaladoreon" , Valor = 750.55 });

             Console.WriteLine("Bicicletas cadastradas:");

             bicicletasController.GetBicicletas().ToList().ForEach
                 (b => Console.WriteLine($"Id: {b.Id} Modelo: {b.Modelo} Marca: {b.Marca} Valor: {b.Valor}"));

             Console.ReadKey();*/

        }

        public static void InserirBicicleta()
        {
            Console.WriteLine("--Cadastro De Bicicleta--");
            Console.WriteLine("Informe o modelo da bicicleta a ser cadastrada:");

            var modelo = Console.ReadLine();

            Console.WriteLine("Informe a marca da bicicleta:");

            var marca = Console.ReadLine();

            Console.WriteLine("Informe o valor da bicicleta:");

            var valor = double.Parse(Console.ReadLine());

            var cadastro = bicicletasController.InserirBicicleta(new Bicicleta()
            {
                Modelo = modelo,
                Marca = marca,
                Valor = valor
            });

            if (cadastro)
                Console.WriteLine("Bicicleta cadastrada com sucesso");
            else
                Console.WriteLine("Bicicleta não cadastrada");

        }
    }
}
