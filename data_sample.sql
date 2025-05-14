-- Dữ liệu mẫu
USE DAQLKS;
GO

-- Bắt đầu bằng bảng phụ thuộc nhất (khóa ngoại nhiều nhất)
DELETE FROM ServiceUses;
DELETE FROM Bookings;
DELETE FROM Invoices;
DELETE FROM Rooms;
DELETE FROM Services;
DELETE FROM Customers;
DELETE FROM Accounts;
DELETE FROM Staffs;
DELETE FROM RoomTypes;

-- Reset lại giá trị IDENTITY về 1 -- Lưu ý Account và ServiceUse không có thuộc tính tự động tăng
DBCC CHECKIDENT ('RoomTypes', RESEED, 0);
DBCC CHECKIDENT ('Staffs', RESEED, 0);
DBCC CHECKIDENT ('Customers', RESEED, 0);
DBCC CHECKIDENT ('Services', RESEED, 0);
DBCC CHECKIDENT ('Rooms', RESEED, 0);
DBCC CHECKIDENT ('Invoices', RESEED, 0);
DBCC CHECKIDENT ('Bookings', RESEED, 0);

SELECT * FROM ServiceUses;
SELECT * FROM Bookings;
SELECT * FROM Invoices;
SELECT * FROM Rooms;
SELECT * FROM Services;
SELECT * FROM Customers;
SELECT * FROM Accounts;
SELECT * FROM Staffs;
SELECT * FROM RoomTypes;

INSERT INTO RoomTypes (RoomTypeName, Capacity, BedAmount, RoomPrice, RoomTypeDesc, RoomTypeImg)
VALUES
(N'Phòng đơn', 1, 1, 100.00, N'Phòng dành cho 1 người', NULL),
(N'Phòng đôi', 2, 1, 200.00, N'Phòng cho hai người dùng chung một giường', NULL),
(N'Phòng hai giường đơn', 2, 2, 300.00, N'Phòng có hai giường đơn', NULL),
(N'Phòng hai giường đôi', 4, 2, 400.00, N'Phòng có hai giường đôi', NULL);

INSERT INTO Staffs (FullName, Position, ContactNumber, Email, Address, Birthday, Gender, Salary)
VALUES
(N'Nguyễn Văn A', N'Quản lý', '0909123456', 'a.manager@example.com', N'123 Lê Lợi, TP.HCM', '1985-01-15', N'Nam', 20000000),
(N'Trần Thị B', N'Nhân viên lễ tân', '0909111222', 'b.staff@example.com', N'456 Nguyễn Trãi, Hà Nội', '1992-04-20', N'Nữ', 10000000),
(N'Lê Văn C', N'Nhân viên phục vụ', '0909333444', 'c.staff@example.com', N'789 Cách Mạng Tháng Tám, Đà Nẵng', '1995-07-10', N'Nam', 9500000);

INSERT INTO Accounts (Username, Password, ProfilePicture, StaffId, Status)
VALUES
('manager01', '123456', NULL, 1, 1),  -- Quản lý (Status = 1)
('staff01', '123456', NULL, 2, 0),    -- Nhân viên
('staff02', '123456', NULL, 3, 0);    -- Nhân viên

INSERT INTO Customers (FullName, ContactNumber, Email, Address, Gender, CreditCard, IdProof)
VALUES
(N'Phạm Thị D', '0912345678', 'd.customer@example.com', N'Bến Tre', N'Nữ', '1234567812345678', 'CMND123456'),
(N'Ngô Văn E', '0987654321', 'e.customer@example.com', N'Cần Thơ', N'Nam', '8765432187654321', 'CMND234567'),
(N'Hồ Thị F', '0933444555', 'f.customer@example.com', N'An Giang', N'Nữ', '1122334455667788', 'CMND345678'),
(N'Lý Văn G', '0977555444', 'g.customer@example.com', N'Tiền Giang', N'Nam', '9988776655443322', 'CMND456789'),
(N'Mai Thị H', '0922334455', 'h.customer@example.com', N'Sóc Trăng', N'Nữ', '6677889900112233', 'CMND567890');

INSERT INTO Services (ServiceName, ServiceType, ServicePrice)
VALUES
(N'Nước suối', N'Đồ uống', 10.000),
(N'Coca Cola', N'Đồ uống', 15.000),
(N'Cà phê', N'Đồ uống', 20.000),
(N'Giặt ủi', N'Dịch vụ phòng', 50.000),
(N'Bữa sáng', N'Ăn uống', 80.000),
(N'Bữa trưa', N'Ăn uống', 120.000),
(N'Bữa tối', N'Ăn uống', 150.000),
(N'Massage toàn thân', N'Thư giãn', 300.000),
(N'Spa mặt', N'Thư giãn', 200.000),
(N'Dọn phòng', N'Dịch vụ phòng', 30.000),
(N'Internet tốc độ cao', N'Tiện ích', 40.000),
(N'Xe đưa đón sân bay', N'Vận chuyển', 250.000),
(N'Cho thuê xe máy', N'Vận chuyển', 100.000),
(N'In ấn tài liệu', N'Dịch vụ khác', 10.000),
(N'Tour tham quan', N'Du lịch', 500.000),
(N'Hướng dẫn viên', N'Du lịch', 400.000),
(N'Bảo mẫu trẻ em', N'Dịch vụ gia đình', 180.000),
(N'Khóa học yoga', N'Giải trí', 200.000);

-- Giả định RoomTypeId: 1 = Phòng đơn, 2 = Phòng đôi, 3 = 2 giường đơn, 4 = 2 giường đôi
INSERT INTO Rooms (RoomNumber, RoomTypeId, Notes)
VALUES
('101', 1, NULL), 
('102', 1, NULL), 
('201', 2, NULL),
('202', 2, NULL),
('301', 3, NULL),
('302', 3, NULL),
('401', 4, NULL),
('402', 4, NULL);

-- Giả định dùng CustomerId từ 1 đến 3, StaffId là 2 hoặc 3 (vì StaffId 1 là quản lý)
INSERT INTO Invoices (CustomerId, StaffId, InvoiceDate, TotalAmount, PaymentType)
VALUES
(1, 2, '2024-05-01', 500.000, N'Thẻ tín dụng'),
(2, 3, '2024-05-02', 700.000, N'Tiền mặc'),
(3, 2, '2024-05-03', 650.000, N'Thẻ tín dụng');

-- Booking theo các InvoiceId tương ứng từ trên, gán các phòng đang sử dụng (RoomId = 2, 4, 6)
INSERT INTO Bookings (InvoiceId, RoomId, GuestQuantity, CheckInDate, CheckOutDate, TotalAmount)
VALUES
(1, 2, 1,'2024-05-01', '2024-05-03', NULL),
(2, 4, 2,'2024-05-02', '2024-05-05', NULL),
(3, 6, 2,'2024-05-03', '2024-05-04', NULL);

-- Dùng các ServiceId từ 1 đến 5 cho đa dạng, giả định mỗi khách sử dụng một vài dịch vụ
INSERT INTO ServiceUses (InvoiceId, ServiceId, ServiceQuantity, TotalAmount)
VALUES
(1, 1, 2, NULL),   -- Invoice 1 dùng 2 chai nước suối
(1, 2, 1, NULL),   -- Invoice 1 dùng 1 coca
(2, 4, 1, NULL),   -- Invoice 2 dùng 1 dịch vụ giặt ủi
(3, 3, 2, NULL);   -- Invoice 3 dùng 2 cà phê


-- Chỉnh sửa file ảnh
ALTER TABLE RoomTypes
ALTER COLUMN RoomTypeImg nvarchar(max);

