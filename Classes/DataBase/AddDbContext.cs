using HireFire.Classes.Entities;
using Microsoft.EntityFrameworkCore;

namespace HireFire.Classes.DataBase;
public class AppDbContext : DbContext
{
    public DbSet<JobSeeker> JobSeekers { get; set; }
    public DbSet<Employer> Employers { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JobSeeker>(entity =>
        {
            entity.ToTable("jobseekers");

            entity.Property(e => e.Name)
                  .HasColumnName("name")
                  .HasMaxLength(100)
                  .IsRequired();

            entity.Property(e => e.City)
                  .HasColumnName("city")
                  .HasMaxLength(50);
            
            entity.Property(e => e.BirthDate)
                  .HasColumnName("birth_date")
                  .HasColumnType("date");

            entity.Property(e => e.Gender)
                  .HasColumnName("gender")
                  .HasMaxLength(1);

            entity.Property(e => e.Email)
                  .HasColumnName("email")
                  .HasMaxLength(100);

            entity.Property(e => e.Login)
                  .HasColumnName("login")
                  .HasMaxLength(50);

            entity.Property(e => e.PasswordHash)
                  .HasColumnName("password_hash")
                  .HasMaxLength(255);

            entity.Property(e => e.PhotoData)
                  .HasColumnName("photo_data")
                  .HasColumnType("bytea");

            entity.Property(e => e.Surname)
                  .HasColumnName("surname")
                  .HasMaxLength(100)
                  .IsRequired();

            entity.Property(e => e.Lastname)
                  .HasColumnName("lastname")
                  .HasMaxLength(100);
        });

        modelBuilder.Entity<Employer>(entity =>
        {
            entity.ToTable("employers");

            entity.Property(e => e.Name)
                  .HasColumnName("name")
                  .HasMaxLength(100)
                  .IsRequired();

            entity.Property(e => e.City)
                  .HasColumnName("city")
                  .HasMaxLength(50);

            entity.Property(e => e.BirthDate)
                  .HasColumnName("birth_date")
                  .HasColumnType("date");

            entity.Property(e => e.Gender)
                  .HasColumnName("gender")
                  .HasMaxLength(1);

            entity.Property(e => e.Email)
                  .HasColumnName("email")
                  .HasMaxLength(100);

            entity.Property(e => e.Login)
                  .HasColumnName("login")
                  .HasMaxLength(50);

            entity.Property(e => e.PasswordHash)
                  .HasColumnName("password_hash")
                  .HasMaxLength(255);

            entity.Property(e => e.PhotoData)
                  .HasColumnName("photo_data")
                  .HasColumnType("bytea");

            entity.Property(e => e.Surname)
                  .HasColumnName("surname")
                  .HasMaxLength(100)
                  .IsRequired();

            entity.Property(e => e.Lastname)
                  .HasColumnName("lastname")
                  .HasMaxLength(100);
        });
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HireFire_DB;Username=postgres;Password=277353");
    }
}