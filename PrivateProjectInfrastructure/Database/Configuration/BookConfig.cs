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
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.HasKey(k => k.BookId);
            builder.HasOne(a => a.Sale)
                            .WithMany(p => p.Books)
                            .HasForeignKey(a => a.SaleId)
                            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
