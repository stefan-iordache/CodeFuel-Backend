using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using CodeFuel.Models;

public class User : IdentityUser<int>
{
    public ICollection<Course> Courses { get; set; } = new List<Course>();
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}