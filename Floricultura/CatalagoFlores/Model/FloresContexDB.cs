using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoFlores.Model
{
    public class FloresContexDB : DbContext
    {
        public DbSet<Flores> Flor { get; set; }

    }
}
