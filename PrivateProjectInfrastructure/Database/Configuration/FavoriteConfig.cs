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
    public class FavoriteConfig : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.ToTable("Favorite");
            builder.HasKey(x => x.FavoriteId);
            builder.HasOne(a => a.User)
                .WithMany(p => p.Favorites)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Book)
                .WithMany(p => p.Favorites)
                .HasForeignKey(a => a.BookId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
