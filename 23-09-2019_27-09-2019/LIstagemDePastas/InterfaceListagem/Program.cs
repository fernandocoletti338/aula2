using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace InterfaceListagem
{
    class Program
    {
        static DocumentsAutoGenerate documents = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            var menu = int.MinValue;
            while (menu != 0)
            {
                Console.Clear();
                Console.WriteLine("sistema de pasta");
                Console.WriteLine("1 - Criar pasta em meusdocumentos");
                Console.WriteLine("2 - deletar pasta em meus documentos");
                Console.WriteLine("3 - Listar meus documentos");
                Console.WriteLine("4 - sextou");
                Console.WriteLine("0 - Sair");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("informe o nome da pasta:");
                        var nomePasta = Console.ReadLine();

                        documents.CriarPastaMeusDocumentos(nomePasta);
                    break;
                    case 2:
                        Console.WriteLine("irforma pasta para excluir");
                        var nomePastaD = Console.ReadLine();

                        documents.DeletarPastaMeusDocumentos(nomePastaD, true);
                            break;
                    case 3:
                        documents.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
                        break;
                    case 4:
                        new HoraDoShow().Birllllllllll();
                        break;
                }
                Console.ReadKey();
            }
            
        }
    }
}
