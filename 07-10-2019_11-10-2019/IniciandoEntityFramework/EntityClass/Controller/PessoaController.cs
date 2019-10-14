using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        //realizo minha conexão com o banco de dados
        EntityContextDB contextDB = new EntityContextDB();

        public
            IQueryable // aqui temos nossa primeira interface com a CLASSE
                       //Iqueryble essa classe contem varios funcionalidades
                       //prontas para usar igual ao banco de dados com os selects
            <Pessoa> //definimos o tipo que ira retornar
            GetPessoas() //damos um nome ao nosso metodo
        {
            return contextDB.ListaDePessoa;//rertornamos nossa lista de pessoas
        }
        /// <summary>
        /// Metodo adicionar pessoa no banco de dados
        /// </summary>
        /// <param name="item">item pessoa</param>
        public void AddPessoa(Pessoa item)
        {
            contextDB//Nosso banco de dados
            .ListaDePessoa//nossa tabela pessoa
            .Add(item);//adicionamos o item

            contextDB.SaveChanges();//salvamos no banco
        }
    }
}
