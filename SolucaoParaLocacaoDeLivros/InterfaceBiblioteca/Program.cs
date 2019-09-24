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
        static LivrosController livrosController = new LivrosController();

        static UsuarioController usuarioController = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de locação de livro 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e Senha inválidos");

            MostraMenuSistema();


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
                Console.WriteLine("1 - Listar Usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livros");
                Console.WriteLine("4 - Trocar Usuario");
                Console.WriteLine("5 - Cadastrar Usuarios");
                Console.WriteLine("6 - Remover Usuario");
                Console.WriteLine("7 - Remover Livro");
                Console.WriteLine("0 - Sair");

                //aqui vamos pegar o numero digitado 
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());

                //executar proxima função

                switch (menuEscolhido)
                {
                    case 1:
                        MostrarUsuarios();
                        break;
                    case 2:
                        MostrarLivro();
                        break;
                    case 3:
                        AdicionarLivro();
                        break;
                    case 4:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e Senha inválidos");
                        break;
                    case 5:
                        AdicionarUsuario();
                        break;
                    case 6:
                        RemoverUsuarioPeloID();
                        break;
                    default:
                        break;
                }
            }
            //MostraMenuSistema();
        }
        private static void RemoverUsuarioPeloID()
        {
            Console.WriteLine("Remover o Ususario pelo ID no sistema");
            //metodo que mostra os usuarios criado anteriormente para facilitar
            MostrarUsuarios();

            Console.WriteLine("Informe o ID para desativar do sistema:");
            var usuarioID = int.Parse(Console.ReadLine());

            //aqui chammos RemoverUsuarioPorId da nossa classe que controla os usuarios do sistema
            usuarioController.RemoverUsuarioPorID(usuarioID);

            Console.WriteLine("Usuario desativado com sucesso");
            Console.ReadKey();
        }
        private static void AdicionarUsuario()
        {
            Console.WriteLine("Cadastrar usuario dentro do sistema");
            Console.WriteLine("Informe o nome do Login para cadastrar:");
            var nomeDoUsuario = Console.ReadLine();
            Console.WriteLine("Informe uma senha para o Login digitado:");
            var senhaDoUsuario = Console.ReadLine();
            usuarioController.AdiconaUsuarios(new Usuario()
            {
                Login = nomeDoUsuario,
                Senha = senhaDoUsuario

            });
            Console.WriteLine("Usuario cadastrado com sucesso!");
            Console.ReadKey();
        }
        /// <summary>
        /// metodo que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            //identificamos que o mesmo esta na parte de cadastro deo livros do sistema
            Console.WriteLine("cadastrar livro dentro do sistema");
            //informamos que para dar continuidade ele deve informar um nome para o livro
            Console.WriteLine("Nome do livro para cadastro");
            //obtemos essa informação do usuario
            var nomeDoLivro = Console.ReadLine();
            //"livrosController" livros controle e nosso "objeto" em memoria
            //com isso temos disponivei ferramentas que ajudam a realizar as tarefas
            //como adicionar um  item a nossa lista de livros
            livrosController.AdicionarLivro(new Livro()
            {
                //aqui " atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
                //com sinal de apenas um"=" temos atribuição, passagem valor
                Nome = nomeDoLivro
            });
            //indico que finalizamos o processo de cadastro de livro, assim o usuario ja sabe
            //que o mesmo foi realizado e sem erros
            Console.WriteLine("Livro cadastrado com sucesso!");
            //readkey apenas para ele visualize essa informação
            Console.ReadKey();

        }
        private static void MostrarUsuarios()
        {
            usuarioController.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"Id:{i.Id} Login usuario:{i.Login}"));
            Console.ReadKey();

        }

        private static void MostrarLivro()
        {
            livrosController.RetornaListaDeLivros().ForEach(i => Console.WriteLine($"Id:{i.Id} Nome do livro:{i.Nome}"));

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
           
            Usuario usuario = new Usuario();

            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;

            return usuarioController.LoginSistema(usuario);

        }


    }
}
