using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class SearchQuery
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string QueryText { get; set; }
        public int ResultsCount { get; set; }
    }
}
