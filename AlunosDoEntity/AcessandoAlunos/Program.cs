using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunosDoEntity1.Controller;
using AlunosDoEntity1.Model;

namespace AcessandoAlunos
{
    class Program
    {
        //inicio o meu controle de alunos
        static AlunosController aluno = new AlunosController();
        static void Main(string[] args)
        {
            aluno.AddAlunos(new Aluno()
            {
                Nome = "Fernando",
                Idade = 18
            });

            aluno.AddAlunos(new Aluno()
            {
                Nome = "Cleiton",
                Idade = 12
            });

            aluno.AddAlunos(new Aluno()
            {
                Nome = "Adriano",
                Idade = 23
            });
            //[aluno.GetAlunos()]aqui obtemos nossa lista de alunos da nossa controller
            //[ToList<Aluno>()]converto os alunos para uma lista
            //[ForEach(x => Console.WriteLine]mostrar os alunos
            aluno.GetAlunos().ToList<Aluno>().ForEach(x => Console.WriteLine($"Nome: {x.Nome} Idade: {x.Idade}"));

            Console.ReadKey();

        }
    }
}
