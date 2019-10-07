using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosDoEntity1.Model
{
    public class Aluno
    {
        [Key]//Primary Key identity (1,1),

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
