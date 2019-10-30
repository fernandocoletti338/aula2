using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistroDeImoveisWeb.Models
{
    public class MigrationContext : DbContext
    {
        public virtual DbSet<Proprietarios> Proprietarios { get; set; }

        public virtual DbSet<Imovel> Imoveis { get; set; }
    }
}