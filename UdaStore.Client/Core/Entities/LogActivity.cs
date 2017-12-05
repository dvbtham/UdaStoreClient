using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class LogActivity
    {
        public long Id { get; set; }
        public long ActivityTypeId { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public long EntityId { get; set; }
        public long EntityTypeId { get; set; }

        public LogActivityType ActivityType { get; set; }
    }
}
