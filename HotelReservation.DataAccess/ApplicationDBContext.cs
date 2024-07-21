using HotelReservation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DataAccess
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingGuests> BookingGuests { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Payment> Payments { get; set; }

        //Buraya kendi bilgisayarımdaki Connection string'i verdim şimdilik, burayı düzelteceğiz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=OZYUREK\SQLEXPRESS;Initial Catalog=HotelReservationDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        //Ara tablo olarak oluşturulan BookingGuests'in id'si Booking'den ve Guest'ten alındı.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingGuests>().HasKey(b => new { b.BookingId, b.GuestId });

            modelBuilder.Entity<BookingGuests>().Ignore(b => b.Id);

            //Para birimleri decimal tipinde oluşturulmuştu. Precision hatası almamak için aşağıdaki kısım yazıldı.
            var decimalProps = modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));

            foreach (var property in decimalProps)
            {
                property.SetPrecision(18);
                property.SetScale(2);
            }
        }
    }
}
