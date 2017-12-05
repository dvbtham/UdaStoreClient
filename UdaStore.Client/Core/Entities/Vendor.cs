using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Vendor
    {
        public Vendor()
        {
            CoreUser = new HashSet<User>();
        }

        public long Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string SeoTitle { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }

        public ICollection<User> CoreUser { get; set; }
    }
}
