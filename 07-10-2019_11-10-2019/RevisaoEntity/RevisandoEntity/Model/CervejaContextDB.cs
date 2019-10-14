using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //deixamos nossa classe public
    public class CervejaContextDB : DbContext//herdamos nossa classe DbContext 
                                             //que faz toda a parte do bancos de dados
    {
        //definimos nossa tabela dentro do banco de dados
        public DbSet<Cerveja> Cervejas { get; set; }
    }
}
