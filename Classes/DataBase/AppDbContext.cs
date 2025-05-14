using HireFire.Classes.Entities;
using Microsoft.EntityFrameworkCore;

namespace HireFire.Classes.DataBase;
public class AppDbContext : DbContext
{
    public DbSet<JobSeeker> JobSeekers { get; set; }
    public DbSet<Employer> Employers { get; set; }
    public DbSet<Resume> Resumes{ get; set; }
    public DbSet<Vacancy> Vacancies{ get; set; }
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
        modelBuilder.Entity<Resume>(entity =>
        {
            entity.ToTable("resumes");

            entity.Property(e => e.JobseekerId)
                  .HasColumnName("jobseeker_id")
                  .HasColumnType("integer");

            entity.Property(e => e.Profession)
                  .HasColumnName("profession")
                  .HasMaxLength(100)
                  .IsRequired();

            entity.Property(e => e.Education)
                  .HasColumnName("education")
                  .HasMaxLength(100)
                  .IsRequired();

            entity.Property(e => e.SoftSkills)
                  .HasColumnName("soft_skills")
                  .HasColumnType("text");

            entity.Property(e => e.City)
                  .HasColumnName("city")
                  .HasMaxLength(50);

            entity.Property(e => e.Description)
                  .HasColumnName("description");

            entity.Property(e => e.Salary)
                  .HasColumnName("salary")
                  .HasColumnType("numeric");

            entity.Property(e => e.Experience)
                  .HasColumnName("experience")
                  .HasColumnType("integer");
        });

        modelBuilder.Entity<Vacancy>(entity =>
        {
            entity.ToTable("vacancies");

            entity.Property(e => e.EmployerId)
                  .HasColumnName("employer_id")
                  .HasColumnType("integer");

            entity.Property(e => e.Profession)
                  .HasColumnName("profession")
                  .HasMaxLength(100)
                  .IsRequired();

            entity.Property(e => e.Salary)
                  .HasColumnName("salary")
                  .HasColumnType("numeric");

            entity.Property(e => e.Experience)
                  .HasColumnName("experience")
                  .HasColumnType("integer");

            entity.Property(e => e.City)
                  .HasColumnName("city")
                  .HasMaxLength(50);
            
            entity.Property(e => e.CompanyName)
                  .HasColumnName("education")
                  .HasMaxLength(100)
                  .IsRequired();

            entity.Property(e => e.Description)
                  .HasColumnName("description");
        });
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HireFire_DB;Username=postgres;Password=277353");
    }
}