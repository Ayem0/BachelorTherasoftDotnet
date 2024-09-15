using Microsoft.AspNetCore.Identity;

namespace BachelorTherasoftDotnetDomain.Entities;

public class Role : IdentityRole
{
    public DateTime CreatedAt = DateTime.Now;
    public DateTime ?DeletedAt { get; set; }
    public DateTime ?ModifiedAt { get; set; }
}

