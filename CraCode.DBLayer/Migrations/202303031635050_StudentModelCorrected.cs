namespace CraCode.DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentModelCorrected : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "courseID_ID", newName: "course_ID");
            RenameColumn(table: "dbo.Students", name: "professorID_ID", newName: "professor_ID");
            RenameIndex(table: "dbo.Students", name: "IX_courseID_ID", newName: "IX_course_ID");
            RenameIndex(table: "dbo.Students", name: "IX_professorID_ID", newName: "IX_professor_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Students", name: "IX_professor_ID", newName: "IX_professorID_ID");
            RenameIndex(table: "dbo.Students", name: "IX_course_ID", newName: "IX_courseID_ID");
            RenameColumn(table: "dbo.Students", name: "professor_ID", newName: "professorID_ID");
            RenameColumn(table: "dbo.Students", name: "course_ID", newName: "courseID_ID");
        }
    }
}
