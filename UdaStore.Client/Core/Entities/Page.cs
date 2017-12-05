using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Page
    {
        public long Id { get; set; }
        public string Body { get; set; }
        public long? CreatedById { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? PublishedOn { get; set; }
        public string SeoTitle { get; set; }
        public long? UpdatedById { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }

        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }
    }
}
