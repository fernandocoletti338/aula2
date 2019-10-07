using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : DbContext //DbContext classe que contem todo os processos 
        //de conexão com o banco de dados listagem das tabelas 
        //seleçõ das informações
    { 
        public DbSet //palavra reservada para o Entity que indica que vamos definir uma tabela do noss bam=nco de dados
            <Pessoa> // aqui definimos nossa tabela pessoa ou seja especificamos qual de nosss classe será 
            //uma referencia de uma tabela no banco de dados. ela vai ao banco com o nome que definimos em nossa classe 
            ListaDePessoa { get; set; } // nesta parte liberamos nossa tabela para acessar
    }
}
