namespace Education2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChapterAndTopicEntities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Topics", "Description", c => c.String());
            DropColumn("dbo.Topics", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Topics", "Description", c => c.String());
            DropColumn("dbo.Topics", "Description");
        }
    }
}
