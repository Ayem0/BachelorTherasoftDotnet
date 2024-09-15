using System;
using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class WorkspaceRole : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public required string WorkspaceId { get; set; }
    public required string Name { get; set; }
}
