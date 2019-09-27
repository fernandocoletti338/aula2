using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    /// <summary>
    /// classe que contem as cervejas no sistema
    /// </summary>
    public class CervejaController
    {
        SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();

        public List<Cerveja> GetCarros()
        {
            return sistemaCervejaContext.ListaDeCerveja;
        }

        public void AddCerveja(Cerveja cerveja)
        {
            sistemaCervejaContext.ListaDeCerveja.Add(cerveja);
        }

        public double RetornaSomaValor()
        {
           return sistemaCervejaContext.ListaDeCerveja.Sum(i => i.Valor);
        }

        public double RetornaSomaLitros()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(i => i.Litros);
        }
    }
}
