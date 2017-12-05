using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class LocalizationResource
    {
        public long Id { get; set; }
        public long? CultureId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public LocalizationCulture Culture { get; set; }
    }
}
