using Microsoft.EntityFrameworkCore;
using UdaStore.Client.Core.Entities;

namespace UdaStore.Client.Persistence
{
    public partial class UdaStoreDbContext : DbContext, IUdaStoreDbContext
    {
        public UdaStoreDbContext(DbContextOptions<UdaStoreDbContext> options) : base(options) { }

        public virtual DbSet<LogActivity> LogActivities { get; set; }
        public virtual DbSet<LogActivityType> LogActivityTypes { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductAttributeGroup> ProductAttributeGroups { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductLink> ProductLinks { get; set; }
        public virtual DbSet<ProductMedia> ProductMediae { get; set; }
        public virtual DbSet<ProductOption> ProductOptions { get; set; }
        public virtual DbSet<ProductOptionCombination> ProductOptionCombinations { get; set; }
        public virtual DbSet<ProductOptionValue> ProductOptionValues { get; set; }
        public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }
        public virtual DbSet<ProductTemplateProductAttribute> ProductTemplateProductAttributes { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AppSetting> AppSettings { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<EntityType> EntityTypes { get; set; }
        public virtual DbSet<Media> Mediae { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleClaim> RoleClaims { get; set; }
        public virtual DbSet<StateOrProvince> StateOrProvinces { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAddress> UserAddresses { get; set; }
        public virtual DbSet<UserClaim> UserClaims { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserToken> UserTokens { get; set; }
        public virtual DbSet<Widget> Widgets { get; set; }
        public virtual DbSet<WidgetInstance> WidgetInstances { get; set; }
        public virtual DbSet<WidgetZone> WidgetZones { get; set; }
        public virtual DbSet<LocalizationCulture> LocalizationCultures { get; set; }
        public virtual DbSet<LocalizationResource> LocalizationResources { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderAddress> OrderAddresses { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<SearchQuery> SearchQueries { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogActivity>(entity =>
            {
                entity.ToTable("ActivityLog_Activity");

                entity.HasIndex(e => e.ActivityTypeId);

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.ActivityLogActivity)
                    .HasForeignKey(d => d.ActivityTypeId);
            });

            modelBuilder.Entity<LogActivityType>(entity =>
            {
                entity.ToTable("ActivityLog_ActivityType");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Catalog_Brand");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Catalog_Category");

                entity.HasIndex(e => e.ParentId);

                entity.HasIndex(e => e.ThumbnailImageId);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);

                entity.HasOne(d => d.ThumbnailImage)
                    .WithMany(p => p.CatalogCategory)
                    .HasForeignKey(d => d.ThumbnailImageId);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Catalog_Product");

                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.CreatedById);

                entity.HasIndex(e => e.ThumbnailImageId);

                entity.HasIndex(e => e.UpdatedById);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.CatalogProduct)
                    .HasForeignKey(d => d.BrandId);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.CatalogProductCreatedBy)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.ThumbnailImage)
                    .WithMany(p => p.CatalogProduct)
                    .HasForeignKey(d => d.ThumbnailImageId);

                entity.HasOne(d => d.UpdatedBy)
                    .WithMany(p => p.CatalogProductUpdatedBy)
                    .HasForeignKey(d => d.UpdatedById);
            });

            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.ToTable("Catalog_ProductAttribute");

                entity.HasIndex(e => e.GroupId);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CatalogProductAttribute)
                    .HasForeignKey(d => d.GroupId);
            });

            modelBuilder.Entity<ProductAttributeGroup>(entity =>
            {
                entity.ToTable("Catalog_ProductAttributeGroup");
            });

