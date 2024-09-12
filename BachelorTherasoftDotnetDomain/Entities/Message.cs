using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachelorTherasoftDotnetDomain.Entities
{
    internal class Message : DefaultFields
    {
        public string Id = Guid.NewGuid().ToString();
        public required string UserId { get; set; }
        public required string ConversationId { get; set; }
        public required string Content { get; set; }
    }
}
