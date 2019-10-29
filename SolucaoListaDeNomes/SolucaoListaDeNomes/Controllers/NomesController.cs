using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using SolucaoListaDeNomes.Models;

namespace SolucaoListaDeNomes.Controllers
{
    public class NomesController : ApiController
    {
        List<PessoaObj> listaDePessoas = new List<PessoaObj>()
        {
            new PessoaObj(){ Nome = "Felipe", Idade = 27},
            new PessoaObj(){ Nome = "Nando", Idade = 31},
            new PessoaObj(){ Nome = "Giomar", Idade = 55},
            new PessoaObj(){ Nome = "Gabrieldson", Idade = 22},
            new PessoaObj(){ Nome = "Biomardson", Idade = 17},
            new PessoaObj(){ Nome = "Tiomario", Idade = 62},
            new PessoaObj(){ Nome = "Riomaro", Idade = 33 },
            new PessoaObj(){ Nome = "kiomassa", Idade = 25},
            new PessoaObj(){ Nome = "Ziomax", Idade = 64},
            new PessoaObj(){ Nome = "Miomara", Idade = 12}
        };

        public List<PessoaObj> Get()
        {
            return listaDePessoas;
        }

        public string Get(string nome, int idade)
        {
            return $"Olá {nome} sua idade é {idade}";
        }

        public PessoaObj Post(PessoaObj item)
        {
            listaDePessoas.Add(item);

            return item;
        }

    }
}