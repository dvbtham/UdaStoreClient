using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Brand
    {
        public Brand()
        {
            CatalogProduct = new HashSet<Product>();
        }

        public long Id { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public string Name { get; set; }
        public string SeoTitle { get; set; }

        public ICollection<Product> CatalogProduct { get; set; }
    }
}
