namespace SomaliNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Somalinews : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 20),
                        NewsContant = c.String(nullable: false),
                        NewsDate = c.DateTime(nullable: false),
                        Image = c.Binary(),
                        Side = c.String(nullable: false, maxLength: 20),
                        NewsReporter = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
        }
    }
}
