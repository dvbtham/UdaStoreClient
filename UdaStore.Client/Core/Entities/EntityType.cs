using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class EntityType
    {
        public EntityType()
        {
            CoreEntity = new HashSet<Entity>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string RoutingAction { get; set; }
        public string RoutingController { get; set; }

        public ICollection<Entity> CoreEntity { get; set; }
    }
}
