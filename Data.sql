CREATE DATABASE QuanLyQuanCaPhe
GO

USE QuanLyQuanCaPhe
GO

-- Các bảng trong Cơ sở dữ liệu
-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood 
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Ban chua co ten',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trong' -- Trong || Co nguoi
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Kter', 	
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- 1: admin || 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chua dat ten'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chua dat ten',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES FoodCategory(id)
)
GO

CREATE TABLE Bill
(
    id INT IDENTITY PRIMARY KEY,
    DateCheckIn DATE NOT NULL,
    DateCheckOut DATE,
    idTable INT NOT NULL,
    status INT NOT NULL DEFAULT 0, -- 1: Đã thanh toán || 0: Chưa thanh toán
    discount INT NOT NULL DEFAULT 0, -- Giảm giá mặc định là 0
    totalPrice FLOAT, -- Tổng giá
    
    FOREIGN KEY (idTable) REFERENCES TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES Bill(id),
	FOREIGN KEY (idFood) REFERENCES Food(id)
)
GO

-- Thêm tài khoản Người dùng và Admin
INSERT INTO Account (UserName, DisplayName, PassWord, Type) 
VALUES  (N'K9', N'RongK9', N'1', 1),
		(N'staff', N'staff', N'1', 0)
GO

INSERT INTO TableFood (name, status)
VALUES 
    (N'Ban 1', N'Trong'),
    (N'Ban 2', N'Co nguoi'),
    (N'Ban 3', N'Trong'),
    (N'Ban 4', N'Co nguoi'),
    (N'Ban 5', N'Trong'),
    (N'Ban 6', N'Co nguoi'),
    (N'Ban 7', N'Trong'),
    (N'Ban 8', N'Co nguoi'),
    (N'Ban 9', N'Trong'),
    (N'Ban 10', N'Co nguoi'),
    (N'Ban 11', N'Trong'),
    (N'Ban 12', N'Co nguoi'),
    (N'Ban 13', N'Trong'),
    (N'Ban 14', N'Co nguoi'),
    (N'Ban 15', N'Trong'),
    (N'Ban 16', N'Co nguoi'),
    (N'Ban 17', N'Trong'),
    (N'Ban 18', N'Co nguoi'),
    (N'Ban 19', N'Trong'),
    (N'Ban 20', N'Co nguoi'),
    (N'Ban 21', N'Trong'),
    (N'Ban 22', N'Co nguoi'),
    (N'Ban 23', N'Trong'),
    (N'Ban 24', N'Co nguoi'),
    (N'Ban 25', N'Trong'),
    (N'Ban 26', N'Co nguoi'),
    (N'Ban 27', N'Trong'),
    (N'Ban 28', N'Co nguoi'),
    (N'Ban 29', N'Trong'),
    (N'Ban 30', N'Co nguoi');
GO

INSERT INTO FoodCategory (name)
VALUES 
    (N'Khách Vị'),
    (N'Món Chính'),
    (N'Tráng Miệng'),
    (N'Đồ Uống'),
    (N'Súp'),
    (N'Salad'),
    (N'Đặc Biệt'),
    (N'Ăn Vặt'),
    (N'Chay'),
    (N'Món Mặn');
GO

