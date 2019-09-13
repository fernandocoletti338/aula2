using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowIniAppText();

            string nome = string.Empty;
            int idade = 0;

             while (AskToContinue() == 1)
            {
                nome = QualSeuNome();
                idade = VocePodeBeber(nome);
                
            }
            Console.WriteLine($"Suas informações: Seu nome é {nome} e sua idade é {idade} anos.");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static void ShowIniAppText()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("-------------------");
        }
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim(1) não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }
        /// <summary>
        /// Avali se o usuario pode ou não beber
        /// </summary>
        private static int VocePodeBeber(string nome)
        {
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >=18)
                Console.WriteLine($"{nome} você pode beber cerveja");
            
            else
                Console.WriteLine($"{nome} você não pode beber cerveja");

            return idade;
        }
        private static string QualSeuNome()
        {
            Console.WriteLine("Qual seu nome?");
            return Console.ReadLine();
        }
    }
}
