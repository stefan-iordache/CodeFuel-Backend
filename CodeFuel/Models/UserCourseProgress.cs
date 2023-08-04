using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFuel.Models;

public class UserCourseProgress
{
    public int Id { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    public int CompletedLessons { get; set; }
    public DateTime LastCompletedDate { get; set; }
}