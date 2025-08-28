using ElectronicStudentJournal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ElectronicStudentJournal.Data
{
    public class ApplicationDbContext :  IdentityDbContext 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  //metoda umożliwia nam odpowiednią konfigurację (za pomocą api dostarczonego przez EntityFramework) struktur bazodanowych
        {
            base.OnModelCreating(modelBuilder);
            var StudentEntityBuilder = modelBuilder.Entity<StudentModel>();     //deklarujemy na jakiej encji aktualnie pracujemy
            StudentEntityBuilder.ToTable("Students");
            StudentEntityBuilder.Property(p => p.FirstName).HasMaxLength(30).IsRequired(true);
            StudentEntityBuilder.Property(p => p.LastName).HasMaxLength(30).IsRequired(true);
            StudentEntityBuilder.Property(p => p.PhoneNumber).HasMaxLength(11).IsRequired(false);
            StudentEntityBuilder.HasKey(p => p.StudentId);
        }

        public DbSet<StudentModel> Students { get; protected set; }   //kolekcja naszych struktur w bazie naych (odwoływanie do tabeli)
        public DbSet<Grade> Grades { get; protected set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost;Database=JournallDb; Trusted_Connection=True; TrustServerCertificate=True;");
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=JournallDb; Trusted_Connection=True;");
        //}

    }
}
