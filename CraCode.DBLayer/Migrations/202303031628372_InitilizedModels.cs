namespace CraCode.DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitilizedModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        courseName = c.String(),
                        type = c.String(),
                        professor_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Professors", t => t.professor_ID)
                .Index(t => t.professor_ID);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        experienceInYears = c.String(),
                        expertise = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        emailAddress = c.String(),
                        mobileNumber = c.Int(nullable: false),
                        dateOfBirth = c.String(),
                        gender = c.String(),
                        city = c.String(),
                        qualification = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        college = c.String(),
                        profession = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        emailAddress = c.String(),
                        mobileNumber = c.Int(nullable: false),
                        dateOfBirth = c.String(),
                        gender = c.String(),
                        city = c.String(),
                        qualification = c.String(),
                        courseID_ID = c.Int(),
                        professorID_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.courseID_ID)
                .ForeignKey("dbo.Professors", t => t.professorID_ID)
                .Index(t => t.courseID_ID)
                .Index(t => t.professorID_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "professorID_ID", "dbo.Professors");
            DropForeignKey("dbo.Students", "courseID_ID", "dbo.Courses");
            DropForeignKey("dbo.Courses", "professor_ID", "dbo.Professors");
            DropIndex("dbo.Students", new[] { "professorID_ID" });
            DropIndex("dbo.Students", new[] { "courseID_ID" });
            DropIndex("dbo.Courses", new[] { "professor_ID" });
            DropTable("dbo.Students");
            DropTable("dbo.Professors");
            DropTable("dbo.Courses");
        }
    }
}
