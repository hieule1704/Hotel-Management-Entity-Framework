using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSanLTQL.Data
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int InvoiceId { get; set; }
        public int RoomId { get; set; }
        public int GuestQuantity { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Room Room { get; set; }
    }

    [NotMapped]
    public class BookingList
    {
        public int BookingId { get; set; }
        public int InvoiceId { get; set; }
        public string CustomerName { get; set; } // Thêm
        public int RoomId { get; set; }
        public string RoomNumber { get; set; } // Thêm
        public int GuestQuantity { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
