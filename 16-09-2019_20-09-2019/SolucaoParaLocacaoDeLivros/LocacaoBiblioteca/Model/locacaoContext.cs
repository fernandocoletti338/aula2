using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{       /// <summary>
        /// metodo cotrutor que prepara nossa classe locacoacontext
        /// </summary>
    public class LocacaoContext
    {
        public int IdContadorLivro { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1;
        public LocacaoContext()
        {
            ListaDeLivros = new List<Livro>();

            ListaDeUsuarios = new List<Usuario>();

            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivro++,
                Nome = "meu primeiro livro"
            });

            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivro++,
                Nome = "meu segundo livro"
            });

            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivro++,
                Nome = "meu terceiro livro"

            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin"
            });

            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuarios++,
                Login = "nando",
                Senha = "1234"
            });
        }

        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }
    }


}
