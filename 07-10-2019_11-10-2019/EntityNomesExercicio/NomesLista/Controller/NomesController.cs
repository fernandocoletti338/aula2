using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NomesLista.Model;

namespace NomesLista.Controller
{
    public class NomesController
    {
        NomesContext context = new NomesContext();

        public IQueryable<Nomes> GetNomes()
        {
            return context.Nomes;
        }

        public void InserirNomes(Nomes item)
        {
            context.Nomes.Add(item);
            context.SaveChanges();
        }
    }
}
