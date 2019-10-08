namespace DLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 30),
                        publishDay = c.String(maxLength: 30),
                        rating = c.Int(),
                        GenreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Genre", t => t.GenreID)
                .Index(t => t.GenreID);
            
            CreateTable(
                "dbo.comments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        message = c.String(maxLength: 200),
                        bookID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.UserID)
                .ForeignKey("dbo.Books", t => t.bookID)
                .Index(t => t.bookID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(maxLength: 20),
                        password = c.String(maxLength: 7),
                        mail = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "GenreID", "dbo.Genre");
            DropForeignKey("dbo.comments", "bookID", "dbo.Books");
            DropForeignKey("dbo.comments", "UserID", "dbo.Users");
            DropIndex("dbo.comments", new[] { "UserID" });
            DropIndex("dbo.comments", new[] { "bookID" });
            DropIndex("dbo.Books", new[] { "GenreID" });
            DropTable("dbo.Genre");
            DropTable("dbo.Users");
            DropTable("dbo.comments");
            DropTable("dbo.Books");
        }
    }
}
