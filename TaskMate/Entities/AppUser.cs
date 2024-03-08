using Microsoft.AspNetCore.Identity;

namespace TaskMate.Entities;

public class AppUser : IdentityUser
{
    public string? Fullname { get; set; }
    public string UserName { get; set; } = null!;
    public bool isActive { get; set; }
    public DateTime RefreshTokenExpration { get; set; }
    public string? RefreshToken { get; set; }
}