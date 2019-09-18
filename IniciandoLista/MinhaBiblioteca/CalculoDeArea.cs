using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculoDeArea
    {
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
    }
}
