using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class WidgetInstance
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string Data { get; set; }
        public int DisplayOrder { get; set; }
        public string HtmlData { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? PublishEnd { get; set; }
        public DateTimeOffset? PublishStart { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
        public long WidgetId { get; set; }
        public long WidgetZoneId { get; set; }

        public Widget Widget { get; set; }
        public WidgetZone WidgetZone { get; set; }
    }
}
