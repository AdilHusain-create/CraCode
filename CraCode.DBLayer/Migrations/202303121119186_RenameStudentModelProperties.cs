namespace CraCode.DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameStudentModelProperties : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "professor_ID" });
            DropIndex("dbo.Students", new[] { "Course_ID" });
            DropIndex("dbo.Students", new[] { "Professor_ID" });
            CreateIndex("dbo.Courses", "Professor_Id");
            CreateIndex("dbo.Students", "Course_Id");
            CreateIndex("dbo.Students", "Professor_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "Professor_Id" });
            DropIndex("dbo.Students", new[] { "Course_Id" });
            DropIndex("dbo.Courses", new[] { "Professor_Id" });
            CreateIndex("dbo.Students", "Professor_ID");
            CreateIndex("dbo.Students", "Course_ID");
            CreateIndex("dbo.Courses", "professor_ID");
        }
    }
}
