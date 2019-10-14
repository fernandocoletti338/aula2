using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class Pessoa
    {
        [Key]// aqui temos uma anotação que indica que nossa chave é o campo logo a baixo da nossa anotoção
        //significa que ele é nossa chave primaria
        public int Id { get; set; }
        public String Nome { get; set; }
    }
}
