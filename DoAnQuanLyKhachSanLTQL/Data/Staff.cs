using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSanLTQL.Data
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        // Quan hệ 1-1
        public virtual Account Account { get; set; }

        // Quan hệ 1-n
        public virtual ObservableCollectionListSource<Invoice> Invoices { get; } = new();
    }
}
