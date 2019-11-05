using System;
using System.Collections.Generic;

namespace CadastroFinalWeb.Models
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string EMail { get; set; }
    }
}
