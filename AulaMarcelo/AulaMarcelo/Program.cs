using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMarcelo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random rdm = new Random();

            ///lambda= where/orderby/fyrstordefault

            for (int i = 0; i < 10; i++)
            {
                //gera um numero aleatoria de 0 a 100
                int valorGeradoAleatoriamente = rdm.Next(100);

                //verifica se a lista não contem este numero gerado               
                if (!numeros.Contains(valorGeradoAleatoriamente))
                {
                    //adiciona o numero gerado pelo rANDOM(QUE NÃO É REPETIDO)
                    numeros.Add(valorGeradoAleatoriamente);
                }
                else
                {
                    i--;
                }

            }
            Console.ReadLine();
        }
    }
}
