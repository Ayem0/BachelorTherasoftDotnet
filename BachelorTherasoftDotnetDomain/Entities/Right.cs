namespace BachelorTherasoftDotnetDomain.Entities
{
    internal class Right : DefaultFields
    {
        public string Id = Guid.NewGuid().ToString();
        public required string Name { get; set; }
    }
}
