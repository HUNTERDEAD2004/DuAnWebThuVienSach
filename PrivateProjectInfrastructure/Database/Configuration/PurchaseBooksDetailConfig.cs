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
    public class PurchaseBooksDetailConfig : IEntityTypeConfiguration<PurchaseBooksDetail>
    {
        public void Configure(EntityTypeBuilder<PurchaseBooksDetail> builder)
        {
            builder.ToTable("PurchaseBooksDetail");
            builder.HasKey(x => x.PurchaseBooksDetailId);
            builder.HasOne(a => a.Book)
                        .WithMany(p => p.PurchaseBooksDetails)
                        .HasForeignKey(a => a.BookId)
                        .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.PurchaseBooks)
                        .WithMany(p => p.PurchaseBooksDetails)
                        .HasForeignKey(a => a.PurchaseBooksId)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
