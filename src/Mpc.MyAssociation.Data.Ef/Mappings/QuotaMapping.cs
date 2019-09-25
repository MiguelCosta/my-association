namespace Mpc.MyAssociation.Data.Ef.Mappings
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Mpc.MyAssociation.Domain.Models;

    public class QuotaMapping : IEntityTypeConfiguration<QuotaModel>
    {
        public void Configure(EntityTypeBuilder<QuotaModel> builder)
        {
            builder.ToTable("Quotas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(255);

            builder.Property(x => x.Value)
                .HasColumnName("Value");

            builder.Property(x => x.StartDate)
                .HasColumnName("StartDate");

            builder.Property(x => x.EndDate)
                .HasColumnName("EndDate");
        }
    }
}
