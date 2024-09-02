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
    public class FeedBackConfig : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            builder.ToTable("FeedBack");
            builder.HasKey(k => k.FeedBackId);
            builder.HasOne(a => a.Book)
                            .WithMany(p => p.FeedBacks)
                            .HasForeignKey(a => a.BookId)
                            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.User)
                            .WithMany(p => p.FeedBacks)
                            .HasForeignKey(a => a.UserId)
                            .OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
