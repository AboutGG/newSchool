using Microsoft.EntityFrameworkCore;

namespace ProgettoScuola.Models;

public class SchoolContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Registry> Registries { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Parent> Parents { get; set; }

    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Genera i Guid
        var studentUserIds = Enumerable.Range(0, 10).Select(_ => Guid.NewGuid()).ToList();
        var parentUserIds = Enumerable.Range(0, 10).Select(_ => Guid.NewGuid()).ToList();
        var studentIds = Enumerable.Range(0, 10).Select(_ => Guid.NewGuid()).ToList();
        var studentRegistryIds = Enumerable.Range(0, 10).Select(_ => Guid.NewGuid()).ToList();
        var parentRegistryIds = Enumerable.Range(0, 10).Select(_ => Guid.NewGuid()).ToList();
        var parentIds = Enumerable.Range(0, 10).Select(_ => Guid.NewGuid()).ToList();

        // Seed per la classe User
        for (int i = 0; i < 10; i++)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = studentUserIds[i], Username = $"StudentUser{i + 1}", Password = $"Password{i + 1}" },
                new User { Id = parentUserIds[i], Username = $"ParentUser{i + 1}", Password = $"Password{i + 1}" }
            );
        }

        // Seed per la classe Student
        for (int i = 0; i < 10; i++)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = studentIds[i], Classe = $"Classe{i + 1}", UserId = studentUserIds[i],
                    RegistryId = studentRegistryIds[i]
                }
            );
        }

        // Seed per la classe Registry
        for (int i = 0; i < 10; i++)
        {
            var month = (i % 12 + 1).ToString().PadLeft(2, '0');
            var day = (i % 28 + 1).ToString().PadLeft(2, '0');
            modelBuilder.Entity<Registry>().HasData(
                new Registry
                {
                    Id = studentRegistryIds[i], Name = $"NomeStudente{i + 1}", Surname = $"CognomeStudente{i + 1}",
                    Gender = i % 2 == 0 ? "M" : "F", Birth = DateOnly.Parse($"200{i}-{month}-{day}"),
                    Email = $"emailstudente{i + 1}@example.com", Address = $"IndirizzoStudente{i + 1}",
                    Telephone = $"+39 123 456 78{i + 1}0"
                },
                new Registry
                {
                    Id = parentRegistryIds[i], Name = $"NomeGenitore{i + 1}", Surname = $"CognomeGenitore{i + 1}",
                    Gender = i % 2 == 0 ? "M" : "F", Birth = DateOnly.Parse($"197{i}-{month}-{day}"),
                    Email = $"emailgenitore{i + 1}@example.com", Address = $"IndirizzoGenitore{i + 1}",
                    Telephone = $"+39 123 456 78{i + 1}0"
                }
            );
        }

        // Seed per la classe Parent
        for (int i = 0; i < 10; i++)
        {
            modelBuilder.Entity<Parent>().HasData(
                new Parent
                {
                    Id = parentIds[i], UserId = parentUserIds[i], RegistryId = parentRegistryIds[i],
                    StudentId = studentIds[i]
                }
            );
        }
    }


}