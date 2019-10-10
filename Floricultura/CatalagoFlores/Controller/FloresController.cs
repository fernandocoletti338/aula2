using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalagoFlores.Model;

namespace CatalagoFlores.Controller
{
   public class FloresController
    {
        FloresContexDB contextDB = new FloresContexDB();

        public IQueryable<Flores> GetFlores()
        {
            return contextDB.Flor;
        }

        public void CadastrarFlor (Flores item)
        {
            contextDB.Flor.Add(item);
            contextDB.SaveChanges();
        }

    

        public List<Flores> RetornarFloresOrdenadoPorQuantidade()
        {
            //GetFlores().ToList().Where(p => p.Nome == "ORQUIDEA"); /// LISTA COM 10 MILHOES DE FLORES

            // GetFlores().Where(p => p.Nome == "ORQUIDEA").ToList(); // AQUI É SOMENTE UMA FLOR, PQ EU FILTREI ANTES.

            return GetFlores().OrderByDescending(p => p.Quantidade)./*aqui eu REALMENTE executo o select*/ToList(); 
        }
        public int RetornarOTotalDeFlores()
        {
            return GetFlores().Sum(p => p.Quantidade);
        }

    }
}
