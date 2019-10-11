using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeBicicleta.Model;

namespace CadastroDeBicicleta.Controller
{
   public class BicicletasController
    {
        BicicletaContextDB contexDB = new BicicletaContextDB();

        //Metodo lista as bicicletas ativas em nosso banco de dados
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return contexDB.Bicicletas.Where(b => b.Ativo == true);
        }

        //Metodo inseri novas bicicletas em nosso banco de dados
        public void InserirBicicleta (Bicicleta item)
        {
            contexDB.Bicicletas.Add(item);
            contexDB.SaveChanges();
        }

        //Metodo remove as bicicletas no banco de dados
        public bool RemoverBicicleta(int Id)
        {
            var bicicleta = contexDB.Bicicletas.FirstOrDefault(b => b.Id == Id);

            if (bicicleta == null)
                return false;

            bicicleta.Ativo = false;

            contexDB.SaveChanges();

            return true;
            
        }

        //Metodo que atualiza nossa bicleta dentro do banco de dados
        public bool AtualizaBicicleta(Bicicleta item)
        {
            var bicicleta = contexDB.Bicicletas.FirstOrDefault(b => b.Id == item.Id);

            if (bicicleta == null)
                return false;

            else bicicleta = item;
            bicicleta.DataAlteracao = DateTime.Now;

            contexDB.SaveChanges();

            return true;
            
        }
    }
}
