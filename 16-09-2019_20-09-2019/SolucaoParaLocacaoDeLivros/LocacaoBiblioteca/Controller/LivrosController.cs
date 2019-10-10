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
        private LocacaoContext contextDB = new LocacaoContext();
        /// <summary>
        /// metodo que adiciona livro em nossa lidta ja" instanciada" criada dentro do construtot
        /// </summary>
        /// <param name="parametroLivro">informa~ções do livro que vamos adicionar</param>
        public void AdicionarLivro(Livro parametroLivro)
        {

            contextDB.ListaDeLivros.Add(parametroLivro);//adicionamos o livro em nossa lista
            contextDB.SaveChanges();//salvamos no banco de dados
        }
        public IQueryable<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(i => i.Ativo == true);
        }
        public void RemoverLivrosPorID(int identificandoIDLivro)
        {
            var idExiste = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificandoIDLivro);

            if (idExiste != null)
            {
                idExiste.Ativo = false;
                contextDB.SaveChanges();
            }
        }
        public bool AtualizarLivro(Livro item)
        {
            var findLivro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == item.Id);

            if (findLivro != null)
            {
                findLivro.DataAlteracao = DateTime.Now;
                contextDB.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