            modelBuilder.Entity<ProductAttributeValue>(entity =>
            {
                entity.ToTable("Catalog_ProductAttributeValue");

                entity.HasIndex(e => e.AttributeId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.CatalogProductAttributeValue)
                    .HasForeignKey(d => d.AttributeId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CatalogProductAttributeValue)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("Catalog_ProductCategory");

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CatalogProductCategory)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CatalogProductCategory)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductLink>(entity =>
            {
                entity.ToTable("Catalog_ProductLink");

                entity.HasIndex(e => e.LinkedProductId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.LinkedProduct)
                    .WithMany(p => p.CatalogProductLinkLinkedProduct)
                    .HasForeignKey(d => d.LinkedProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CatalogProductLinkProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductMedia>(entity =>
            {
                entity.ToTable("Catalog_ProductMedia");

                entity.HasIndex(e => e.MediaId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.CatalogProductMedia)
                    .HasForeignKey(d => d.MediaId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CatalogProductMedia)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductOption>(entity =>
            {
                entity.ToTable("Catalog_ProductOption");
            });

            modelBuilder.Entity<ProductOptionCombination>(entity =>
            {
                entity.ToTable("Catalog_ProductOptionCombination");

                entity.HasIndex(e => e.OptionId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.CatalogProductOptionCombination)
                    .HasForeignKey(d => d.OptionId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CatalogProductOptionCombination)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductOptionValue>(entity =>
            {
                entity.ToTable("Catalog_ProductOptionValue");

                entity.HasIndex(e => e.OptionId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.CatalogProductOptionValue)
                    .HasForeignKey(d => d.OptionId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CatalogProductOptionValue)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductTemplate>(entity =>
            {
                entity.ToTable("Catalog_ProductTemplate");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProductTemplateProductAttribute>(entity =>
            {
                entity.HasKey(e => new { e.ProductTemplateId, e.ProductAttributeId });

                entity.ToTable("Catalog_ProductTemplateProductAttribute");

                entity.HasIndex(e => e.ProductAttributeId);

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.CatalogProductTemplateProductAttribute)
                    .HasForeignKey(d => d.ProductAttributeId);

                entity.HasOne(d => d.ProductTemplate)
                    .WithMany(p => p.CatalogProductTemplateProductAttribute)
                    .HasForeignKey(d => d.ProductTemplateId);
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.ToTable("Cms_Page");

                entity.HasIndex(e => e.CreatedById);

                entity.HasIndex(e => e.UpdatedById);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.CmsPageCreatedBy)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.UpdatedBy)
                    .WithMany(p => p.CmsPageUpdatedBy)
                    .HasForeignKey(d => d.UpdatedById);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Core_Address");

                entity.HasIndex(e => e.CountryId);

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.StateOrProvinceId);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CoreAddress)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.CoreAddress)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.StateOrProvince)
                    .WithMany(p => p.CoreAddress)
                    .HasForeignKey(d => d.StateOrProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AppSetting>(entity =>
            {
                entity.ToTable("Core_AppSetting");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Core_Country");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("Core_District");

                entity.HasIndex(e => e.StateOrProvinceId);

                entity.HasOne(d => d.StateOrProvince)
                    .WithMany(p => p.CoreDistrict)
                    .HasForeignKey(d => d.StateOrProvinceId);
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.ToTable("Core_Entity");

                entity.HasIndex(e => e.EntityTypeId);

                entity.HasOne(d => d.EntityType)
                    .WithMany(p => p.CoreEntity)
                    .HasForeignKey(d => d.EntityTypeId);
            });

            modelBuilder.Entity<EntityType>(entity =>
            {
                entity.ToTable("Core_EntityType");
            });

            modelBuilder.Entity<Media>(entity =>
            {
                entity.ToTable("Core_Media");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Core_Role");

                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<RoleClaim>(entity =>
            {
                entity.ToTable("Core_RoleClaim");

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CoreRoleClaim)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<StateOrProvince>(entity =>
            {
                entity.ToTable("Core_StateOrProvince");

                entity.HasIndex(e => e.CountryId);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CoreStateOrProvince)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Core_User");

                entity.HasIndex(e => e.DefaultBillingAddressId);

                entity.HasIndex(e => e.DefaultShippingAddressId);

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.HasIndex(e => e.VendorId);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.DefaultBillingAddress)
                    .WithMany(p => p.CoreUserDefaultBillingAddress)
                    .HasForeignKey(d => d.DefaultBillingAddressId);

                entity.HasOne(d => d.DefaultShippingAddress)
                    .WithMany(p => p.CoreUserDefaultShippingAddress)
                    .HasForeignKey(d => d.DefaultShippingAddressId);

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.CoreUser)
                    .HasForeignKey(d => d.VendorId);
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.ToTable("Core_UserAddress");

                entity.HasIndex(e => e.AddressId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CoreUserAddress)
                    .HasForeignKey(d => d.AddressId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CoreUserAddress)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserClaim>(entity =>
            {
                entity.ToTable("Core_UserClaim");

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CoreUserClaim)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.ToTable("Core_UserLogin");

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CoreUserLogin)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("Core_UserRole");

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CoreUserRole)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CoreUserRole)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.ToTable("Core_UserToken");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CoreUserToken)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Widget>(entity =>
            {
                entity.ToTable("Core_Widget");
            });

            modelBuilder.Entity<WidgetInstance>(entity =>
            {
                entity.ToTable("Core_WidgetInstance");

                entity.HasIndex(e => e.WidgetId);

                entity.HasIndex(e => e.WidgetZoneId);

                entity.HasOne(d => d.Widget)
                    .WithMany(p => p.CoreWidgetInstance)
                    .HasForeignKey(d => d.WidgetId);

                entity.HasOne(d => d.WidgetZone)
                    .WithMany(p => p.CoreWidgetInstance)
                    .HasForeignKey(d => d.WidgetZoneId);
            });

            modelBuilder.Entity<WidgetZone>(entity =>
            {
                entity.ToTable("Core_WidgetZone");
            });

            modelBuilder.Entity<LocalizationCulture>(entity =>
            {
                entity.ToTable("Localization_Culture");
            });

            modelBuilder.Entity<LocalizationResource>(entity =>
            {
                entity.ToTable("Localization_Resource");

                entity.HasIndex(e => e.CultureId);

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.LocalizationResource)
                    .HasForeignKey(d => d.CultureId);
            });

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.ToTable("Orders_CartItem");

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrdersCartItem)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrdersCartItem)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Orders_Order");

                entity.HasIndex(e => e.BillingAddressId);

                entity.HasIndex(e => e.CreatedById);

                entity.HasIndex(e => e.ParentId);

                entity.HasIndex(e => e.ShippingAddressId);

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.OrdersOrderBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.OrdersOrder)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.OrdersOrderShippingAddress)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderAddress>(entity =>
            {
                entity.ToTable("Orders_OrderAddress");

                entity.HasIndex(e => e.CountryId);

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.StateOrProvinceId);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.OrdersOrderAddress)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.OrdersOrderAddress)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.StateOrProvince)
                    .WithMany(p => p.OrdersOrderAddress)
                    .HasForeignKey(d => d.StateOrProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("Orders_OrderItem");

                entity.HasIndex(e => e.OrderId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrdersOrderItem)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrdersOrderItem)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Reviews_Review");

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReviewsReview)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<SearchQuery>(entity =>
            {
                entity.ToTable("Search_Query");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor_Vendor");
            });
        }
    }
}
