using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalagoCelulares.Model;
using CatalagoCelulares.Controller;

namespace CellDu
{
    class Program
    {
        // 1 colocar console app para startar o projeto
        // 2 adicionar referencia  catalagoCelulares
        // 3 adicionar entity em nosso projeto
        // 4 adicionar using ao nosso projeto Model, controller
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            //definimos uma opcao de menu inicial
            var opcao = int.MinValue;
            //definimos que enquanto for difernte de 
            //ele continua em nosso loop

            while(opcao != 0)
            {
                Console.WriteLine("Escolha uma opcao");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        IserirCelular();
                        break;
                            
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                Console.ReadKey(true);
            }
        }
        

        // inserir 
        public static void IserirCelular()
        {
            Console.WriteLine("--Inserir Celular--");
            Console.WriteLine("Informe o Marca Celular");
            //obtemos o modelo do celular
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do Celular");
            // obtemos o valor do aparelho

            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o valor do aparelho");
            //obtemos o valor do aparelho

            var preco = double.Parse(Console.ReadLine());
            //criamos o resultado para identificar ucesso ou erro

            var resultado = celulares.InserirCelular(new Celular()
            //nossa controller pelo nome que damos a ela> (InserirCelular)um novo celular
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco

            });
            //verificamos se o valor é verdaderi ou falso
            if (resultado)// caso verdade sucesso
                Console.WriteLine("Celular cadastrado com sucesso");
            else// caso falso apresenta o aviso
                Console.WriteLine("Erro ao cadastrar celular");
        }
        // atualizar
        // remover 
        // listar
    }
}
