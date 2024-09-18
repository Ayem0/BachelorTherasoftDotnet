using Microsoft.AspNetCore.Identity;

namespace BachelorTherasoftDotnetDomain.Entities;

public class User : IdentityUser
{
    public string ?FirstName { get; set; }
    public string ?LastName { get; set; }
    public DateTime CreatedAt  { get; set; } = DateTime.Now;
    public DateTime ?DeletedAt { get; set; }
    public DateTime ?ModifiedAt { get; set; }
    public DateTime ?DisabledAt { get; set; }
    public List<User_Workspace> Workspaces { get; set; } = [];
    public List<WorkspaceRole> WorkspaceRoles { get; set; } = [];
    public List<Event> Events { get; set; } = [];
}