INSERT INTO Food (name, idCategory, price)
VALUES 
    -- Khách Vị
    (N'Chả Giò', 1, 50000),
    (N'Bánh Xèo', 1, 60000),
    (N'Bánh Mì Nướng Tỏi', 1, 45000),
    (N'Bruschetta', 1, 55000),
    (N'Cánh Gà Nướng', 1, 70000),

    -- Món Chính
    (N'Gà Nướng', 2, 120000),
    (N'Bít Tết', 2, 150000),
    (N'Mỳ Ý Alfredo', 2, 110000),
    (N'Rau Củ Quay', 2, 180000),
    (N'Fish & Chips', 2, 95000),

    -- Tráng Miệng
    (N'Cheesecake', 3, 70000),
    (N'Bánh Chocolate', 3, 75000),
    (N'Bánh Táo', 3, 65000),
    (N'Kem Sundae', 3, 50000),
    (N'Panna Cotta', 3, 80000),

    -- Đồ Uống
    (N'Cà Phê', 4, 30000),
    (N'Trà', 4, 25000),
    (N'Nước Ngọt', 4, 20000),
    (N'Nước Ép', 4, 35000),
    (N'Cocktail', 4, 80000),

    -- Súp
    (N'Súp Gà', 5, 60000),
    (N'Súp Minestrone', 5, 55000),
    (N'Súp Rau Củ', 5, 50000),
    (N'Hầm Bò', 5, 70000),
    (N'Súp Đậu Lăng', 5, 65000),

    -- Salad
    (N'Salad Caesar', 6, 50000),
    (N'Salad Hy Lạp', 6, 55000),
    (N'Salad Bắp Cải', 6, 45000),
    (N'Salad Caprese', 6, 60000),
    (N'Salad Pasta', 6, 55000),

    -- Đặc Biệt
    (N'Cá Hồi Nướng', 7, 140000),
    (N'Sườn Nướng BBQ', 7, 160000),
    (N'Burger Chay', 7, 110000),
    (N'Bò Nướng', 7, 150000),
    (N'Bánh Cua', 7, 120000),

    -- Ăn Vặt
    (N'Nachos', 8, 55000),
    (N'Que Phô Mai', 8, 60000),
    (N'Popcorn', 8, 30000),
    (N'Hành Tây Chiên', 8, 50000),
    (N'Gà Cắt Miếng', 8, 70000),

    -- Chay
    (N'Pizza Chay', 9, 120000),
    (N'Falafel', 9, 55000),
    (N'Salad Quinoa', 9, 60000),
    (N'Wrap Chay', 9, 50000),
    (N'Risotto Nấm', 9, 70000),

    -- Món Mặn
    (N'Burger Bò', 10, 95000),
    (N'Gà Xào Tỏi', 10, 140000),
    (N'Cà Ri Gà', 10, 110000),
    (N'Pizza Xúc Xích', 10, 130000),
    (N'Parmesan Gà', 10, 120000);
GO

INSERT INTO Bill (DateCheckIn, DateCheckOut, idTable, status, discount, totalPrice)
VALUES 
    (CAST(N'2024-08-01' AS DATE), CAST(N'2024-08-01' AS DATE), 1, 1, 10, 50000),
    (CAST(N'2024-08-02' AS DATE), CAST(N'2024-08-02' AS DATE), 2, 1, 15, 75000),
    (CAST(N'2024-08-03' AS DATE), CAST(N'2024-08-03' AS DATE), 3, 1, 5, 30000),
    (CAST(N'2024-08-04' AS DATE), CAST(N'2024-08-04' AS DATE), 4, 1, 20, 80000),
    (CAST(N'2024-08-05' AS DATE), CAST(N'2024-08-05' AS DATE), 5, 1, 10, 40000),
    (CAST(N'2024-08-06' AS DATE), CAST(N'2024-08-06' AS DATE), 6, 1, 25, 100000),
    (CAST(N'2024-08-07' AS DATE), CAST(N'2024-08-07' AS DATE), 7, 0, 0, 0),
    (CAST(N'2024-08-08' AS DATE), CAST(N'2024-08-08' AS DATE), 8, 1, 10, 55000),
    (CAST(N'2024-08-09' AS DATE), CAST(N'2024-08-09' AS DATE), 9, 1, 15, 70000),
    (CAST(N'2024-08-10' AS DATE), CAST(N'2024-08-10' AS DATE), 10, 1, 5, 30000),
    (CAST(N'2024-08-11' AS DATE), CAST(N'2024-08-11' AS DATE), 11, 1, 20, 85000),
    (CAST(N'2024-08-12' AS DATE), CAST(N'2024-08-12' AS DATE), 12, 1, 10, 45000),
    (CAST(N'2024-08-13' AS DATE), CAST(N'2024-08-13' AS DATE), 13, 1, 25, 95000),
    (CAST(N'2024-08-14' AS DATE), CAST(N'2024-08-14' AS DATE), 14, 1, 15, 75000),
    (CAST(N'2024-08-15' AS DATE), CAST(N'2024-08-15' AS DATE), 15, 1, 10, 50000),
    (CAST(N'2024-08-16' AS DATE), CAST(N'2024-08-16' AS DATE), 16, 1, 20, 80000),
    (CAST(N'2024-08-17' AS DATE), CAST(N'2024-08-17' AS DATE), 17, 1, 5, 35000),
    (CAST(N'2024-08-18' AS DATE), CAST(N'2024-08-18' AS DATE), 18, 1, 25, 95000),
    (CAST(N'2024-08-19' AS DATE), CAST(N'2024-08-19' AS DATE), 19, 1, 15, 70000),
    (CAST(N'2024-08-20' AS DATE), CAST(N'2024-08-20' AS DATE), 20, 1, 10, 55000),
    (CAST(N'2024-08-21' AS DATE), CAST(N'2024-08-21' AS DATE), 21, 1, 5, 30000),
    (CAST(N'2024-08-22' AS DATE), CAST(N'2024-08-22' AS DATE), 22, 1, 20, 85000),
    (CAST(N'2024-08-23' AS DATE), CAST(N'2024-08-23' AS DATE), 23, 1, 10, 45000),
    (CAST(N'2024-08-24' AS DATE), CAST(N'2024-08-24' AS DATE), 24, 1, 25, 95000),
    (CAST(N'2024-08-25' AS DATE), CAST(N'2024-08-25' AS DATE), 25, 1, 15, 75000);
