using CodeFuel.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFuel.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Chapter> Chapters { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Lesson> Lessons { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<UserCodeSubmission> UserCodeSubmissions { get; set; } = null!;
    public DbSet<UserCourseProgress> UserCourseProgresses { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=STEFAN-PC,1433;Database=CodeFuel;Integrated Security=sspi;TrustServerCertificate=true;");
    }
}