using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSanLTQL.Data
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? ProfilePicture { get; set; }
        public int StaffId { get; set; }
        public bool Status { get; set; } // Dùng để xét quyền hạng

        public virtual Staff Staff { get; set; }
    }
}
