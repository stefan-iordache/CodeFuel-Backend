namespace CodeFuel.Models;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public ICollection<Chapter> Chapters { get; set; } = null!;
    public ICollection<UserCourseProgress> UserCourseProgresses { get; set; } = null!;
}