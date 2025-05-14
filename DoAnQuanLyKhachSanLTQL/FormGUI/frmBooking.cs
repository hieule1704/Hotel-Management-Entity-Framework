using ClosedXML.Excel;
using DoAnQuanLyKhachSanLTQL.Data;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyKhachSanLTQL.FormGUI
{
    public partial class frmBooking : Form
    {
        HotelDbContext context = new HotelDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa) 
        

        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            LoadComboBox(); // Load ComboBox data
            BatTatChucNang(false); // Disable controls initially
            dgvBooking.AutoGenerateColumns = false;

            var bookings = context.Bookings
                .Include(b => b.Invoice)
                    .ThenInclude(i => i.Customer)
                .Select(b => new
                {
                    b.BookingId,
                    b.InvoiceId,
                    b.TotalAmount,
                    b.Room,
                    b.RoomId,
                    b.GuestQuantity,
                    b.CheckInDate,
                    b.CheckOutDate,
                    CustomerName = b.Invoice.Customer.FullName
                }).ToList();

            var bookingDisplays = bookings.Select(b => new BookingList
            {
                BookingId = b.BookingId,
                InvoiceId = b.InvoiceId,
                RoomId = b.RoomId,
                RoomNumber = b.Room.RoomNumber,
                GuestQuantity = b.GuestQuantity,
                CheckInDate = b.CheckInDate,
                CheckOutDate = b.CheckOutDate,
                TotalAmount = b.TotalAmount,
                CustomerName = b.CustomerName
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bookingDisplays;

            dgvBooking.DataSource = bindingSource; // Link DataGridView to BindingSource

            // Attach SelectionChanged event
            dgvBooking.SelectionChanged += dgvBooking_SelectionChanged;

            // Initialize controls with the first row's data
            if (bookingDisplays.Any())
            {
                dgvBooking.Rows[0].Selected = true;
                dgvBooking_SelectionChanged(null, null);
            }
        }

        private void dgvBooking_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooking.CurrentRow != null)
            {
                var selectedBooking = (BookingList)dgvBooking.CurrentRow.DataBoundItem;

                // Update controls based on the selected row
                cboCustomerName.SelectedValue = selectedBooking.CustomerName;
                cboRoom.SelectedValue = selectedBooking.RoomId;
                txtInvoiceId.Text = selectedBooking.InvoiceId.ToString();
                dtpCheckIn.Value = selectedBooking.CheckInDate;
                dtpCheckOut.Value = selectedBooking.CheckOutDate;
                numGuestQuantity.Value = selectedBooking.GuestQuantity;
            }
        }

        private void LoadComboBox()
        {
            var rooms = context.Rooms.ToList();
            cboRoom.DataSource = rooms;
            cboRoom.DisplayMember = "RoomNumber"; // hoặc RoomId nếu bạn muốn
            cboRoom.ValueMember = "RoomId";

            var customers = context.Customers.Include(c => c.Invoices).ToList();
            cboCustomerName.DataSource = customers;
            cboCustomerName.DisplayMember = "FullName"; // hoặc CustomerId nếu bạn muốn
            cboCustomerName.ValueMember = "CustomerId";

        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnLamMoi.Enabled = giaTri;

            txtInvoiceId.Enabled = giaTri;
            cboCustomerName.Enabled = giaTri;
            cboRoom.Enabled = giaTri;
            dtpCheckIn.Enabled = giaTri;
            dtpCheckOut.Enabled = giaTri;
            numGuestQuantity.Enabled = giaTri;


            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true); // Bật các nút chức năng
            cboCustomerName.SelectedValue = -1; // Đặt lại giá trị ComboBox
            cboRoom.SelectedValue = -1; // Đặt lại giá trị ComboBox
            txtInvoiceId.Text = ""; // Đặt lại giá trị TextBox
            dtpCheckIn.Value = DateTime.Now; // Đặt lại giá trị DateTimePicker
            dtpCheckOut.Value = DateTime.Now; // Đặt lại giá trị DateTimePicker
            numGuestQuantity.Value = 1; // Đặt lại giá trị NumericUpDown
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvBooking.CurrentRow.Cells["BookingId"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + cboCustomerName.SelectedValue + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvBooking.CurrentRow.Cells["BookingId"].Value.ToString());
                Booking sp = context.Bookings.Find(id);
                if (sp != null)
                {
                    context.Bookings.Remove(sp);
                }
                context.SaveChanges();

                frmBooking_Load(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmBooking_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboCustomerName.SelectedValue == null || string.IsNullOrWhiteSpace(cboCustomerName.SelectedValue.ToString()))
            {
                MessageBox.Show("Vui lòng chọn họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int roomId = Convert.ToInt32(cboRoom.SelectedValue);
            DateTime checkIn = dtpCheckIn.Value.Date;
            DateTime checkOut = dtpCheckOut.Value.Date;

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Ngày trả phòng phải sau ngày nhận phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the room is already booked in the selected date range
            bool isRoomBooked = context.Bookings.Any(b =>
                b.RoomId == roomId &&
                ((checkIn >= b.CheckInDate && checkIn < b.CheckOutDate) ||
                 (checkOut > b.CheckInDate && checkOut <= b.CheckOutDate) ||
                 (checkIn <= b.CheckInDate && checkOut >= b.CheckOutDate)));

            if (isRoomBooked)
            {
                MessageBox.Show("Phòng đã được đặt trong khoảng thời gian này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                Room selectedRoom = context.Rooms
                    .Include(r => r.RoomType)
                    .FirstOrDefault(r => r.RoomId == roomId);

                if (selectedRoom == null || selectedRoom.RoomType == null)
                {
                    MessageBox.Show("Phòng hoặc loại phòng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedRoom.RoomType.Capacity < numGuestQuantity.Value)
                {
                    MessageBox.Show("Số lượng khách vượt quá sức chứa của phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double soNgay = (checkOut - checkIn).TotalDays;
                decimal totalAmount = (decimal)soNgay * selectedRoom.RoomType.RoomPrice;

                // Tạo invoice mới
                Invoice newInvoice = new Invoice
                {
                    CustomerId = Convert.ToInt32(cboCustomerName.SelectedValue),
                    StaffId = 2, // Default staff ID
                    InvoiceDate = DateTime.Now,
                    TotalAmount = totalAmount,
                    PaymentType = "Thẻ tín dụng"
                };
                context.Invoices.Add(newInvoice);

                // Save the Invoice first to generate the InvoiceId
                context.SaveChanges();

                if (newInvoice.InvoiceId <= 0)
                {
                    MessageBox.Show("Không thể tạo hóa đơn mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo booking
                Booking booking = new Booking
                {
                    InvoiceId = newInvoice.InvoiceId,
                    RoomId = roomId,
                    GuestQuantity = (int)numGuestQuantity.Value,
                    CheckInDate = checkIn,
                    CheckOutDate = checkOut,
                    TotalAmount = totalAmount
                };
                context.Bookings.Add(booking);

                // Save the Booking
                context.SaveChanges();
            }
            else // Xử lý sửa
            {
                Booking booking = context.Bookings.Find(id);
                if (booking != null)
                {
                    Room selectedRoom = context.Rooms
                        .Include(r => r.RoomType)
                        .FirstOrDefault(r => r.RoomId == roomId);

                    if (selectedRoom == null || selectedRoom.RoomType == null)
                    {
                        MessageBox.Show("Phòng hoặc loại phòng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (selectedRoom.RoomType.Capacity < numGuestQuantity.Value)
                    {
                        MessageBox.Show("Số lượng khách vượt quá sức chứa của phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    double soNgay = (checkOut - checkIn).TotalDays;
                    decimal totalAmount = (decimal)soNgay * selectedRoom.RoomType.RoomPrice;

                    int invoiceId;
                    if (!int.TryParse(txtInvoiceId.Text, out invoiceId) || !context.Invoices.Any(i => i.InvoiceId == invoiceId))
                    {
                        MessageBox.Show("InvoiceId không hợp lệ hoặc không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    booking.InvoiceId = invoiceId;
                    booking.RoomId = roomId;
                    booking.GuestQuantity = (int)numGuestQuantity.Value;
                    booking.CheckInDate = checkIn;
                    booking.CheckOutDate = checkOut;
                    booking.TotalAmount = totalAmount;

                    context.Bookings.Update(booking);
                    context.SaveChanges();
                }
            }

            frmBooking_Load(sender, e);
        }

    }
}
