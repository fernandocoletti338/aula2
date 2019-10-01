using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoa
{
    class Program
    {
        static List<Pessoa> listaPessoa = new List<Pessoa>();
        static void Main(string[] args)
        {
            Console.WriteLine("digite 1 para inserir");
            Console.WriteLine("digite 2 para listar");
            Console.WriteLine("digite 3 para sair");
            var opcao = Console.ReadLine();
            if (opcao = 3) 
            // switch (opcao)
            // {
            //case "1":
            //AdcionaLsta();
            // breake;

            //  }
            while (opcao == "1")
            {
                AdicionaLista();

                Console.WriteLine("digite 1 para inserir.");
                opcao = Console.ReadLine();
            }
            Listar();
            Console.ReadKey();
            while (opcao == "2")
            {
                Listar();
                Console.WriteLine("digite 2 para listar:");
                    opcao = Console.ReadLine();
            }
                       
        }
        public static void AdicionaLista()
        {

            var listaPessoa = new List<Pessoa>();
            var informacaoPessoa = new Pessoa();

            Console.WriteLine("Informe o nome:");
            informacaoPessoa.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade:");
            informacaoPessoa.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Infome sexo:");
            informacaoPessoa.Sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Infome a altura");
            informacaoPessoa.Altura = double.Parse(Console.ReadLine());

            listaPessoa.Add(informacaoPessoa);
                       
            Console.ReadKey();
        }
        public static void Listar()
        {
            listaPessoa.ForEach(i => Console.WriteLine($"informação pessoal: Nome:{i.Nome}, Idade:{i.Idade} anos, Sexo:{i.Sexo}, Altura:{i.Altura} M"));
        }
    }
}
