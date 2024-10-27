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
    public class BorrowBooksDetailConfig : IEntityTypeConfiguration<BorrowBooksDetail>
    {
        public void Configure(EntityTypeBuilder<BorrowBooksDetail> builder)
        {
            builder.ToTable("BorrowBooksDetail");
            builder.HasKey(k => k.BorrowBooksDetailId);
            builder.HasOne(a => a.Book)
                            .WithMany(p => p.BorrowBooksDetails)
                            .HasForeignKey(a => a.BookId)
                            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.BorrowBooks)
                        .WithMany(p => p.BorrowBooksDetails)
                        .HasForeignKey(a => a.BorrowBooksId)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