GO

INSERT INTO BillInfo (idBill, idFood, count)
VALUES 
    -- Bill 1
    (1, 1, 2),  -- Cà Phê
    (1, 2, 1),  -- Trái Cây Ép
    
    -- Bill 2
    (2, 3, 1),  -- Nước Ngọt
    (2, 4, 2),  -- Nước Ép
    
    -- Bill 3
    (3, 5, 3),  -- Sinh Tố
    (3, 6, 1),  -- Trà Sữa
    
    -- Bill 4
    (4, 7, 2),  -- Cacao
    (4, 8, 1),  -- Cocktail
    
    -- Bill 5
    (5, 9, 2),  -- Soda
    (5, 10, 1), -- Bia
    
    -- Bill 6
    (6, 11, 1), -- Phở
    (6, 12, 1), -- Bún Chả
    
    -- Bill 7
    (7, 13, 2), -- Xúc Xích BBQ
    (7, 14, 1), -- Xúc Xích Đức
    
    -- Bill 8
    (8, 15, 1), -- Tiramisu
    (8, 16, 2), -- Cheesecake
    
    -- Bill 9
    (9, 17, 2), -- Mousse
    (9, 18, 1), -- Brownie
    
    -- Bill 10
    (10, 19, 1), -- Pudding
    (10, 20, 1), -- Bánh Mì Thịt
    
    -- Bill 11
    (11, 21, 2), -- Bánh Mì Chả
    (11, 22, 1), -- Bánh Mì Xíu Mại
    
    -- Bill 12
    (12, 23, 1), -- Bánh Mì Đà Nẵng
    (12, 24, 2), -- Bánh Mì Kẹp Phô Mai
    
    -- Bill 13
    (13, 25, 2), -- Bánh Mì Thịt
    (13, 26, 1), -- Bánh Mì Chả
    
    -- Bill 14
    (14, 27, 3), -- Bánh Mì Xíu Mại
    (14, 28, 2), -- Bánh Mì Đà Nẵng
    
    -- Bill 15
    (15, 29, 1), -- Bánh Mì Kẹp Phô Mai
    (15, 30, 1); -- Bánh Mì Thịt
GO


-- Danh sách các PROC --------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM TableFood
Go

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT Bill(DateCheckIn, DateCheckOut, idTable, status, discount)
	VALUES (GETDATE(), NULL, @idTable, 0, 0)
END
GO

CREATE PROC USP_InsertBillInfo
    @idBill INT,
    @idFood INT,
    @count INT
AS
BEGIN
    DECLARE @isExitsBillInfo INT;
    DECLARE @foodCount INT = 1;

    SELECT @isExitsBillInfo = b.id, @foodCount = b.count 
    FROM BillInfo AS b 
    WHERE idBill = @idBill AND idFood = @idFood;

    IF (@isExitsBillInfo > 0)
    BEGIN
        DECLARE @newCount INT = @foodCount + @count
        IF (@newCount > 0)
        BEGIN
            UPDATE BillInfo 
            SET count = @foodCount + @count
            WHERE idFood = @idFood AND idBill = @idBill
        END
        ELSE 
        BEGIN
            DELETE FROM BillInfo 
            WHERE idBill = @idBill AND idFood = @idFood
        END
    END
    ELSE
    BEGIN
        INSERT INTO BillInfo (idBill, idFood, count)
        VALUES (@idBill, @idFood, @count);
    END
END
GO

