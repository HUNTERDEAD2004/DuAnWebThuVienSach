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
    public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.ToTable("BookAuthor");
            builder.HasKey(k => k.BookAuthorId);
            builder.HasOne(a => a.Book)
                            .WithMany(p => p.BookAuthors)
                            .HasForeignKey(a => a.BookId)
                            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Author)
                            .WithMany(p => p.BookAuthors)
                            .HasForeignKey(a => a.AuthorId)
                            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
