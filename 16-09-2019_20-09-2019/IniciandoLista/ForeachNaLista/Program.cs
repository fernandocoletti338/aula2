using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeDecimais();
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MMMM/dd")));

        }

        /// <summary>
        /// Mostra lista de String definidas
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("Xiaomi");
            minhaLista.Add("Iphone Apple");
            minhaLista.Add("Samsung");
            minhaLista.Add("Nokia");

            minhaLista.ForEach(i => Console.WriteLine(i));//"i" item da lista

        }
        /// <summary>
        /// Minha lista de numeros decimais
        /// </summary>
        private static void LIstaDeInteiros()
        {
            var minhaLista = new List<int>();

            minhaLista.Add(17);
            minhaLista.Add(18);
            minhaLista.Add(19);
            minhaLista.Add(20);

            minhaLista.ForEach(meuNumero => Console.WriteLine(meuNumero));

        }

        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " " + FormataNumeroDecimalEmDolar(meuDecimal)+" " + FormataNumeroDecEuro(meuDecimal)+ " " + FormataNumeroDecYen(meuDecimal)+ " " + FormataNumeroDecBitcoin(meuDecimal)));  
        }
        /// <summary>
        /// metodo que converte meu numero em real para dolar
        /// </summary>
        /// <param name="meuNumero"></param>meu numero em reais
        /// <returns></returns>retorna o valor formatado em dolar

        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

        }
        /// <summary>
        /// metodo que converte meu numero em real para euro
        /// </summary>
        /// <param name="meuNumero"></param>meu numero em reais
        /// <returns></returns>retorna o valor formatado em euro
        private static string FormataNumeroDecEuro(double meuNumero)
        {
            return (meuNumero / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("de-DE")).Replace("$","Euro ");
        }
        /// <summary>
        /// metodo que converte meu numero em real para yen
        /// </summary>
        /// <param name="meuNumero"></param>meu numero em reais
        /// <returns></returns>retorna o valor formatado em yen
        private static string FormataNumeroDecYen(double meuNumero)
        {
            return (meuNumero / 0.38).ToString("C5", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// metodo que converte meu numero em real para Bitcoin
        /// </summary>
        /// <param name="meuNumero"></param>meu numero em reais
        /// <returns></returns>etorna o valor formatado em Bitcoin
        private static string FormataNumeroDecBitcoin(double meuNumero)
        {
            return (meuNumero / 41997.32).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC ");
        }

    }
}
