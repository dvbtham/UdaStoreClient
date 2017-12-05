using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Review
    {
        public long Id { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public long EntityId { get; set; }
        public long EntityTypeId { get; set; }
        public int Rating { get; set; }
        public string ReviewerName { get; set; }
        public int Status { get; set; }
        public string Title { get; set; }
        public long UserId { get; set; }

        public User User { get; set; }
    }
}
