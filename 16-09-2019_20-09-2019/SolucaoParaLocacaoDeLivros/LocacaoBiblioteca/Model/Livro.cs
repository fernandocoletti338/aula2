using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LocacaoBiblioteca.Model
{
    public class Livro : ControleDeUsuariosLivro
    {
        [Key]// definindo como primary key (1,1) 
        public int Id { get; set; }

        [Required]//é para obrigar a colocar o Login ou na linha de baixo seria a senha
                  // se não tiver o campo não é obrigatorio preencher
        [MaxLength(50)]//delimitamos um tamanho maximo de caracteres pra o campo string
        public string Nome { get; set; }
    }
}
