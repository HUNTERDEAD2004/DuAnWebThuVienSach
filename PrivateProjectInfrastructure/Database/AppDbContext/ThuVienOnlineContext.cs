using Microsoft.EntityFrameworkCore;
using PrivateProjectDomain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectInfrastructure.Database.AppDbContext
{
    public class ThuVienOnlineContext : DbContext
    {
        public ThuVienOnlineContext()
        {
            
        }

        public ThuVienOnlineContext(DbContextOptions options) : base(options)
        {
        }

        #region DB Set

        public DbSet<Author> authors { get; set; }

        public DbSet<BookAuthor> bookAuthors { get; set; }

        public DbSet<BookCategory> bookCategories { get; set; }

        public DbSet<BorrowBooks> borrowBooks { get; set; }

        public DbSet<BorrowBooksDetail> borrowBooksDetails { get; set; }

        public DbSet<Cart> carts { get; set; }

        public DbSet<CartDetail> cartDetails { get; set; }  

        public DbSet<Category> categories { get; set; }

        public DbSet<Favorite> favorites { get; set; }

        public DbSet<FeedBack> feedBacks { get; set; }

        public DbSet<Invoice> invoices { get; set; }

        public DbSet<InvoiceDetail> invoiceDetails { get; set; }

        public DbSet<PurchaseBooks> purchaseBooks { get; set; }

        public DbSet<PurchaseBooksDetail> PurchaseBooksDetails { get; set; }

        public DbSet<Role> roles { get; set; }

        public DbSet<Sale> sales { get; set; }

        public DbSet<User> users { get; set; }

        public DbSet<Voucher> vouchers { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOPD-DELLIN\\SQLEXPRESS;Database=DuAnWebThuVienOnline;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedingData(modelBuilder);
        }

        public void SeedingData(ModelBuilder modelBuilder)
        {

        }
    }
}
