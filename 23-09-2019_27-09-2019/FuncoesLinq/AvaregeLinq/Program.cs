using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaregeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vendas> vendas = new List<Vendas>()
            {
                new Vendas()
                {
                    Produto = "XIAOMI Lite 6 quad Core 128gb 32px frontal",
                    Quantidade = 8,
                    Valor = 1200.75
                },
                new Vendas
                {
                    Produto = "SLIM 3500 APP",
                    Quantidade = 5,
                    Valor = 2800.96
                },
                new Vendas()
                {
                    Produto = "IPHONE FOGÃO 3 BOCAS",
                    Quantidade = 1,
                    Valor = 9999.99
                }
            };

            Console.WriteLine("Media de produtos vendidos neste mês");
            Console.WriteLine(vendas.Average(x => x.Quantidade));
            Console.WriteLine("Media total de vendas neste mês em R$");
            Console.WriteLine(vendas.Average(x => (x.Quantidade * x.Valor)));

            Console.ReadKey();
        }
    }
}
