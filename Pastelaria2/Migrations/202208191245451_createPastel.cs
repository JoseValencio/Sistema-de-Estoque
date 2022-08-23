namespace Pastelaria2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createPastel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pastels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preco = c.Double(nullable: false),
                        Sabor = c.String(),
                        Tamanho = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pastels");
        }
    }
}
