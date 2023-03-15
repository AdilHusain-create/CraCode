namespace CraCode.DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationtoStudentModel : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Students", new[] { "course_ID" });
            DropIndex("dbo.Students", new[] { "professor_ID" });
            AddColumn("dbo.Students", "Username", c => c.String(nullable: false));
            AddColumn("dbo.Students", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Professors", "firstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Professors", "lastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Professors", "emailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Professors", "dateOfBirth", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "firstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "lastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "emailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "dateOfBirth", c => c.String(nullable: false));
            CreateIndex("dbo.Students", "Course_ID");
            CreateIndex("dbo.Students", "Professor_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "Professor_ID" });
            DropIndex("dbo.Students", new[] { "Course_ID" });
            AlterColumn("dbo.Students", "dateOfBirth", c => c.String());
            AlterColumn("dbo.Students", "emailAddress", c => c.String());
            AlterColumn("dbo.Students", "lastName", c => c.String());
            AlterColumn("dbo.Students", "firstName", c => c.String());
            AlterColumn("dbo.Professors", "dateOfBirth", c => c.String());
            AlterColumn("dbo.Professors", "emailAddress", c => c.String());
            AlterColumn("dbo.Professors", "lastName", c => c.String());
            AlterColumn("dbo.Professors", "firstName", c => c.String());
            DropColumn("dbo.Students", "Password");
            DropColumn("dbo.Students", "Username");
            CreateIndex("dbo.Students", "professor_ID");
            CreateIndex("dbo.Students", "course_ID");
        }
    }
}
