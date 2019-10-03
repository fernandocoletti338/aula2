using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoDLLDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        private static void Menu()
        {
            Console.WriteLine("Escolha uma das opções do menu:");
            Console.WriteLine("Opção 1: Calculo de Area");
            Console.WriteLine("Opção 2: Mostra Arvore");
            Console.WriteLine("Opção 3: Mostra Cerveja");
            Console.WriteLine("Opção 4: Mostrar Carro");
            Console.WriteLine("Opção 5: Sair do Sistema");

            var menuOpcao = Console.ReadLine();

            switch (menuOpcao)
            {
                case "1":
                    {
                        var area = new CalculosDeArea();

                        Console.WriteLine("informe o valor do lado");
                        var ladoDoQuadrado = int.Parse(Console.ReadLine());

                        Console.WriteLine(area.CalculaAreaDoQuadrado(ladoDoQuadrado));
                    }
                    break;
                case "2":
                    {
                        Arvore.ArvoreDesenho();
                    }
                    break;
                case "3":
                    {
                        ListaCerveja.Cervejas();
                    }
                    break;
                case "4":
                    {
                        ListaCarros.Carros();
                    }
                    break;
                case "5":
                    return;
            }

            

        }
    }
}
