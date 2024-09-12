namespace BachelorTherasoftDotnetDomain.Entities
{
    internal class Comment : DefaultFields
    {
        public string Id = Guid.NewGuid().ToString();
        public required string UserId { get; set; }
        public required string MeetingId { get; set; }
        public required string Content { get; set; }
    }
}
