namespace RegistroDeImoveisWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImoveis : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovels",
                c => new
                    {
                        Cep = c.String(nullable: false, maxLength: 128),
                        Logardouro = c.String(),
                        Bairro = c.String(),
                        Municipio = c.String(),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        Proprietario = c.String(),
                    })
                .PrimaryKey(t => t.Cep);
            
            CreateTable(
                "dbo.Proprietarios",
                c => new
                    {
                        Nome = c.String(nullable: false, maxLength: 128),
                        DataNascimento = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Nome);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proprietarios");
            DropTable("dbo.Imovels");
        }
    }
}
