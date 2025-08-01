using Microsoft.EntityFrameworkCore;

namespace ElectronicStudentJournal.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<TeachingAssignment> TeachingAssignments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Grade>()
                .HasOne(g => g.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Grade>()
                .HasOne(g => g.TeachingAssignment)
                .WithMany(t => t.Grades)
                .HasForeignKey(g => g.TeachingAssignmentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TeachingAssignment>()
                .HasOne(t => t.Teacher)
                .WithMany(t => t.TeachingAssignments)
                .HasForeignKey(t => t.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeachingAssignment>()
                .HasOne(t => t.Subject)
                .WithMany(s => s.TeachingAssignments)
                .HasForeignKey(t => t.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeachingAssignment>()
                .HasOne(t => t.Class)
                .WithMany(c => c.TeachingAssignments)
                .HasForeignKey(t => t.ClassId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Student>()
    .HasOne(s => s.User)
    .WithOne()
    .HasForeignKey<Student>(s => s.UserId)
    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.User)
                .WithOne()
                .HasForeignKey<Teacher>(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Admin>()
                .HasOne(a => a.User)
                .WithOne()
                .HasForeignKey<Admin>(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
