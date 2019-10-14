using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClassEX.Model;
using EntityClassEX.Controller;

namespace InterfaceAlunos
{
    class Program
    {
        static AlunoController alunos = new AlunoController();
        static void Main(string[] args)
        {
            alunos.GetAlunos().T
        }
    }
}
