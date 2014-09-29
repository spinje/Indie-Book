namespace Indie_Book.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author_AuthorID = c.Int(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Authors", t => t.Author_AuthorID)
                .Index(t => t.Author_AuthorID);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        BookID = c.Int(nullable: false),
                        Contents = c.String(),
                        ReviewerEmail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .Index(t => t.BookID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "BookID", "dbo.Books");
            DropForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Reviews", new[] { "BookID" });
            DropIndex("dbo.Books", new[] { "Author_AuthorID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Authors");
            DropTable("dbo.Books");
        }
    }
}
