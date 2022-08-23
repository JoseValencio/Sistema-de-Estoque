namespace Pastelaria2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hamburger : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hamburgers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sabor = c.String(),
                        Tamanho = c.String(),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hamburgers");
        }
    }
}