CREATE TRIGGER UTG_UpdateBillInfo
ON BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBIll INT

	SELECT @idBIll = idBill FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM Bill WHERE id = @idBill AND status = 0

	DECLARE @count INT
	SELECT @count = COUNT(*) FROM BillInfo WHERE idBill = @idBIll

	IF (@count > 0)
		UPDATE TableFood  SET status = N'Co nguoi' WHERE id = @idTable
	ELSE
		UPDATE TableFood  SET status = N'Trong' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateTable
ON TableFood FOR UPDATE
AS
BEGIN
	DECLARE @idTable INT
	DECLARE @status NVARCHAR(100)
	SELECT @idTable = id, @status = inserted.status FROM Inserted

	DECLARE @idBill INT
	SELECT @idBill = id FROM Bill WHERE idTable = @idTable AND Status = 0

	DECLARE @countBillInfo INT
	SELECT @countBillInfo = COUNT(*) FROM BillInFo WHERE idBill = @idBill

	IF (@countBillInfo > 0 AND @status <> N'Co nguoi')
		UPDATE TableFood  SET status = N'Co nguoi' WHERE id = @idTable
	ELSE IF (@countBillInfo <= 0 AND @status <> N'Trong')
		UPDATE TableFood  SET status = N'Trong' WHERE id = @idTable

END
GO

CREATE TRIGGER UTG_UpdateBill
ON Bill FOR UPDATE
AS
BEGIN	
	DECLARE @idBill INT

	SELECT @idBill = id FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM Bill WHERE id = @idBill

	DECLARE @count INT = 0;

	SELECT @count = count(*) FROM Bill WHERE idTable = @idTable AND status = 0

	IF (@count = 0)
		UPDATE TableFood SET status = N'Trong' WHERE id = @idTable
END
GO

CREATE PROC USP_SwitchTable
@idTable1 INT, @idTable2 INT
AS 
BEGIN
	
	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT

	DECLARE @isFirstTableEmpty INT = 1
	DECLARE @isSecondTableEmpty INT = 1

	SELECT @idSecondBill = id FROM Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM Bill WHERE idTable = @idTable1 AND status = 0

	IF (@idFirstBill IS NULL)
	BEGIN
		INSERT INTO Bill(DateCheckIn, DateCheckOut, idTable, status)
		VALUES (GETDATE(), NULL, @idTable1, 0)
		SELECT @idFirstBill = MAX (id) FROM Bill WHERE idTable = @idTable1 AND status = 0
	END

	SELECT @isFirstTableEmpty = COUNT(*) FROM BillInfo WHERE idBill = @idFirstBill

		IF (@idSecondBill IS NULL)
	BEGIN
		INSERT INTO Bill(DateCheckIn, DateCheckOut, idTable, status)
		VALUES (GETDATE(), NULL, @idTable2, 0)
		SELECT @idSecondBill = MAX (id) FROM Bill WHERE idTable = @idTable2 AND status = 0
	END
	
	SELECT @isSecondTableEmpty = COUNT(*) FROM BillInfo WHERE idBill = @idSecondBill

	SELECT id INTO IDBillInfoTable FROM BillInfo WHERE idBill = @idSecondBill

	UPDATE BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill

	UPDATE BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)

	DROP TABLE IDBillInfoTable

	IF (@isFirstTableEmpty = 0)
		UPDATE TableFood SET status = N'Trong' WHERE id = @idTable2
		
		IF (@isSecondTableEmpty = 0)
		UPDATE TableFood SET status = N'Trong' WHERE id = @idTable1
END
GO


/*CREATE PROC USP_MergeTable
    @idTable1 INT, 
    @idTable2 INT
AS 
BEGIN
    DECLARE @idFirstBill INT;
    DECLARE @idSecondBill INT;

    -- Lấy ID của hóa đơn tương ứng với mỗi bàn
    SELECT @idFirstBill = id FROM Bill WHERE idTable = @idTable1 AND status = 0;
    SELECT @idSecondBill = id FROM Bill WHERE idTable = @idTable2 AND status = 0;

    -- Cập nhật BillInfo để gộp hóa đơn của bàn @idTable1 vào hóa đơn của bàn @idTable2
    UPDATE BillInfo 
    SET idBill = @idSecondBill 
    WHERE idBill = @idFirstBill;

    -- Cập nhật trạng thái của bàn 1 thành 'Trong'
    UPDATE TableFood 
    SET status = N'Trong' 
    WHERE id = @idTable1;

    -- Tuỳ chọn: Xóa hóa đơn cũ của @idFirstBill nếu cần thiết
    DELETE FROM Bill WHERE id = @idFirstBill;
END
GO
*/


