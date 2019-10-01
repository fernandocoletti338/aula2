using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeVendas.Model;

namespace SistemaDeVendas.Controller
{
    public class VendasController
    {
        SistemaDeVendasContext vendasContext = new SistemaDeVendasContext();

        public List<Venda> GetVendas(int mes = 0)
        {
            if (mes == 0)
                return vendasContext.ListaVendasPublica;
            else
                return vendasContext.ListaVendasPublica.FindAll(x => x.Data.Month == mes);
        }
    }
}
