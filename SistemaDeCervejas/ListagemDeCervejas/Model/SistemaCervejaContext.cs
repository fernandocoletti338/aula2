using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
        public class SistemaCervejaContext
    {
        public int IdContador { get; set; } = 1;
        public List<Cerveja> ListaDeCerveja { get; set; }

        public SistemaCervejaContext()
        {
            ListaDeCerveja = new List<Cerveja>();

            ListaDeCerveja.Add(new Cerveja() {Id = 1,  Nome = "Budweiser    ", Litros = 0.330, Alcool = 5,   Valor = 4.19 });
            ListaDeCerveja.Add(new Cerveja() {Id = 2,  Nome = "Stella Artois", Litros = 0.275, Alcool = 5,   Valor = 2.99 });
            ListaDeCerveja.Add(new Cerveja() {Id = 3,  Nome = "Colorado     ", Litros = 0.600, Alcool = 7,   Valor = 6.93 });
            ListaDeCerveja.Add(new Cerveja() {Id = 4,  Nome = "Original     ", Litros = 0.600, Alcool = 4.9, Valor = 5.49 });
            ListaDeCerveja.Add(new Cerveja() {Id = 5,  Nome = "Corona       ", Litros = 0.355, Alcool = 4.6, Valor = 4.99 });
            ListaDeCerveja.Add(new Cerveja() {Id = 6,  Nome = "Patagonia    ", Litros = 0.740, Alcool = 4.7, Valor = 11.13});
            ListaDeCerveja.Add(new Cerveja() {Id = 7,  Nome = "Quilmes      ", Litros = 0.970, Alcool = 4.9, Valor = 14.49});
            ListaDeCerveja.Add(new Cerveja() {Id = 8,  Nome = "Brahma       ", Litros = 0.355, Alcool = 5,   Valor = 3.09 });
            ListaDeCerveja.Add(new Cerveja() {Id = 9,  Nome = "Skol         ", Litros = 0.269, Alcool = 4.7, Valor = 2.49 });
            ListaDeCerveja.Add(new Cerveja() {Id = 10, Nome = "Martina      ", Litros = 0.600, Alcool = 4.2, Valor = 15.90});
        }
        public List<Cerveja> ListaCerveja { get { return ListaDeCerveja; } }
    }
}
