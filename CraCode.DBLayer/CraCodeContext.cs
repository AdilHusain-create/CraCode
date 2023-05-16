using System.Data.Entity;
using CraCode.ModelLayer.Models;
//using System.Data.SqlClient;

namespace CraCode.DBLayer
{
    public class CraCodeContext : DbContext 
    {
        public CraCodeContext() : base("CCDB001")
        {
                            
        }
        // Here DbSet will be there whole DB tables will be created by EF

        public DbSet<Student> Students { get; set; }

        public DbSet<Professor> Professors { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Credentials> Credentials { get; set; }
    }
}
