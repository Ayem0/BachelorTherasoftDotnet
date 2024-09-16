using Microsoft.AspNetCore.Identity;

namespace BachelorTherasoftDotnetDomain.Entities;

public class User : IdentityUser
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime CreatedAt = DateTime.Now;
    public DateTime ?DeletedAt { get; set; }
    public DateTime ?ModifiedAt { get; set; }
    public DateTime ?DisabledAt { get; set; }

    public User(string FirstName, string LastName, string Email) {
        this.Email = Email;
        this.FirstName = FirstName;
        this.LastName = LastName;
    }

    public List<User_Workspace> Workspaces { get; set; } = [];
    public List<WorkspaceRole> WorkspaceRoles { get; set; } = [];
    public List<Event> Events { get; set; } = [];
}

