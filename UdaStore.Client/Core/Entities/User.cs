using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class User
    {
        public User()
        {
            CatalogProductCreatedBy = new HashSet<Product>();
            CatalogProductUpdatedBy = new HashSet<Product>();
            CmsPageCreatedBy = new HashSet<Page>();
            CmsPageUpdatedBy = new HashSet<Page>();
            CoreUserAddress = new HashSet<UserAddress>();
            CoreUserClaim = new HashSet<UserClaim>();
            CoreUserLogin = new HashSet<UserLogin>();
            CoreUserRole = new HashSet<UserRole>();
            CoreUserToken = new HashSet<UserToken>();
            OrdersCartItem = new HashSet<CartItem>();
            OrdersOrder = new HashSet<Order>();
            ReviewsReview = new HashSet<Review>();
        }

        public long Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public long? DefaultBillingAddressId { get; set; }
        public long? DefaultShippingAddressId { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string FullName { get; set; }
        public bool IsDeleted { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public string NormalizedEmail { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string SecurityStamp { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
        public Guid UserGuid { get; set; }
        public string UserName { get; set; }
        public long? VendorId { get; set; }

        public UserAddress DefaultBillingAddress { get; set; }
        public UserAddress DefaultShippingAddress { get; set; }
        public Vendor Vendor { get; set; }
        public ICollection<Product> CatalogProductCreatedBy { get; set; }
        public ICollection<Product> CatalogProductUpdatedBy { get; set; }
        public ICollection<Page> CmsPageCreatedBy { get; set; }
        public ICollection<Page> CmsPageUpdatedBy { get; set; }
        public ICollection<UserAddress> CoreUserAddress { get; set; }
        public ICollection<UserClaim> CoreUserClaim { get; set; }
        public ICollection<UserLogin> CoreUserLogin { get; set; }
        public ICollection<UserRole> CoreUserRole { get; set; }
        public ICollection<UserToken> CoreUserToken { get; set; }
        public ICollection<CartItem> OrdersCartItem { get; set; }
        public ICollection<Order> OrdersOrder { get; set; }
        public ICollection<Review> ReviewsReview { get; set; }
    }
}
