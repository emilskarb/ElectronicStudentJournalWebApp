using ElectronicStudentJournal.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectronicStudentJournal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  //metoda umożliwia nam odpowiednią konfigurację (za pomocą api dostarczonego przez EntityFramework) struktur bazodanowych
        {
            base.OnModelCreating(modelBuilder);
            var StudentEntityBuilder = modelBuilder.Entity<Student>();     //deklarujemy na jakiej encji aktualnie pracujemy
            StudentEntityBuilder.ToTable("Students");
            StudentEntityBuilder.Property(p => p.FirstName).HasMaxLength(30).IsRequired(true);
            StudentEntityBuilder.Property(p => p.LastName).HasMaxLength(30).IsRequired(true);
            StudentEntityBuilder.Property(p => p.NumerTelefonu).HasMaxLength(11).IsRequired(false);
        }

        public DbSet<Student> Student { get; protected set; }   //kolekcja naszych struktur w bazie naych (odwoływanie do tabeli)



    }
}
