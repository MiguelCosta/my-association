namespace Mpc.MyAssociation.Data.Ef.Mappings
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Mpc.MyAssociation.Domain.Models;

    public class MemberMapping : IEntityTypeConfiguration<MemberModel>
    {
        public void Configure(EntityTypeBuilder<MemberModel> builder)
        {
            builder.ToTable("Members");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(255);
        }
    }
}
