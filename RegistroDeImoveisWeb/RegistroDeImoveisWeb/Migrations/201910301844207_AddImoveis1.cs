namespace RegistroDeImoveisWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImoveis1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Imovels");
            DropPrimaryKey("dbo.Proprietarios");
            AddColumn("dbo.Imovels", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Imovels", "Logradouro", c => c.String());
            AddColumn("dbo.Proprietarios", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Imovels", "Cep", c => c.String());
            AlterColumn("dbo.Proprietarios", "Nome", c => c.String());
            AddPrimaryKey("dbo.Imovels", "Id");
            AddPrimaryKey("dbo.Proprietarios", "Id");
            DropColumn("dbo.Imovels", "Logardouro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Imovels", "Logardouro", c => c.String());
            DropPrimaryKey("dbo.Proprietarios");
            DropPrimaryKey("dbo.Imovels");
            AlterColumn("dbo.Proprietarios", "Nome", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Imovels", "Cep", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Proprietarios", "Id");
            DropColumn("dbo.Imovels", "Logradouro");
            DropColumn("dbo.Imovels", "Id");
            AddPrimaryKey("dbo.Proprietarios", "Nome");
            AddPrimaryKey("dbo.Imovels", "Cep");
        }
    }
}
