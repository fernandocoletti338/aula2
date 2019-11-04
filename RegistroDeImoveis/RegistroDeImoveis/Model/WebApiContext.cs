using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroDeImoveis.Model
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {

        }
        public DbSet<ControleUsuario> ControleUsuarios { get; set; }
        public DbSet<Imoveis> Imoveis { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
    }
}
