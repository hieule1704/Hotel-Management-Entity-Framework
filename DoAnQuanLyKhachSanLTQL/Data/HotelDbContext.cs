using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSanLTQL.Data
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Staff> Staffs { get; set; } // DbSet<T> đại diện cho bảng (table) trong database.
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ServiceUse> ServiceUses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["HotelConnection"].ConnectionString);
        }

        [Obsolete]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Staff
            modelBuilder.Entity<Staff>()
                .HasKey(s => s.StaffId);
            modelBuilder.Entity<Staff>()
                .Property(s => s.StaffId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Staff>()
                .Property(s => s.Gender)
                .HasConversion<string>();
            modelBuilder.Entity<Staff>()
                .HasCheckConstraint("CK_Staff_Gender", "Gender IN (N'Nam', N'Nữ', N'Giới tính thứ 3')");

            // Account
            modelBuilder.Entity<Account>()
                .HasKey(a => a.Username);
            modelBuilder.Entity<Account>()
                .HasOne(a => a.Staff)
                .WithOne(s => s.Account)
                .HasForeignKey<Account>(a => a.StaffId);

            // Customer
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.CustomerId);
            modelBuilder.Entity<Customer>()
                .Property(c => c.CustomerId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>()
                .HasCheckConstraint("CK_Customer_Gender", "Gender IN (N'Nam', N'Nữ', N'Giới tính thứ 3')");

            // Room
            modelBuilder.Entity<Room>()
                .HasKey(r => r.RoomId);
            modelBuilder.Entity<Room>()
                .Property(r => r.RoomId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Room>()
                .HasOne(r => r.RoomType)
                .WithMany(rt => rt.Rooms)
                .HasForeignKey(r => r.RoomTypeId);

            // RoomType
            modelBuilder.Entity<RoomType>()
                .HasKey(rt => rt.RoomTypeId);
            modelBuilder.Entity<RoomType>()
                .Property(rt => rt.RoomTypeId)
                .ValueGeneratedOnAdd();

            // Service
            modelBuilder.Entity<Service>()
                .HasKey(sv => sv.ServiceId);
            modelBuilder.Entity<Service>()
                .Property(sv => sv.ServiceId)
                .ValueGeneratedOnAdd();

            // Invoice
            modelBuilder.Entity<Invoice>()
        .HasKey(i => i.InvoiceId);
            modelBuilder.Entity<Invoice>()
                .Property(i => i.InvoiceId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Customer)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.CustomerId);
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Staff)
                .WithMany(s => s.Invoices)
                .HasForeignKey(i => i.StaffId);
            modelBuilder.Entity<Invoice>()
                .HasCheckConstraint("CK_Invoice_PaymentType", "PaymentType IN (N'Tiền mặc', N'Thẻ tín dụng')");

            // Booking
            modelBuilder.Entity<Booking>()
                .HasKey(b => b.BookingId);
            modelBuilder.Entity<Booking>()
                .Property(b => b.BookingId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Invoice)
                .WithMany(i => i.Bookings)
                .HasForeignKey(b => b.InvoiceId);
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Room)
                .WithMany(r => r.Bookings)
                .HasForeignKey(b => b.RoomId);

            // ServiceUse
            modelBuilder.Entity<ServiceUse>()
                .HasKey(su => new { su.InvoiceId, su.ServiceId });
            modelBuilder.Entity<ServiceUse>()
                .HasOne(su => su.Invoice)
                .WithMany(i => i.ServiceUses)
                .HasForeignKey(su => su.InvoiceId);
            modelBuilder.Entity<ServiceUse>()
                .HasOne(su => su.Service)
                .WithMany(sv => sv.ServiceUses)
                .HasForeignKey(su => su.ServiceId);
        }

    }
}
