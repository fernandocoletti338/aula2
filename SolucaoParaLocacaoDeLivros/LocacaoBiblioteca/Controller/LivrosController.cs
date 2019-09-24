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
        private int IdContador = 0;
        public LivrosController()
        {
            ListaDeLivros = new List<Livro>();
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "meu primeiro livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "meu segundo livro"
            });
        }
        private List<Livro> ListaDeLivros { get; set; }
        /// <summary>
        /// metodo que adiciona livro em nossa lidta ja" instanciada" criada dentro do construtot
        /// </summary>
        /// <param name="parametroLivro">informa~ções do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = IdContador++;
            ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return ListaDeLivros;
        }
        public void RemoverLivrosPorID(int identificandoIDLivro)
        {
            ListaDeLivros.FirstOrDefault(x => x.Id == identificandoIDLivro).Ativo = false;
        }
    }
}
