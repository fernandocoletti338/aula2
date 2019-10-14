using AlunosDoEntity1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosDoEntity1.Controller
{
    public class AlunosController
    {
        //este novo objeto representa nosso banco de dados 
        AlunosContextDB contextDB = new AlunosContextDB();

        public IQueryable<Aluno> GetAlunos()
        {
            //retorna os alunos dentro do sistema
            return contextDB.Alunos;
        }
        public void AddAlunos (Aluno aluno)
        {
            contextDB.Alunos.Add(aluno);
            contextDB.SaveChanges();
        }
    }
}
