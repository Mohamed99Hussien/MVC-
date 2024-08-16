using Microsoft.EntityFrameworkCore;

namespace MVC_DB.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Dept> Departments { get; set; }
        public DbSet<INS> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Crs> Courses { get; set; }
        public DbSet<CrsRes> CrsResults { get; set; }
    }
}
//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        // Department to Instructor: One-to-Many
//        modelBuilder.Entity<Dept>()
//            .HasMany(d => d.Instructors)
//            .WithOne(i => i.Department)
//            .HasForeignKey(i => i.DeptId);

//        // Instructor to Course: Many-to-One
//        modelBuilder.Entity<INS>()
//            .HasOne(i => i.Courses)
//            .WithMany(c => c.CrsRes)
//            .HasForeignKey(i => i.CrsId);

//        // Course to CrsResults: One-to-Many
//        modelBuilder.Entity<Crs>()
//            .HasMany(c => c.CrsResults)
//            .WithOne(cr => cr.Courses)
//            .HasForeignKey(cr => cr.CrsId);

//        // CrsResults to Trainee: Many-to-One
//        modelBuilder.Entity<CrsRes>()
//            .HasOne(cr => cr.Trainee)
//            .WithMany(t => t.CrsResults)
//            .HasForeignKey(cr => cr.TraineeId);
//    }
//}



