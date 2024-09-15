using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

internal class Zone : DefaultFields
{
    public string Id = Guid.NewGuid().ToString();
    public required string SiteId { get; set; }
    public required string Name { get; set; }
}

