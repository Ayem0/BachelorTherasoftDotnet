using Microsoft.AspNetCore.Identity;

namespace BachelorTherasoftDotnetDomain.Entities
{
    public class User : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime CresatedAt = DateTime.Now;
        public DateTime DeletedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DisabledAt { get; set; }
    }
}
