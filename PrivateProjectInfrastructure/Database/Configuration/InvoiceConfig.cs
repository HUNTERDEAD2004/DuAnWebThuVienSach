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
    public class InvoiceConfig : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice");
            builder.HasKey(x => x.InvoiceId);
            builder.HasOne(a => a.User)
                        .WithMany(p => p.Invoices)
                        .HasForeignKey(a => a.UserId)
                        .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Voucher)
                        .WithMany(p => p.Invoices)
                        .HasForeignKey(a => a.VoucherCode)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
