namespace CodeFuel.Models;

public class Chapter
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    public ICollection<Lesson> Lessons { get; set; } = null!;
}