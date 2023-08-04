namespace CodeFuel.Models;

public class Lesson
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Content { get; set; } = null!;
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    public int? ChapterId { get; set; }
    public Chapter Chapter { get; set; } = null!;
}