using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClassEX.Model
{
    public class EntityAlunoContext : DbContext
    {
        public DbSet<Aluno> Alunos {get; set;}
    }
}
