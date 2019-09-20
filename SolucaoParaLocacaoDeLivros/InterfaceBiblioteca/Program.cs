using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;


namespace InterfaceBiblioteca
{
    class Program
    {
        //instanciamos "carregamos"
        static LivrosController livros = new LivrosController();

        static UsuarioController usuarioController = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de locação de livro 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e Senha inválidos");

            MostraMenuSistema();



            Console.ReadKey();
        }
        /// <summary>
        /// Mostra no console o menu disponivel no sistema. 
        /// </summary>
        private static void MostraMenuSistema()
        {
            //iniciamos nossa variavel com o menor vaolor int possivel
            var menuEscolhido = int.MinValue;
            //aqui definimos se for diferente de 0 mantemos o sistema aberto se não finalizamos
            while (menuEscolhido != 0)
            {

                Console.Clear();
                Console.WriteLine("Informe seu Login e Senha para acessar o sitema:");

                Console.WriteLine("Menu Sistema");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livros");
                Console.WriteLine("4 - Trocar usuario");
                Console.WriteLine("0 - Sair");

                //aqui vamos pegar o numero digitado 
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                //executar proxima função

                switch (menuEscolhido)
                {
                    case 1:
                        Mostrausuarios();
                        break;
                    case 2:
                        MostrarLivro();
                        break;
                    case 3:
                        break;
                    case 4:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e Senha inválidos");
                        break;
                    default:
                        break;
                }
            }
            MostraMenuSistema();
        }
        private static void Mostrausuarios()
        {
            usuarioController.ListaDeUsuarios.ForEach(i => Console.WriteLine($"Login usuario:{i.Login}"));
            Console.ReadKey();
        }

        private static void MostrarLivro()
        {
            livros.Livros.ForEach(i => Console.WriteLine($"Nome do livro:{i.Nome}"));

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que realiza os procediemntos completos de Login dentro do sastema como solicitação de Login e Senha pelo 
        /// console assim como respctivas valições que o mesmo precisa para entrar no sistema 
        /// </summary>
        /// <returns>retorna verdadeiro quando o Login e Senha informados estiverem corretos</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();
            //aqui carregamos em memoria nosso controlador de usuarios
            UsuarioController usuarioController = new UsuarioController();

            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarioController.LoginSistema(usuario);

        }


    }
}
