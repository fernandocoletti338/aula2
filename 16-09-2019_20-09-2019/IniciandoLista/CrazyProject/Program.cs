using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            calculoDeArea();
        }

        public static void arvore()
        {
            Console.WriteLine(@"     _@@@@_      ");
            Console.WriteLine(@"   /@@@@@@@@\    ");
            Console.WriteLine(@" /@@@@@@@@@@@@\  ");
            Console.WriteLine(@"(@@@@@@@@@@@@@@) ");
            Console.WriteLine(@" \@@@@@@@@@@@@/  ");
            Console.WriteLine(@"  \@@@@@@@@@@/   ");
            Console.WriteLine(@"      |##|       ");
            Console.WriteLine(@"      |##|       ");
            Console.WriteLine(@"      |##|       ");
            Console.WriteLine(@"     /####\      ");

            Console.ReadKey();
        }
        public static void calculoDeArea()
        {
            Console.WriteLine("Calculo de area:");
            Console.WriteLine("As medidas podem ser em qualquer unidade. O valor obtido será na unidade informada:");

            double a, b, area;

            Console.WriteLine("Informe as medidas para 'a':");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor para 'b':");
            b = Convert.ToDouble(Console.ReadLine());

            area = a * b;

            Console.WriteLine($"A area do quadrado é:{area}");

            Console.ReadKey();
        }

        public static void listaCerveja()
        {
            var listaAmada = new List<string>();

            listaAmada.Add("Skol");
            listaAmada.Add("Original");
            listaAmada.Add("Corona");
            listaAmada.Add("Brahma");
            listaAmada.Add("Budweiser");

            listaAmada.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
        public static void marcaCarros()
        {
            var listaCarros = new List<string>();

            listaCarros.Add("Tucson");
            listaCarros.Add("Pajero");
            listaCarros.Add("Sportage");
            listaCarros.Add("Troller");
            listaCarros.Add("Gol");

            listaCarros.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }

    }
}
