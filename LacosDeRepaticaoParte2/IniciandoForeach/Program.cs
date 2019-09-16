using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplitIdade();
        }
        /// <summary>
        /// Metodo que mostra como podemos utilizar para andar sobre uma array
        /// </summary>
        private static void IniciandoForeach01()
        {
            Console.WriteLine("informar texto");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e')
                    continue;

                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// metodo de busca com split e informando o nome
        /// </summary>
        private static void ForeachComSplit()
        {
            Console.WriteLine("informe o seu nome");

            var conteudoDoTexto = $" Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar; com;o;replace";

            Console.WriteLine("informe a palavra para realizar a busca");//informa o texto.
            var palavra = Console.ReadLine();//le a variavel "palavra".

            var conteudoTextoSplit = conteudoDoTexto.Split(';');//le o conteudo do texto "conteudoDoTexto" e divide em partes do ";".

            foreach (var item in conteudoTextoSplit)//passa passsa pelos itens do conteudo do texto um a um.
            {
                if (palavra == item)//le as palavras e qdo for a palavra buscada ele manda a mesagem da proxima linha.
                    Console.WriteLine("palavra encontrada com sucesso!");

            }

            Console.ReadKey();
        }

        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Fernando,idade:31;nome:Giomar,idade:75;nome:Eusebio,idade:29";

            var listaDeInformacoes = conteudo.Split(';');

            Console.WriteLine("usuarios cadastrados no sistema:");

            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("informe um nome de um usuario do sistema:");
            var nomeBusca = Console.ReadLine();
            {
                foreach (var item in listaDeInformacoes)
                {
                    var informacoesSplit = item.Split(',');

                    var nome = informacoesSplit[0].Split(':')[1];
                    var idade = informacoesSplit[1].Split(':')[1];

                    if (nome == nomeBusca)
                    {
                        Console.WriteLine($"o {nome} está com {idade} anos de idade.");
                    }
                }
            }

            Console.ReadKey();
        }

        private static void ForeachComSplitveilculo()
        {
            //Base de informações
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";

            var listaDeCarros = conteudo.Split(';');//subdivide a informação do "conteudo" pelo ";" (separa)

            Console.WriteLine("Carros cadastrados no sistema:");// escreve "Carros cadastrados no sistema:"

            foreach (var item in listaDeCarros)//le a lista separada pelo ";" e escreve 
            {
                Console.WriteLine(item.Split(';')[0]);
            }

            Console.WriteLine("Informe o nome de um carro cadastrado no sistema:");//escreve "Informe o nome de um carro cadastrado no sistema"
            var nomeBusca = Console.ReadLine();//le o nome digitado
            {
                foreach (var item in listaDeCarros)//le a lista separada pela ',' ':'
                {
                    var informacoesCarro = item.Split(',');


                    var carro = informacoesCarro[0].Split(':');
                    var marca = informacoesCarro[1].Split(':');
                    var ano = informacoesCarro[2].Split(':');

                    if (carro[1] == nomeBusca)//se achar o carro digitado ele ecreve a proxima linha
                    {
                        Console.WriteLine($" {carro[1]} pertence a marca {marca[1]} e foi fabricado no ano {ano[1]}.");
                    }
                }
            }
            Console.ReadKey();
        }
        //Lista de informações 
// Apresentar apenas os nomes que tem idade maior ou igual a 18 anos.

//nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45

        private static void ForeachComSplitIdade()
        {

            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

            var listaMaiorIdade = conteudo.Split(';');

            foreach (var item in listaMaiorIdade)
            {
                var nomeLista = item.Split(',');

                var nomes = nomeLista[0].Split(':')[1];
                var idade = int.Parse(nomeLista[1].Split(':')[1]);

                if (idade >= 18)
                {
                    Console.WriteLine($"{nomes} tem {idade} anos e é maior de idade.");
                }
            }
            Console.ReadKey();
        }

    }
}
