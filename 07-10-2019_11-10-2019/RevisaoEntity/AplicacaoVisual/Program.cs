using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisandoEntity.Model;
using RevisandoEntity.Controller;

namespace AplicacaoVisual
{
    class Program
    {
        // setar a aplicação visual para startar o projeto
        // vamos adicionar EntityFramework ao nosso projeto console
        //colocar em nosso usin o system.data.entity
        //adicionar a referencia da nossa class library

        //  static CervejaContextDB cerveja = new CervejaContextDB();
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            //cerveja.Cervejas.Add(new Cerveja() { Nome = "Golimar" });

            //cerveja.Cervejas.ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));
            cerveja.AddCerveja(new Cerveja() { Nome = "Cerveja Skol" });

            cerveja.GetCervejas().ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}
