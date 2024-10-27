using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using PrivateProjectDomain.Data.Entities;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            // Seed author data
            var authorData = new List<Author>
            {
                new Author
                {
                    AuthorId = Guid.Parse("b6f5b1b3-e302-48a0-b742-05e9c9e80e02"),
                    AuthorName = "Nguyễn Anh Dũng",
                    Email = "nguyenanhdung@gmail.com",
                    PhoneNumber = "0328903714",
                    DOB = Convert.ToDateTime("1/1/1945"),
                    Status = EntityStatus.Active,
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                },
                new Author
                {
                    AuthorId = Guid.Parse("de92d1ff-9ac2-4829-9f4a-577d10030ed1"),
                    AuthorName = "Nguyễn Văn B",
                    Email = "nguyenvanb@gmail.com",
                    PhoneNumber = "0328903715",
                    DOB = Convert.ToDateTime("1/1/1972"),
                    Status = EntityStatus.Active,
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:37", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                }
            };
            modelBuilder.Entity<Author>().HasData(authorData);

            // Seed book data
            var bookData = new List<Book>
            {
                new Book
                {
                    BookId = Guid.Parse("de599091-e6a4-415d-87dc-ea20a15e8134"),
                    Title = "Tư Duy Ngược",
                    ISBN = "9786043440287",
                    ImageBook = new List<string>{"image1.jpg","image2.jpg","image3.jpg"},
                    View = 10000,
                    SellingPrice =69500,
                    RentalPrice =15300,
                    PriceDecreased = 38500,
                    Description = "Dũng cảm sống để thành công , sống để trải nghiệm cuốn sách hay mà bạn nên đọc",
                    SaleId = null,
                    Status = BookStatus.publishedBooks,
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                },
                new Book
                {
                    BookId = Guid.Parse("fa19e753-4742-400d-94dc-7f46430ee1fc"),
                    Title = "Tư Duy Mở",
                    ISBN = "9786044742250",
                    ImageBook = new List<string>{"image3.jpg","image4.jpg","image5.jpg"},
                    View = 10000,
                    SellingPrice =13800,
                    RentalPrice =38200,
                    PriceDecreased = 69000,
                    Description = "một nguồn cảm hứng tuyệt vời cho những ai muốn mở rộng tầm nhìn và cải thiện khả năng tư duy",
                    SaleId = Guid.Parse("94d6c0b2-cf35-42d8-9d79-0d7f0381ff09"),
                    Status = BookStatus.publishedBooks,
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                }
            };
            modelBuilder.Entity<Book>().HasData(bookData);

            // Seed category data
            var categoryData = new List<Category>
            {
                new Category
                {
                    CategoryId = Guid.Parse("f4059629-8f17-4907-b95b-0ac4494653d8"),
                    Name = "Sách Kỹ Năng Sống",
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                },
                new Category
                {
                    CategoryId = Guid.Parse("8a680965-5d2d-4336-8644-b577056bfa7c"),
                    Name = "Sách Khoa Học Viễn Tưởng",
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                },
                new Category
                {
                    CategoryId = Guid.Parse("95434e23-a8ff-4771-8a62-49cbddbd6740"),
                    Name = "Sách Kinh Doanh – Tài Chính",
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                },
                new Category
                {
                    CategoryId = Guid.Parse("525ec34e-d614-42ac-8e87-5c159ce0b463"),
                    Name = "Sách Lịch Sử",
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                },
                new Category
                {
                    CategoryId = Guid.Parse("6ab62453-2ca8-40de-ac79-989a113546c2"),
                    Name = "Sách Nấu Ăn",
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                }
            };
            modelBuilder.Entity<Category>().HasData(categoryData);

            // Seed borrowbook data
            var borrowBooksData = new List<BorrowBooks>
            {
                new BorrowBooks
                {
                    BorrowBooksId = Guid.Parse("3c815d54-02e3-4f85-826f-8b58d04b2a98"),
                    UserId = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    VoucherCode = Guid.Parse("062cb741-49fb-445f-aefa-cab25b7e9c41"),
                    ReturnDate = Convert.ToDateTime("16/11/2024"),
                    TotalPrice = 15300,
                    PaymentMethod = PaymentStatus.Banking,
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 18:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                },
                new BorrowBooks
                {
                    BorrowBooksId = Guid.Parse("48ecf49e-d91b-4dfb-b5ac-84d24b715682"),
                    UserId = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    VoucherCode = null,
                    ReturnDate = Convert.ToDateTime("16/11/2024"),
                    TotalPrice = 38200,
                    PaymentMethod = PaymentStatus.Banking,
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 18:50", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                }
            };
            modelBuilder.Entity<BorrowBooks>().HasData(borrowBooksData);

            // Seed borrowBookDetail data
            var borrowBookDetailData = new List<BorrowBooksDetail>
            {
                new BorrowBooksDetail
                {
                    BorrowBooksDetailId = Guid.Parse("0b947460-704a-499b-8462-1c9c9e33b73d"),
                    BookId = Guid.Parse("de599091-e6a4-415d-87dc-ea20a15e8134"),
                    BorrowBooksId = Guid.Parse("3c815d54-02e3-4f85-826f-8b58d04b2a98"),
                    Quantity = 1,
                    Price = 15300
                },
                new BorrowBooksDetail
                {
                    BorrowBooksDetailId = Guid.Parse("e5cde6d4-d214-489b-a48a-231040396d72"),
                    BookId = Guid.Parse("fa19e753-4742-400d-94dc-7f46430ee1fc"),
                    BorrowBooksId = Guid.Parse("48ecf49e-d91b-4dfb-b5ac-84d24b715682"),
                    Quantity = 1,
                    Price = 38200
                }
            };
            modelBuilder.Entity<BorrowBooksDetail>().HasData(borrowBookDetailData);

            // Seed purchaseBook data
            var purchaseBookData = new List<PurchaseBooks>
            {
                new PurchaseBooks
                {
                    PurchaseBooksId = Guid.Parse("858817cc-e40f-4cbf-b41a-671298c27396"),
                    UserId = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    VoucherCode = Guid.Parse("062cb741-49fb-445f-aefa-cab25b7e9c41"),
                    TotalPrice = 15300,
                    PaymentMethod = PaymentStatus.Banking,
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 18:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                },
                new PurchaseBooks
                {
                    PurchaseBooksId = Guid.Parse("8e4c5b38-072f-4cb6-9001-8347b5ec87f9"),
                    UserId = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    VoucherCode = Guid.Parse("062cb741-49fb-445f-aefa-cab25b7e9c41"),
                    TotalPrice = 15300,
                    PaymentMethod = PaymentStatus.Banking,
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 18:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                }
            };
            modelBuilder.Entity<PurchaseBooks>().HasData(purchaseBookData);

            // Seed purchaseBookDetail data
            var purchaseBookDetailData = new List<PurchaseBooksDetail>
            {
                new PurchaseBooksDetail
                {
                    PurchaseBooksDetailId = Guid.Parse("4a99c638-0c9f-4294-ac36-9f0c42dd0d4b"),
                    BookId = Guid.Parse("de599091-e6a4-415d-87dc-ea20a15e8134"),
                    PurchaseBooksId = Guid.Parse("3c815d54-02e3-4f85-826f-8b58d04b2a98"),
                    Quantity = 1,
                    Price = 15300
                },
                new PurchaseBooksDetail
                {
                    PurchaseBooksDetailId = Guid.Parse("90ea5b1f-d724-4e7a-b5e9-c539c8a8f3e5"),
                    BookId = Guid.Parse("de599091-e6a4-415d-87dc-ea20a15e8134"),
                    PurchaseBooksId = Guid.Parse("3c815d54-02e3-4f85-826f-8b58d04b2a98"),
                    Quantity = 1,
                    Price = 15300
                }
            };
            modelBuilder.Entity<PurchaseBooksDetail>().HasData(purchaseBookDetailData);

            // Seed sale data
            var saleData = new List<Sale>
            {
                new Sale
                {
                    SaleCode = Guid.Parse("94d6c0b2-cf35-42d8-9d79-0d7f0381ff09"),
                    SaleName = "Sale50",
                    DiscountPrice = 50,
                    Description = "Sale mùa đông",
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                },
                new Sale
                {
                    SaleCode = Guid.Parse("b5759f20-5565-4a27-9fe4-674d63f755db"),
                    SaleName = "Sale15",
                    DiscountPrice = 15,
                    Description = "Sale mùa đông",
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                }
            };
            modelBuilder.Entity<Sale>().HasData(saleData);

            // Seed sale data
            var voucherData = new List<Voucher>
            {
                new Voucher
                {
                    VoucherCode = Guid.Parse("062cb741-49fb-445f-aefa-cab25b7e9c41"),
                    VoucherName = "Voucher50",
                    DiscountPrice = 50,
                    Description = "Voucher mùa đông",
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                },
                new Voucher
                {
                    VoucherCode = Guid.Parse("2c61e6fd-d898-4e63-bfe1-161891736390"),
                    VoucherName = "Voucher25",
                    DiscountPrice = 25,
                    Description = "Voucher mùa đông",
                    CreatedBy = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    CreatedTime = DateTime.ParseExact("27/10/2024 16:35", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                }
            };
            modelBuilder.Entity<Voucher>().HasData(voucherData);

            // Seed role data
            var roleData = new List<Role>
            {
                new Role
                { 
                    RoleId = Guid.Parse("86869ca4-bd34-4b06-8bbd-1be9321341a8"),
                    RoleName = "Admin"
                },
                new Role
                {
                    RoleId = Guid.Parse("d2c3485d-9d48-45ec-98a0-69e7c044d814"),
                    RoleName = "User"
                }
            };
            modelBuilder.Entity<Role>().HasData(roleData);

            // Seed user data
            var userData = new List<User>
            {
                new User
                {
                    UserId = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                    FullName = "Nguyễn Thanh Nhân",
                    UserName = "Admin1",
                    PassWord = "1111",
                    Email = "nguyenthanhnhan@gmail.com",
                    PhoneNumber = "0328903711",
                    DOB = Convert.ToDateTime("1/1/1900"),
                    RoleId = Guid.Parse("86869ca4-bd34-4b06-8bbd-1be9321341a8"),
                    Status = EntityStatus.Active,
                },
                new User
                {
                    UserId = Guid.Parse("6d865465-a6a0-46c1-a8ff-0adb2cbc0d25"),
                    FullName = "Nguyễn Thanh Nhàn",
                    UserName = "Admin2",
                    PassWord = "2222",
                    Email = "nguyenthanhnhan@gmail.com",
                    PhoneNumber = "0328903712",
                    DOB = Convert.ToDateTime("1/1/1901"),
                    RoleId = Guid.Parse("86869ca4-bd34-4b06-8bbd-1be9321341a8"),
                    Status = EntityStatus.Active,
                }
            };
            modelBuilder.Entity<User>().HasData(userData);

            // Seed bookcategory data
            var bookcategoryData = new List<BookCategory>
            {
                new BookCategory
                {
                    BookCategoryId = Guid.Parse("2076c898-5362-4329-a9a7-a719c030a20d"),
                    BookId = Guid.Parse("de599091-e6a4-415d-87dc-ea20a15e8134"),
                    CategoryId = Guid.Parse("f4059629-8f17-4907-b95b-0ac4494653d8"),
                },
                new BookCategory
                {
                    BookCategoryId = Guid.Parse("c8ee1e9b-3a70-41f4-86b2-e7487094012d"),
                    BookId = Guid.Parse("fa19e753-4742-400d-94dc-7f46430ee1fc"),
                    CategoryId = Guid.Parse("f4059629-8f17-4907-b95b-0ac4494653d8"),
                }
            };
            modelBuilder.Entity<BookCategory>().HasData(bookcategoryData);

            // Seed bookauthor data
            var bookauthorData = new List<BookAuthor>
            {
                new BookAuthor
                {
                    BookAuthorId = Guid.Parse("4ef8a903-9bc7-49c7-b950-31c8fff12e0d"),
                    BookId = Guid.Parse("de599091-e6a4-415d-87dc-ea20a15e8134"),
                    AuthorId = Guid.Parse("b6f5b1b3-e302-48a0-b742-05e9c9e80e02"),
                },
                new BookAuthor
                {
                    BookAuthorId = Guid.Parse("45a0387b-f6fc-4225-8b3e-f895d36f4aae"),
                    BookId = Guid.Parse("fa19e753-4742-400d-94dc-7f46430ee1fc"),
                    AuthorId = Guid.Parse("b6f5b1b3-e302-48a0-b742-05e9c9e80e02"),
                }
            };
            modelBuilder.Entity<BookAuthor>().HasData(bookauthorData);

            // Seed favorite data
            var favoriteData = new List<Favorite>
            {
                new Favorite
                {
                    FavoriteId = Guid.Parse("a1667f13-cb08-4060-a0f8-1f8696d0a923"),
                    BookId = Guid.Parse("de599091-e6a4-415d-87dc-ea20a15e8134"),
                    UserId = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                },
                new Favorite
                {
                    FavoriteId = Guid.Parse("a1667f13-cb08-4060-a0f8-1f8696d0a923"),
                    BookId = Guid.Parse("fa19e753-4742-400d-94dc-7f46430ee1fc"),
                    UserId = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                }
            };
            modelBuilder.Entity<Favorite>().HasData(favoriteData);

            // Seed feedback data
            var feedBackData = new List<FeedBack>
            {
                new FeedBack
                {
                    FeedBackId = Guid.Parse("25c85c05-6141-40ff-8301-563084067bed"),
                    BookId = Guid.Parse("fa19e753-4742-400d-94dc-7f46430ee1fc"),
                    UserId = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                },
                new FeedBack
                {
                    FeedBackId = Guid.Parse("c19afedc-73a3-4d25-a454-cd9875b9a436"),
                    BookId = Guid.Parse("fa19e753-4742-400d-94dc-7f46430ee1fc"),
                    UserId = Guid.Parse("417a351f-f4b6-44b8-97d9-4f9293d6102a"),
                }
            };
            modelBuilder.Entity<FeedBack>().HasData(feedBackData);

            base.OnModelCreating(modelBuilder);
        }
    }
}
