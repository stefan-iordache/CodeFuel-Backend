using System.ComponentModel.DataAnnotations.Schema;

public class UserRole
{
    public int Id { get; set; }
    public string RoleName { get; set; } = null!;
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; } = null!;
}