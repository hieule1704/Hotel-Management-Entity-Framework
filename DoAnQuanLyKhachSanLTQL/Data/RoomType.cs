using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSanLTQL.Data
{
    public class RoomType
    {
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public int Capacity { get; set; }
        public int BedAmount { get; set; }
        public decimal RoomPrice { get; set; }
        public string? RoomTypeDesc { get; set; }
        public string? RoomTypeImg { get; set; }

        public virtual ObservableCollectionListSource<Room> Rooms { get; } = new();
    }

}
