using Ganymede.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ganymede.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Id)
                .HasDefaultValueSql("uuid_generate_v4()")
                .Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Ignore);

            builder.Property(x => x.Name).IsRequired();
            
            builder.Property(x => x.Email).IsRequired();
            
            builder.Property(x => x.Password).IsRequired();

            builder.HasIndex(x => x.Email).IsUnique();
        }
    }
}
