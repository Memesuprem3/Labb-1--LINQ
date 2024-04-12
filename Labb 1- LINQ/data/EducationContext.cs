using Labb_1__LINQ.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb_1__LINQ.data
{
    internal class EducationContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = DESKTOP-1IK4QMP;Initial Catalog = LINQDB;Integrated Security=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherID = 1, Name = "Anna Svensson" },
                new Teacher { TeacherID = 2, Name = "Lars Larsson" },
                new Teacher { TeacherID = 3, Name = "Jonas Qvist" },
                new Teacher { TeacherID = 4, Name = "Tina Ahlström" }
            );

            
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, Code = "SUT23" },
                new Course { CourseId = 2, Code = "SUT24" },
                new Course { CourseId = 3, Code = "DAT23" },
                new Course { CourseId = 4, Code = "DAT24" }
            );

            
            modelBuilder.Entity<Subject>().HasData(
                new Subject { SubjectID = 1, Name = "Avancerad.net", TeacherId = 1 },
                new Subject { SubjectID = 2, Name = "Matematik", TeacherId = 2 },
                new Subject { SubjectID = 3, Name = "Programmering1", TeacherId = 3 },
                new Subject { SubjectID = 4, Name = "Programmering2", TeacherId = 4 }
            );

            
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "Erik Karlsson", TeacherId = 1, CourseId = 1 },
                new Student { StudentId = 2, Name = "Sara Eriksson", TeacherId = 2, CourseId = 4 },
                new Student { StudentId = 3, Name = "Wilma Sandström", TeacherId = 2, CourseId = 3 },
                new Student { StudentId = 4, Name = "Adrian Scholl", TeacherId = 2, CourseId = 1 },
                new Student { StudentId = 5, Name = "Åke Sjögren", TeacherId = 4, CourseId =  1},
                new Student { StudentId = 6, Name = "Love Larsson", TeacherId = 4, CourseId = 4 }
            );
        }
    }
}
