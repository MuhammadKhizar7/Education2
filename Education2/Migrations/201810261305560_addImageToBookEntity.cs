namespace Education2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addImageToBookEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "ImageUrl", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Mobile", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Mobile", c => c.Int(nullable: false));
            DropColumn("dbo.Books", "ImageUrl");
        }
    }
}
