using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMigration.Model;


namespace CosoleMigration
{
    class Program
    {
        static MigrationContext db = new MigrationContext();

        static void Main(string[] args)
        {
            //iniciamos nossa base de dados
            db.Usuarios.ToList().ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}
