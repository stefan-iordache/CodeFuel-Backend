using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFuel.Models;

public class UserCodeSubmission
{
    public int Id { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int LessonId { get; set; }
    public Lesson Lesson { get; set; } = null!;
    public string Code { get; set; } = null!;
    public DateTime SubmittedDate { get; set; }
}
