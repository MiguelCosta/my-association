namespace Mpc.MyAssociation.Data.Ef
{
    using Microsoft.EntityFrameworkCore;
    using Mpc.MyAssociation.Data.Ef.Mappings;
    using Mpc.MyAssociation.Domain.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<MemberModel> Members { get; set; }

        public DbSet<QuotaModel> Quotas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MemberMapping());
            modelBuilder.ApplyConfiguration(new QuotaMapping());
        }
    }
}
