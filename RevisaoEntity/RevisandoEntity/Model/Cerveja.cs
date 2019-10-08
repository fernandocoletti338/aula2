using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{//deixar sempre publica a classe
    public class Cerveja
    {
        
        [Key]// chev primaria, auto incrementada
        public int Id { get; set; }

        [StringLength(50)]//quantidade de caracteres maxima para o campo "nome"
        [Required]//identifica que este campo é obrigatorio
        public string Nome { get; set; }
        [StringLength(30)]
        public string Tipo { get; set; }
        public double Toer { get; set; }
    }
}
