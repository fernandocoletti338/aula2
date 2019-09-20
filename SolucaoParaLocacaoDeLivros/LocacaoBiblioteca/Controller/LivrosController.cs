using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        public LivrosController()
        {
            Livros = new List<Livro>();

            Livros.Add(new Livro()
            {
                Nome = "meu primeiro livro"
            });
            Livros.Add(new Livro()
            {
                Nome = "meu segundo livro"
            });
        }
        public List<Livro> Livros { get; set; }
    }
}
