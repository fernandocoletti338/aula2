using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;


namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {
        CervejaContexDb contexDb = new CervejaContexDb(@"data source=(localdb)\MSSQLLocalDB;initial catalog=RevisandoEntity.Model.CervejaContextDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public void AddCerveja(Cerveja item)
        {
            contexDb.Cervejas.Add(item);
            contexDb.SaveChanges();
        }
    }
}
