using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSanLTQL.Data
{
    public class ServiceUse
    {
        public int InvoiceId { get; set; }
        public int ServiceId { get; set; }
        public int ServiceQuantity { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Service Service { get; set; }
    }

}
