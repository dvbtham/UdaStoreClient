using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Entity
    {
        public long Id { get; set; }
        public long EntityId { get; set; }
        public long EntityTypeId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public EntityType EntityType { get; set; }
    }
}
