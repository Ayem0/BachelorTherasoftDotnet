namespace BachelorTherasoftDotnetDomain.Entities
{
    internal class Room
    {
        public string Id = Guid.NewGuid().ToString();
        public required string Name { get; set; }
    }
}
