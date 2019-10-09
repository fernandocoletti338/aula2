using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoCelulares.Model
{
    // deixar a classi publica
    public class ControleUsuario
    {
        // definimos o campo com o valor default "true" para nossos registros
        public bool Ativo { get; set; } = true;
        //  definimos 0 para o usuario criado pelo sistema sem usuario logado
        public int UsuarioCriacao { get; set; } = 0;
        // definimos para alteração do sistema qdo não logado usuario 0
        public int UsuarioAlteracao { get; set; } = 0;
        //setamos nossa data de criacao para data atal pela classe datetime
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

    }
}
