-- Triggers
USE DAQLKS;
GO

DROP TRIGGER CheckGuestQuantity;
DROP TRIGGER InsertAmountService;
DROP TRIGGER UpdateAmountService;
DROP TRIGGER InsertAmountBooking;
DROP TRIGGER UpdateAmountBooking;

-- kiểm tra số lượng khách không vượt quá sức chứa phòng
CREATE TRIGGER CheckGuestQuantity ON Bookings
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT *
        FROM inserted i
        JOIN Rooms r ON r.RoomID = i.RoomID
        JOIN RoomTypes rt ON r.RoomTypeID = rt.RoomTypeID
        WHERE i.GuestQuantity > rt.Capacity
    )
    BEGIN
        RAISERROR ('Guest quantity must be less than or equal to room capacity', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
GO

-- cập nhật tổng tiền dịch vụ khi thêm mới
CREATE TRIGGER InsertAmountService ON ServiceUses
FOR INSERT
AS
BEGIN
    -- Update ServiceUses
    UPDATE su
    SET su.TotalAmount = s.ServicePrice * i.ServiceQuantity
    FROM ServiceUses su
    JOIN inserted i ON su.ServiceID = i.ServiceID AND su.InvoiceID = i.InvoiceID
    JOIN Services s ON i.ServiceID = s.ServiceID;

    -- Update Invoices
    UPDATE inv
    SET inv.TotalAmount = inv.TotalAmount + i.TotalAmount
    FROM Invoices inv
    JOIN (
        SELECT su.InvoiceID, SUM(su.TotalAmount) AS TotalAmount
        FROM ServiceUses su
        JOIN inserted i ON su.InvoiceID = i.InvoiceID AND su.ServiceID = i.ServiceID
        GROUP BY su.InvoiceID
    ) i ON inv.InvoiceID = i.InvoiceID;
END;
GO

-- cập nhật tổng tiền khi cập nhật dịch vụ
CREATE TRIGGER UpdateAmountService ON ServiceUses
FOR UPDATE
AS
BEGIN
    -- Update ServiceUses
    UPDATE su
    SET su.TotalAmount = s.ServicePrice * i.ServiceQuantity
    FROM ServiceUses su
    JOIN inserted i ON su.ServiceID = i.ServiceID AND su.InvoiceID = i.InvoiceID
    JOIN Services s ON i.ServiceID = s.ServiceID;

    -- Update Invoices
    UPDATE inv
    SET inv.TotalAmount = inv.TotalAmount + i.TotalAmount
    FROM Invoices inv
    JOIN (
        SELECT i.InvoiceID,
               SUM(i.ServiceQuantity * s.ServicePrice - d.ServiceQuantity * s.ServicePrice) AS TotalAmount
        FROM inserted i
        JOIN deleted d ON i.InvoiceID = d.InvoiceID AND i.ServiceID = d.ServiceID
        JOIN Services s ON i.ServiceID = s.ServiceID
        GROUP BY i.InvoiceID
    ) i ON inv.InvoiceID = i.InvoiceID;
END;
GO

-- cập nhật tổng tiền đặt phòng khi thêm mới
CREATE TRIGGER InsertAmountBooking ON Bookings
FOR INSERT
AS
BEGIN
    -- Update Bookings
    UPDATE b
    SET b.TotalAmount = rt.RoomPrice * DATEDIFF(DAY, i.CheckInDate, i.CheckOutDate)
    FROM Bookings b
    JOIN inserted i ON b.BookingID = i.BookingID AND b.RoomID = i.RoomID
    JOIN Rooms r ON r.RoomID = i.RoomID
    JOIN RoomTypes rt ON rt.RoomTypeID = r.RoomTypeID;

    -- Update Invoices
    UPDATE inv
    SET inv.TotalAmount = inv.TotalAmount + i.TotalAmount
    FROM Invoices inv
    JOIN (
        SELECT b.InvoiceID, SUM(b.TotalAmount) AS TotalAmount
        FROM Bookings b
        JOIN inserted i ON b.BookingID = i.BookingID
        GROUP BY b.InvoiceID
    ) i ON inv.InvoiceID = i.InvoiceID;
END;
GO

-- cập nhật tổng tiền đặt phòng khi cập nhật
CREATE TRIGGER UpdateAmountBooking ON Bookings
FOR UPDATE
AS
BEGIN
    -- Update Bookings
    UPDATE b
    SET b.TotalAmount = rt.RoomPrice * DATEDIFF(DAY, i.CheckInDate, i.CheckOutDate)
    FROM Bookings b
    JOIN inserted i ON b.BookingID = i.BookingID AND b.RoomID = i.RoomID
    JOIN Rooms r ON r.RoomID = i.RoomID
    JOIN RoomTypes rt ON rt.RoomTypeID = r.RoomTypeID
    JOIN deleted d ON d.BookingID = i.BookingID
    WHERE d.CheckOutDate <= i.CheckOutDate AND i.CheckInDate <= d.CheckInDate;

    -- Update Invoices
    UPDATE inv
    SET inv.TotalAmount = inv.TotalAmount + i.TotalAmount1 + i.TotalAmount2
    FROM Invoices inv
    JOIN (
        SELECT i.InvoiceID,
               SUM(rt.RoomPrice * DATEDIFF(DAY, d.CheckOutDate, i.CheckOutDate)) AS TotalAmount1,
               SUM(rt.RoomPrice * DATEDIFF(DAY, i.CheckInDate, d.CheckInDate)) AS TotalAmount2
        FROM inserted i
        JOIN deleted d ON d.BookingID = i.BookingID
        JOIN Rooms r ON r.RoomID = i.RoomID
        JOIN RoomTypes rt ON rt.RoomTypeID = r.RoomTypeID
        WHERE d.CheckOutDate <= i.CheckOutDate AND i.CheckInDate <= d.CheckInDate
        GROUP BY i.InvoiceID
    ) i ON inv.InvoiceID = i.InvoiceID;
END;
GO
