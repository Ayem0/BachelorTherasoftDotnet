using System.Reflection.Metadata.Ecma335;

namespace BachelorTherasoftDotnetDomain.Entities
{
    internal class Site : DefaultFields
    {
        public string Id = Guid.NewGuid().ToString();
        public required string Name { get; set; }
    }
}
