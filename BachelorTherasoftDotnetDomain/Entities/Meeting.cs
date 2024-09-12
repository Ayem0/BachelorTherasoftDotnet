namespace BachelorTherasoftDotnetDomain.Entities
{
    internal class Meeting : DefaultFields
    {
        public string Id = Guid.NewGuid().ToString();
        public required string ClientId { get; set; }
        public required string ProfessionalId { get; set; }
    }
}
