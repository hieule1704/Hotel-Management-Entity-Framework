using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSanLTQL.Data
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public int StaffId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public string PaymentType { get; set; }

        public virtual Customer Customer { get; set; } // Many to one
        public virtual Staff Staff { get; set; }

        public virtual ObservableCollectionListSource<Booking> Bookings { get; } = new(); // One to many
        public virtual ObservableCollectionListSource<ServiceUse> ServiceUses { get; } = new();
    }

    [NotMapped]
    public class InvoiceList
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }    // Thêm
        public int StaffId { get; set; }

        public string StaffName { get; set; }    // Thêm
        public DateTime InvoiceDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public string PaymentType { get; set; }

        public string? InvoiceDetail { get; set; } // Thêm

    }
}
