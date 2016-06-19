namespace EGE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Basic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Answer2", c => c.String());
            DropColumn("dbo.Questions", "Answer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "Answer", c => c.String());
            DropColumn("dbo.Questions", "Answer2");
        }
    }
}
