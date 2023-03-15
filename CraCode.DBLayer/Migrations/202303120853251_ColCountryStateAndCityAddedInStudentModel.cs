namespace CraCode.DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColCountryStateAndCityAddedInStudentModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Professors", "country", c => c.String(nullable: false));
            AddColumn("dbo.Professors", "State", c => c.String(nullable: false));
            AddColumn("dbo.Students", "country", c => c.String(nullable: false));
            AddColumn("dbo.Students", "State", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "State");
            DropColumn("dbo.Students", "country");
            DropColumn("dbo.Professors", "State");
            DropColumn("dbo.Professors", "country");
        }
    }
}
