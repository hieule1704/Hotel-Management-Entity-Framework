using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSanLTQL.Data
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }

        public string? Notes { get; set; }
        public int RoomTypeId { get; set; }

        public virtual RoomType RoomType { get; set; }

        public virtual ObservableCollectionListSource<Booking> Bookings { get; } = new();
    }

    [NotMapped]
    public class RoomList
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string? Notes { get; set; }
        public int RoomTypeId { get; set; }
         
        public string RoomTypeName { get; set; }

    }

}
