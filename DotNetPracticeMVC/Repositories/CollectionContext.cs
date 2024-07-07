using DotNetPracticeMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetPracticeMVC.Repositories
{
    public class CollectionContext: DbContext
    {
        public DbSet<Employees> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectedString = "server=localhost;port=3306;username=root;password=root123;database=Employees";
            optionsBuilder.UseMySQL(connectedString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employees>(
                Entity =>
                {
                    Entity.HasKey(p=>p.Id);
                    Entity.Property(p => p.Name).IsRequired();
                    Entity.Property(p=>p.Job).IsRequired();
                    Entity.Property(p=>p.Salary).IsRequired();
                    Entity.Property(p=>p.Age).IsRequired();
                    Entity.Property(p=>p.AccountNo).IsRequired();
                }
                );
            modelBuilder.Entity<Employees>().ToTable("Employees");
        }

    }
}
