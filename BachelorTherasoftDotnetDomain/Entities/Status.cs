﻿namespace BachelorTherasoftDotnetDomain.Entities
{
    internal class Status : DefaultFields
    {
        public string Id = Guid.NewGuid().ToString();
        public required string Name { get; set; }
    }
}
