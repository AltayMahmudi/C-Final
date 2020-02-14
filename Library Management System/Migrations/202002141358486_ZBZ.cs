namespace Library_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZBZ : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookInfoes",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        BookAuthor = c.String(),
                        BookPublicationName = c.String(),
                        BookPurchaseDate = c.DateTime(nullable: false, storeType: "date"),
                        BookPrice = c.String(),
                        BookQuantity = c.String(),
                    })
                .PrimaryKey(t => t.BookID);
            
            CreateTable(
                "dbo.OrderBooks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        QuantityLeft = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.BookInfoes", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        Money = c.Single(nullable: false),
                        BookReturnededDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        İd = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        BookInfos_BookID = c.Int(),
                    })
                .PrimaryKey(t => t.İd)
                .ForeignKey("dbo.BookInfoes", t => t.BookInfos_BookID)
                .Index(t => t.BookInfos_BookID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "BookInfos_BookID", "dbo.BookInfoes");
            DropForeignKey("dbo.OrderBooks", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderBooks", "BookId", "dbo.BookInfoes");
            DropIndex("dbo.Users", new[] { "BookInfos_BookID" });
            DropIndex("dbo.OrderBooks", new[] { "BookId" });
            DropIndex("dbo.OrderBooks", new[] { "OrderId" });
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderBooks");
            DropTable("dbo.BookInfoes");
        }
    }
}
