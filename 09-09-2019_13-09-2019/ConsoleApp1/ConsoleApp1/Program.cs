using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Texto informativo para consultar o livro
            //pelo numero de registro do sistema
            Console.WriteLine("Informe o livro a ser consultado:");
            //parte do codigo que recebe as informações
            //de regitro do livro e coloca na variavel
            //numero do livro para utilizar
            var numeroDoLivro = Console.ReadLine();
            //aqui realizo a comparação das informações
            //do livro informado com o que tenho disponivel
            //em estoque
            if (numeroDoLivro == "123456")
            {
                //informo que este livro ja está locado
                Console.WriteLine("Livro indisponivel");
                Console.ReadKey();
                //finaliza o metodo
                return;
            }
            else
            {

                Console.WriteLine("Deseja alocar o livro? (1) sim (2) não");
                var resposta = Console.ReadLine();
                if(resposta == "1")
                {
                    Console.WriteLine("Livro alocado.");
                    Console.ReadKey();
                    return;
                }
            }
           
            
        }
    }
}
