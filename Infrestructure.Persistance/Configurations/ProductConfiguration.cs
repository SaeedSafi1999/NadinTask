using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // Keys
        builder.HasKey(archive => archive.Id);

        // Properties
        builder.Property(archive => archive.UserId);

        // Relationships
        builder.HasOne(archive => archive.User)
            .WithMany(user => user.products)
            .HasForeignKey(archive => archive.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}