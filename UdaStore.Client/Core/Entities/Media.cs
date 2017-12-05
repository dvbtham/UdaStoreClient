using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Media
    {
        public Media()
        {
            CatalogCategory = new HashSet<Category>();
            CatalogProduct = new HashSet<Product>();
            CatalogProductMedia = new HashSet<ProductMedia>();
        }

        public long Id { get; set; }
        public string Caption { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public int MediaType { get; set; }

        public ICollection<Category> CatalogCategory { get; set; }
        public ICollection<Product> CatalogProduct { get; set; }
        public ICollection<ProductMedia> CatalogProductMedia { get; set; }
    }
}
