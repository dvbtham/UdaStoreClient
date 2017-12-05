using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Product
    {
        public Product()
        {
            CatalogProductAttributeValue = new HashSet<ProductAttributeValue>();
            CatalogProductCategory = new HashSet<ProductCategory>();
            CatalogProductLinkLinkedProduct = new HashSet<ProductLink>();
            CatalogProductLinkProduct = new HashSet<ProductLink>();
            CatalogProductMedia = new HashSet<ProductMedia>();
            CatalogProductOptionCombination = new HashSet<ProductOptionCombination>();
            CatalogProductOptionValue = new HashSet<ProductOptionValue>();
            OrdersCartItem = new HashSet<CartItem>();
            OrdersOrderItem = new HashSet<OrderItem>();
        }

        public long Id { get; set; }
        public long? BrandId { get; set; }
        public long? CreatedById { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool HasOptions { get; set; }
        public bool IsAllowToOrder { get; set; }
        public bool IsCallForPricing { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsPublished { get; set; }
        public bool IsVisibleIndividually { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset? PublishedOn { get; set; }
        public double? RatingAverage { get; set; }
        public int ReviewsCount { get; set; }
        public string SeoTitle { get; set; }
        public string ShortDescription { get; set; }
        public string Sku { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTimeOffset? SpecialPriceEnd { get; set; }
        public DateTimeOffset? SpecialPriceStart { get; set; }
        public string Specification { get; set; }
        public int? StockQuantity { get; set; }
        public long? ThumbnailImageId { get; set; }
        public long? UpdatedById { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
        public long? VendorId { get; set; }

        public Brand Brand { get; set; }
        public User CreatedBy { get; set; }
        public Media ThumbnailImage { get; set; }
        public User UpdatedBy { get; set; }
        public ICollection<ProductAttributeValue> CatalogProductAttributeValue { get; set; }
        public ICollection<ProductCategory> CatalogProductCategory { get; set; }
        public ICollection<ProductLink> CatalogProductLinkLinkedProduct { get; set; }
        public ICollection<ProductLink> CatalogProductLinkProduct { get; set; }
        public ICollection<ProductMedia> CatalogProductMedia { get; set; }
        public ICollection<ProductOptionCombination> CatalogProductOptionCombination { get; set; }
        public ICollection<ProductOptionValue> CatalogProductOptionValue { get; set; }
        public ICollection<CartItem> OrdersCartItem { get; set; }
        public ICollection<OrderItem> OrdersOrderItem { get; set; }
    }
}
