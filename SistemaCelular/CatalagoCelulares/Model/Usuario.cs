using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoCelulares.Model
{
    // deixar publica
    public class Usuario : ControleUsuario
    {
        [Key] // definindo como primary key (1,1) 
        public int Id { get; set; }

        //delimitamos um tamanho maximo de caracteres pra o campo string
        [MaxLength(50)]
        public string  Nome { get; set; }
    

        [Required] //é para obrigar a colocar o Login ou na linha de baixo seria a senha
                   // se não tiver o campo não é obrigatorio preencher
        [MaxLength(30)]
        public string Login { get; set; }
       
        
        [Required]
        [MaxLength(30)]
        public string Senha { get; set; }

   

    }
}
