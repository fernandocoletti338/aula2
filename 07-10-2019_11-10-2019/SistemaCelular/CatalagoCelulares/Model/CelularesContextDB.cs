using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoCelulares.Model
{
    public class CelularesContextDB : DbContext
    {
        // definimos nossa primeira tabela no banco de dados
        public DbSet<Usuario> Usuarios { get; set; }
        // definimos nossa tabela de celulares
        public DbSet<Celular> Celulares { get; set; }

    }
}
