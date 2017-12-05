using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class WidgetZone
    {
        public WidgetZone()
        {
            CoreWidgetInstance = new HashSet<WidgetInstance>();
        }

        public long Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public ICollection<WidgetInstance> CoreWidgetInstance { get; set; }
    }
}
