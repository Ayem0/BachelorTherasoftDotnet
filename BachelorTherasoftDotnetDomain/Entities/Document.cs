namespace BachelorTherasoftDotnetDomain.Entities
{
    internal class Document : DefaultFields
    {
        public string Id = Guid.NewGuid().ToString();
        public string ?Path { get; set; }
        public string ?MeetingId { get; set; }
        public required string ?UserId { get; set; }

    }
}
