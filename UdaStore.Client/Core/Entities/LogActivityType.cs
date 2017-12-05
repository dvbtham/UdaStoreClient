using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class LogActivityType
    {
        public LogActivityType()
        {
            ActivityLogActivity = new HashSet<LogActivity>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<LogActivity> ActivityLogActivity { get; set; }
    }
}
