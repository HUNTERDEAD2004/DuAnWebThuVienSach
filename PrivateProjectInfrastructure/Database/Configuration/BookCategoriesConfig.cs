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
    public class BookCategoriesConfig : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.ToTable("BookCategories");
            builder.HasKey(k => k.BookCategoryId);
            builder.HasOne(a => a.Book)
                            .WithMany(p => p.BookCategories)
                            .HasForeignKey(a => a.BookId)
                            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Category)
                            .WithMany(p => p.BookCategories)
                            .HasForeignKey(a => a.CategoryId)
                            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
