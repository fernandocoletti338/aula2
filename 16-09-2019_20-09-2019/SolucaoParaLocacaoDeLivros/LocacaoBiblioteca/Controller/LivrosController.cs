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
            parametroLivro.Id = contextDB.IdContadorLivro++;
            contextDB.ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.FindAll(i => i.Ativo == true);
        }
        public void RemoverLivrosPorID(int identificandoIDLivro)
        {
           var idExiste = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificandoIDLivro);

            if (idExiste != null)
            {
                idExiste.Ativo = false;
            }
        }

    }
}
