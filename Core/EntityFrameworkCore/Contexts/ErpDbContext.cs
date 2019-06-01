using Entities.ERP;

using EntityFrameworkCore.Audits;

using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Contexts
{
    public class ErpDbContext : WeddingDbContext
    {
        public ErpDbContext(DbContextOptions<ErpDbContext> options, IAuditHelper auditHelper)
            : base(options, auditHelper)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<WeddingStudio> WeddingStudios { get; set; }

        public DbSet<WeddingStudioProduct> WeddingStudioProducts { get; set; }

        public DbSet<WeddingStudioProductReview> WeddingStudioProductReview { get; set; }

        public DbSet<WeddingStudioReview> WeddingStudioReviews { get; set; }

        public DbSet<WeddingStudioGroup> WeddingStudioGroups { get; set; }

        public DbSet<StateProvince> StateProvinces { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Cummune> Cummunes { get; set; }

        public DbSet<ConfigValue> ConfigValues { get; set; }

        public DbSet<PriceUnit> PriceUnits { get; set; }

        public DbSet<Numbering> Numberings { get; set; }
    }
}