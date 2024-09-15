using System;

namespace BachelorTherasoftDotnetDomain.Entities;

public class Member
{
    public string Id = Guid.NewGuid().ToString();
    public required string UserId { get; set; }
}
