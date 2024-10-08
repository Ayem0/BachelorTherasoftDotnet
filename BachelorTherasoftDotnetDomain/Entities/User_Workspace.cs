using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class User_Workspace : DefaultFields
{
    public required string UserId { get; set; }
    public required User User { get; set; }
    public required string WorkspaceId { get; set; }
    public required Workspace Workspace { get; set; }
}
