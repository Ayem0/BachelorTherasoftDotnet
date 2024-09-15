using System;
using BachelorTherasoftDotnetDomain.Classes;

namespace BachelorTherasoftDotnetDomain.Entities;

public class Workspace : DefaultFields
{
        public string Id = Guid.NewGuid().ToString();
        public required string OwnerUserId { get; set; }
        public required string Name { get; set; }
}
