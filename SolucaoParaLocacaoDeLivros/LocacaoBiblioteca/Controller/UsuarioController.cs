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
        //criando privado para impedir o programador de adicionar um ID ou alterar fara da Classe
        private int IdContador = 0;
        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Par realizar o login padrão use:
        ///  - Login: Adimin
        ///  - Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuario como parametro
        /// <returns>Retorna verdaddeiro qdo exixstir o usuario com este login e senha</returns>

        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();
            ListaDeUsuarios.Add(new Usuario()
            {
                //Adiciono o Id contador incrementando o mesmo com ele + 1 "++"
                Id = IdContador++,
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContador++,
                Login = "nando",
                Senha = "1234"
            });
        }
        public bool LoginSistema(Usuario usuarios)
        {
            return RetornaListaDeUsuarios().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }
        private List<Usuario> ListaDeUsuarios { get; set; }
        /// <summary>
        /// metodo usado para adicionar usuario no sistema
        /// </summary>
        /// <param name="parametroUsuario">novo usuario que sera adicionado na lista</param>
        public void AdiconaUsuarios(Usuario parametroUsuario)
        {
            parametroUsuario.Id = IdContador++;
            //adiciono o meu usarui a minha lista
            ListaDeUsuarios.Add(parametroUsuario);
        }
        public List<Usuario> RetornaListaDeUsuarios()
        {
            //retorna agora somente uam lista de usuarios ativos com a expressão "Where(x => x.Ativo)"
            return ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// metodo que desativa um registro de usuario cadastrado em noss lista
        /// </summary>
        /// <param name="identificadoID">parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorID(int identificadoID)
        {
            //aqui usamo o metodo FirstOrDefault para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propredades dele e dasativar o registro
            ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }
    }
}
