using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{       /// <summary>
        /// metodo cotrutor que prepara nossa classe locacoacontext
        /// </summary>
    public class LocacaoContext : DbContext
    {

        public LocacaoContext()
        {

        }
        
        public DbSet<Livro> ListaDeLivros { get; set; }
        public DbSet<Usuario> ListaDeUsuarios { get; set; }

    }


}
