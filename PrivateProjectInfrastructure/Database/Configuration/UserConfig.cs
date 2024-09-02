using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrivateProjectDomain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectInfrastructure.Database.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(k => k.UserId);
            builder.HasOne(a => a.Carts)
                            .WithOne(p => p.User)
                            .HasForeignKey<Cart>(c => c.UserId)
                            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Role)
                            .WithMany(p => p.Users)
                            .HasForeignKey(a => a.RoleId)
                            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
