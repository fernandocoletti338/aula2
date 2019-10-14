using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesLista.Model
{
    public class NomesContext : DbContext
    {
        public DbSet<Nomes> Nomes { get; set; }
    }
}
