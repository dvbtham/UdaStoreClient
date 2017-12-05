using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class LocalizationCulture
    {
        public LocalizationCulture()
        {
            LocalizationResource = new HashSet<LocalizationResource>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<LocalizationResource> LocalizationResource { get; set; }
    }
}
