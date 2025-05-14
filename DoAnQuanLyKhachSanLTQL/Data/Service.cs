using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSanLTQL.Data
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public decimal ServicePrice { get; set; }

        public virtual ObservableCollectionListSource<ServiceUse> ServiceUses { get; } = new();
    }
}