CREATE PROC USP_GetListBillByDate
@checkIn date, @checkOut date
AS
BEGIN
	SELECT b.id AS [ID], t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền],
	DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra],
	discount AS [Giảm giá]
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn 
		AND DateCheckOut <= @checkOut
		AND b.status = 1
		AND t.id = b.idTable
END
GO

CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), 
@password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT

	SELECT @isRightPass = COUNT(*) FROM Account WHERE UserName = @userName AND PassWord = @password

	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword IS NULL OR @newPassword = N'')
		BEGIN
			UPDATE Account SET DisplayName = @displayName WHERE UserName = @userName
		END
		ELSE
			UPDATE Account SET DisplayName = @displayName, Password = @newPassword WHERE UserName = @userName
	END
END
GO

CREATE TRIGGER UTG_DeleteBillInfo
ON BillInfo
FOR DELETE
AS
BEGIN
    -- Tạo bảng tạm để lưu trữ các idBill bị ảnh hưởng
    DECLARE @BillIds TABLE (idBill INT);

    -- Chèn tất cả các idBill từ bảng Deleted vào bảng tạm
    INSERT INTO @BillIds (idBill)
    SELECT idBill
    FROM Deleted;

    -- Cập nhật trạng thái cho các bảng TableFood liên quan
    UPDATE TableFood
    SET status = N'Trong'
    WHERE id IN (
        SELECT b.idTable
        FROM Bill b
        LEFT JOIN BillInfo bi ON b.id = bi.idBill
        WHERE b.id IN (SELECT idBill FROM @BillIds)
        GROUP BY b.idTable
        HAVING COUNT(bi.idBill) = 0
    );
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL 
		RETURN @strInput 
	IF @strInput = '' 
		RETURN @strInput 

	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
				BEGIN 
					IF @COUNTER=1 
						SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
					ELSE 
						SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK 
				END 
			SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 
		END 
	SET @strInput = replace(@strInput,' ','-') 
	RETURN @strInput 
END
GO

/*
CREATE TRIGGER USP_DeleteBill
ON Bill
FOR DELETE
AS
BEGIN
    -- Xóa các bản ghi phụ thuộc trong bảng BillInfo
    DELETE FROM BillInfo
    WHERE idBill IN (SELECT id FROM Deleted);
    
    -- Xóa các bản ghi trong bảng Bill
    DELETE FROM Bill
    WHERE id IN (SELECT id FROM Deleted);
END
GO
*/

CREATE TRIGGER TRG_DeleteTableFood
ON TableFood
FOR DELETE
AS
BEGIN
    -- Xóa BillInfo liên quan đến các Bill
    DELETE FROM BillInfo
    WHERE idBill IN (SELECT id FROM Bill WHERE idTable IN (SELECT id FROM Deleted));

    -- Xóa Bill liên quan đến các TableFood
    DELETE FROM Bill
    WHERE idTable IN (SELECT id FROM Deleted);

    -- Xóa TableFood
    DELETE FROM TableFood
    WHERE id IN (SELECT id FROM Deleted);
END
GO

CREATE PROC USP_GetListBillByDateAndPage
@checkIn date, @checkOut date, @page INT
AS
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows

	;WITH BillShow AS (SELECT b.id AS [ID], t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền],
	DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra],
	discount AS [Giảm giá]
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn 
		AND DateCheckOut <= @checkOut
		AND b.status = 1
		AND t.id = b.idTable)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN
	(SELECT TOP (@exceptRows) id FROM BillShow)
END
GO

CREATE PROC USP_GetNumBillByDate
@checkIn date, @checkOut date
AS
BEGIN
	SELECT COUNT(*)
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn 
		AND DateCheckOut <= @checkOut
		AND b.status = 1
		AND t.id = b.idTable
END
GO

CREATE PROC USP_GetListBillByDateForReport
@checkIn date, @checkOut date
AS
BEGIN
	SELECT b.id AS [ID], t.name AS [Table Name], b.totalPrice AS [Total Price],
	DateCheckIn AS [Day Check In], DateCheckOut AS [Date Check Out],
	discount AS [Discount]
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn 
		AND DateCheckOut <= @checkOut
		AND b.status = 1
		AND t.id = b.idTable
END
GO