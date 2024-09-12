namespace BachelorTherasoftDotnetDomain.Entities
{
    internal class Client : DefaultFields
    {
        public string Id = Guid.NewGuid().ToString();
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Adress { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
