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
    public class BorrowBooksConfig : IEntityTypeConfiguration<BorrowBooks>
    {
        public void Configure(EntityTypeBuilder<BorrowBooks> builder)
        {
            builder.ToTable("BorrowBooks");
            builder.HasKey(k => k.BorrowBooksId);
            builder.HasOne(a => a.User)
                            .WithMany(p => p.BorrowBooks)
                            .HasForeignKey(a => a.UserId)
                            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Voucher)
                            .WithMany(p => p.BorrowBooks)
                            .HasForeignKey(a => a.VoucherCode)
                            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
