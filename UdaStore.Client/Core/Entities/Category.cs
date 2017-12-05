using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Category
    {
        public Category()
        {
            CatalogProductCategory = new HashSet<ProductCategory>();
            InverseParent = new HashSet<Category>();
        }

        public long Id { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public bool PinToMenu { get; set; }
        public string SeoTitle { get; set; }
        public long? ThumbnailImageId { get; set; }

        public Category Parent { get; set; }
        public Media ThumbnailImage { get; set; }
        public ICollection<ProductCategory> CatalogProductCategory { get; set; }
        public ICollection<Category> InverseParent { get; set; }
    }
}
