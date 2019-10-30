namespace RegistroDeImoveisWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistroDeImoveisWeb.Models.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RegistroDeImoveisWeb.Models.MigrationContext context)
        {
            context.Proprietarios.AddOrUpdate(x => x.Nome, new Models.Proprietarios()
            {
                Nome = "Fernando",
                DataNascimento = DateTime.Parse("01/01/2019"),
                Email = "teste@teste.com.br"
            });

            context.SaveChanges();

             var prorpietarioId = context.Proprietarios.FirstOrDefault(x => x.Nome == "Fernando").Id;

             context.Imoveis.AddOrUpdate(x => x.Cep, new Models.Imovel()
             {
                 Cep = "89056-550",
                 Logradouro = "Lothar Gebien",
                 Numero = 64,
                 Bairro = "Fortaleza",
                 Municipio = "Blumenau",
                 ProprietarioId = prorpietarioId
             });

             context.SaveChanges();
        }
    }
}
