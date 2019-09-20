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
                Login = "admin",
                    Senha = "admin"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "livro",
                Senha = "livro"
            });
        }
        public bool LoginSistema(Usuario usuarios)
        {
            return ListaDeUsuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }
        public List<Usuario> ListaDeUsuarios { get; set; }
    }
}
