using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Widget
    {
        public Widget()
        {
            CoreWidgetInstance = new HashSet<WidgetInstance>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string CreateUrl { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string EditUrl { get; set; }
        public bool IsPublished { get; set; }
        public string Name { get; set; }
        public string ViewComponentName { get; set; }

        public ICollection<WidgetInstance> CoreWidgetInstance { get; set; }
    }
}
