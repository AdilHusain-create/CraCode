namespace CraCode.DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGetUpdatePropertyInStudentModel : DbMigration
    {
        public override void Up()
        {
            Sql("alter table dbo.Students drop constraint [DF__Students__GetUpd__5AEE82B9];");
            AlterColumn("dbo.Students", "GetUpdateFlag", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "GetUpdateFlag", c => c.Int(nullable: false));
        }
    }
}
