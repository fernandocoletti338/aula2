using EntityClassEX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClassEX.Controller
{
    public class AlunoController
    {
        EntityAlunoContext context = new EntityAlunoContext();
        public IQueryable<Aluno> GetAlunos()
        {
            return context.Alunos;
        }
    }
}
