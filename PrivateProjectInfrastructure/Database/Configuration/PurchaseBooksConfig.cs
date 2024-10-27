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
    public class PurchaseBooksConfig : IEntityTypeConfiguration<PurchaseBooks>
    {
        public void Configure(EntityTypeBuilder<PurchaseBooks> builder)
        {
            builder.ToTable("PurchaseBooks");
            builder.HasKey(x => x.PurchaseBooksId);
            builder.HasOne(a => a.User)
                            .WithMany(p => p.PurchaseBooks)
                            .HasForeignKey(a => a.UserId)
                            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Voucher)
                            .WithMany(p => p.PurchaseBooks)
                            .HasForeignKey(a => a.VoucherCode)
                            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
