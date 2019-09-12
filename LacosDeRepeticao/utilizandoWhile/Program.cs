using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilizandoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            while (count < 1000000)
            {
                Console.WriteLine($"Numero:{count}");
                count++;
            }
            Console.WriteLine("terminou o loop");
            Console.ReadKey();
        }
    }
}
