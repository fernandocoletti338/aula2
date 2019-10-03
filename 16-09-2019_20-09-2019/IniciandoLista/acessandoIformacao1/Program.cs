using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace acessandoIformacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuDoSistema();
        }
        private static void MenuDoSistema()
        {
            while (true)
            {
                Console.WriteLine("Escolha uma das opções do menu:");
                Console.WriteLine("Opção 1: Calculo de Area");
                Console.WriteLine("Opção 2: Mostra Arvore");
                Console.WriteLine("Opção 3: Mostra Cerveja");
                Console.WriteLine("Opção 4: Mostrar Carro");
                Console.WriteLine("Opção 5: Sair do Sistema");

                var opcaoMenu = Console.ReadLine();

                switch (opcaoMenu)
                {
                    case "1":
                        {
                            CalculoDeArea.calculoDeArea();
                        }
                        break;
                    case "2":
                        {
                            MostrarArvore.arvore();
                        }
                        break;
                    case "3":
                        {
                            MostrarCerveja.listaCerveja();
                        }
                        break;
                    case "4":
                        {
                            MostrarCarro.marcaCarros();
                        }
                        break;
                        
                    case "5":
                        return;
                }
            }

            

        }
    }
}
