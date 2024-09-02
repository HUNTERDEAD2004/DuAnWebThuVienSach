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
    public class CartDetailConfig : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.ToTable("CartDetail");
            builder.HasKey(x => x.CartDetailId);
            builder.HasOne(a => a.Cart)
                   .WithMany(p => p.CartDetails)
                   .HasForeignKey(a => a.CartId)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Book)
                   .WithMany(p => p.CartDetails)
                   .HasForeignKey(a => a.BookId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
