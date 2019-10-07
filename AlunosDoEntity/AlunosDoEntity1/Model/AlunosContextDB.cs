using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosDoEntity1.Model
{
   public class AlunosContextDB : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
    }
}
