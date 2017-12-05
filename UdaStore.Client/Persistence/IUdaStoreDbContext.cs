using Microsoft.EntityFrameworkCore;
using UdaStore.Client.Core.Entities;

namespace UdaStore.Client.Persistence
{
    public interface IUdaStoreDbContext
    {
       DbSet<LogActivity> LogActivities { get; set; }
       DbSet<LogActivityType> LogActivityTypes { get; set; }
       DbSet<Brand> Brands { get; set; }
       DbSet<Category> Categories { get; set; }
       DbSet<Product> Products { get; set; }
       DbSet<ProductAttribute> ProductAttributes { get; set; }
       DbSet<ProductAttributeGroup> ProductAttributeGroups { get; set; }
       DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
       DbSet<ProductCategory> ProductCategories { get; set; }
       DbSet<ProductLink> ProductLinks { get; set; }
       DbSet<ProductMedia> ProductMediae { get; set; }
       DbSet<ProductOption> ProductOptions { get; set; }
       DbSet<ProductOptionCombination> ProductOptionCombinations { get; set; }
       DbSet<ProductOptionValue> ProductOptionValues { get; set; }
       DbSet<ProductTemplate> ProductTemplates { get; set; }
       DbSet<ProductTemplateProductAttribute> ProductTemplateProductAttributes { get; set; }
       DbSet<Page> Pages { get; set; }
       DbSet<Address> Addresses { get; set; }
       DbSet<AppSetting> AppSettings { get; set; }
       DbSet<Country> Countries { get; set; }
       DbSet<District> Districts { get; set; }
       DbSet<Entity> Entities { get; set; }
       DbSet<EntityType> EntityTypes { get; set; }
       DbSet<Media> Mediae { get; set; }
       DbSet<Role> Roles { get; set; }
       DbSet<RoleClaim> RoleClaims { get; set; }
       DbSet<StateOrProvince> StateOrProvinces { get; set; }
       DbSet<User> Users { get; set; }
       DbSet<UserAddress> UserAddresses { get; set; }
       DbSet<UserClaim> UserClaims { get; set; }
       DbSet<UserLogin> UserLogins { get; set; }
       DbSet<UserRole> UserRoles { get; set; }
       DbSet<UserToken> UserTokens { get; set; }
       DbSet<Widget> Widgets { get; set; }
       DbSet<WidgetInstance> WidgetInstances { get; set; }
       DbSet<WidgetZone> WidgetZones { get; set; }
       DbSet<LocalizationCulture> LocalizationCultures { get; set; }
       DbSet<LocalizationResource> LocalizationResources { get; set; }
       DbSet<CartItem> CartItems { get; set; }
       DbSet<Order> Orders { get; set; }
       DbSet<OrderAddress> OrderAddresses { get; set; }
       DbSet<OrderItem> OrderItems { get; set; }
       DbSet<Review> Reviews { get; set; }
       DbSet<SearchQuery> SearchQueries { get; set; }
       DbSet<Vendor> Vendors { get; set; }
    }
}
