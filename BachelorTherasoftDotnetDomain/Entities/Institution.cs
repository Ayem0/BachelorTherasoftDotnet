using System;

namespace BachelorTherasoftDotnetDomain.Entities;

public class Institution : DefaultFields
{
        public string Id = Guid.NewGuid().ToString();
        public required string UserId { get; set; }
        public required string Name { get; set; }
}
