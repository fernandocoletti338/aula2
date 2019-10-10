using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metodos de usuarios do sistema
    /// </summary>
    public class UsuarioController
    {
        private LocacaoContext contextDB = new LocacaoContext();
        public UsuarioController()
        {
           
        }
        public bool LoginSistema(Usuario usuarios)
        {
            return RetornaListaDeUsuarios().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }

        /// <summary>
        /// metodo usado para adicionar usuario no sistema
        /// </summary>
        /// <param name="parametroUsuario">novo usuario que sera adicionado na lista</param>
        public void AdiconaUsuarios(Usuario parametroUsuario)
        {            
            contextDB.ListaDeUsuarios.Add(parametroUsuario);
            contextDB.SaveChanges();
        }
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //retorna agora somente uam lista de usuarios ativos com a expressão "Where(x => x.Ativo)"
            return contextDB.ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identificadoID">parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorID(int identificadoID)
        {
            //aqui usamos o metodo FirstOrDefault para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propredades dele e dasativar o registro
            var idExiste = contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID);

            if (idExiste != null)
            {
                idExiste.Ativo = false;
                contextDB.SaveChanges();
            }
        }
    }
}
