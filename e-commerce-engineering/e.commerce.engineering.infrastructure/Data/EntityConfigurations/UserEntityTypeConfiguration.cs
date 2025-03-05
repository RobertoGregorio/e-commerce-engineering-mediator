using e.commerce.engineering.domain.Aggregates.UserAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e.commerce.egineering.infrastructure.Data.EntityConfigurations
{
    internal class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           builder.HasKey(user => user.UserId);
           builder.Property(user => user.Username).IsRequired();
           builder.Property(user => user.Name).IsRequired();
           builder.Property(user => user.Password).IsRequired();
           builder.Property(user => user.CreatedAt).IsRequired();
           builder.Property(user => user.UpdatedAt).IsRequired();
        }
    }
}
