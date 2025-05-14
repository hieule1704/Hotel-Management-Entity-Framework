using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSanLTQL.Data
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string Gender { get; set; }
        public string? CreditCard { get; set; }
        public string IdProof { get; set; }

        public virtual ObservableCollectionListSource<Invoice> Invoices { get; } = new();
    }
}
