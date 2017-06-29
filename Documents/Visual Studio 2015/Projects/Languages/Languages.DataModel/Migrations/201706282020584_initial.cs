namespace Languages.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Translations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnglishWord = c.String(),
                        SpanishWord = c.String(),
                        GermanWord = c.String(),
                        ItalianWord = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserLanguages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LanguageChoice = c.Int(nullable: false),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserLanguages", "Users_Id", "dbo.Users");
            DropIndex("dbo.UserLanguages", new[] { "Users_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.UserLanguages");
            DropTable("dbo.Translations");
        }
    }
}
