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
    public class InvoiceDetailConfig : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.ToTable("InvoiceDetail");
            builder.HasKey(x => x.InvoiceDetailId);
            builder.HasOne(a => a.Invoice)
                        .WithMany(p => p.InvoiceDetails)
                        .HasForeignKey(a => a.InvoiceId)
                        .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Book)
                        .WithMany(p => p.InvoiceDetails)
                        .HasForeignKey(a => a.BookId)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
