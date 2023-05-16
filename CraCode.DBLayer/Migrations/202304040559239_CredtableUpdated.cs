namespace CraCode.DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CredtableUpdated : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Credentials");
            AddColumn("dbo.Credentials", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Credentials", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Credentials");
            AddPrimaryKey("dbo.Credentials", "Username");
        }
    }
}
