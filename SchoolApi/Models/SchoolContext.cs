using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public virtual DbSet<CourseStudent> CourseStudent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=school;");
        
        public SchoolContext (DbContextOptions options) : base(options)
        {

        }

        public SchoolContext()
        {
            
        }

    }
}