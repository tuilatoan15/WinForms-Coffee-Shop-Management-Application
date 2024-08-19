CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
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
	status INT NOT NULL DEFAULT 0-- 1: Da thanh toan || 0: Chua thanh toan

	FOREIGN KEY (idTable) REFERENCES TableFood(id)
)
GO

ALTER TABLE Bill
ADD discount INT
GO
UPDATE Bill SET discount = 0
GO
ALTER TABLE Bill ADD totalPrice FLOAT
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

-- Chèn dữ liệu vào bảng TableFood với id từ 20 đến 49
INSERT INTO TableFood (name, status)
VALUES
(N'Ban 20', 'Trong'),
(N'Ban 21', 'Trong'),
(N'Ban 22', 'Trong'),
(N'Ban 23', 'Trong'),
(N'Ban 24', 'Trong'),
(N'Ban 25', 'Trong'),
(N'Ban 26', 'Trong'),
(N'Ban 27', 'Trong'),
(N'Ban 28', 'Trong'),
(N'Ban 29', 'Trong'),
(N'Ban 30', 'Trong'),
(N'Ban 31', 'Trong'),
(N'Ban 32', 'Trong'),
(N'Ban 33', 'Trong'),
(N'Ban 34', 'Trong'),
(N'Ban 35', 'Trong'),
(N'Ban 36', 'Trong'),
(N'Ban 37', 'Trong'),
(N'Ban 38', 'Trong'),
(N'Ban 39', 'Trong'),
(N'Ban 40', 'Trong'),
(N'Ban 41', 'Trong'),
(N'Ban 42', 'Trong'),
(N'Ban 43', 'Trong'),
(N'Ban 44', 'Trong'),
(N'Ban 45', 'Trong'),
(N'Ban 46', 'Trong'),
(N'Ban 47', 'Trong'),
(N'Ban 48', 'Trong'),
(N'Ban 49', 'Trong'),
(N'Ban 50', 'Trong');
GO

-- Chèn dữ liệu vào bảng FoodCategory
INSERT INTO FoodCategory (name)
VALUES
(N'Nước'),
(N'Cà phê'),
(N'Thực phẩm'),
(N'Kẹo'),
(N'Bánh');
GO

-- Chèn dữ liệu vào bảng Food với giá từ 10000 đến 50000
INSERT INTO Food (name, idCategory, price)
VALUES
-- Nhóm Nước
(N'Nước khoáng', 1, 15000),
(N'Nước trái cây', 1, 20000),
(N'Nước ngọt', 1, 25000),
(N'Nước lọc', 1, 10000),
(N'Nước chanh', 1, 18000),

-- Nhóm Cà phê
(N'Cà phê đen', 2, 30000),
(N'Cà phê sữa đá', 2, 35000),
(N'Cà phê latte', 2, 40000),
(N'Cà phê cappuccino', 2, 45000),
(N'Cà phê mocha', 2, 50000),

-- Nhóm Thực phẩm
(N'Bánh mì kẹp thịt', 3, 30000),
(N'Phở bò', 3, 40000),
(N'Gà chiên', 3, 35000),
(N'Súp rau', 3, 25000),
(N'Xôi xéo', 3, 28000),

-- Nhóm Kẹo
(N'Kẹo dẻo', 4, 12000),
(N'Kẹo mút', 4, 15000),
(N'Kẹo socola', 4, 20000),
(N'Kẹo gôm', 4, 18000),
(N'Kẹo bạc hà', 4, 16000),

-- Nhóm Bánh
(N'Bánh ngọt', 5, 25000),
(N'Bánh quy', 5, 18000),
(N'Bánh kem', 5, 30000),
(N'Bánh su', 5, 22000),
(N'Bánh bao', 5, 15000);
GO

-- Chèn dữ liệu vào bảng Bill với idTable từ 20 đến 50
INSERT INTO Bill (DateCheckIn, DateCheckOut, idTable, status)
VALUES
(GETDATE(), NULL, 1, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 2, 1), -- Đã thanh toán
(GETDATE(), NULL, 3, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 4, 1), -- Đã thanh toán
(GETDATE(), NULL, 5, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 6, 1), -- Đã thanh toán
(GETDATE(), NULL, 7, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 8, 1), -- Đã thanh toán
(GETDATE(), NULL, 9, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 10, 1), -- Đã thanh toán
(GETDATE(), NULL, 11, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 12, 1), -- Đã thanh toán
(GETDATE(), NULL, 13, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 14, 1), -- Đã thanh toán
(GETDATE(), NULL, 15, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 16, 1), -- Đã thanh toán
(GETDATE(), NULL, 17, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 18, 1), -- Đã thanh toán
(GETDATE(), NULL, 19, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 20, 1), -- Đã thanh toán
(GETDATE(), NULL, 21, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 22, 1), -- Đã thanh toán
(GETDATE(), NULL, 23, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 24, 1), -- Đã thanh toán
(GETDATE(), NULL, 25, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 26, 1), -- Đã thanh toán
(GETDATE(), NULL, 27, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 28, 1), -- Đã thanh toán
(GETDATE(), NULL, 29, 0),  -- Chưa thanh toán
(GETDATE(), GETDATE(), 30, 1), -- Đã thanh toán
(GETDATE(), NULL, 31, 0);  -- Chưa thanh toán
GO

-- Chèn dữ liệu vào bảng BillInfo
INSERT INTO BillInfo (idBill, idFood, count)
VALUES
(14, 1, 2),
(14, 2, 3),
(15, 3, 1),
(15, 4, 4),
(16, 5, 2),
(16, 6, 3),
(17, 7, 1),
(17, 8, 5),
(18, 9, 2),
(18, 10, 4),
(19, 11, 3),
(19, 12, 2),
(20, 13, 1),
(20, 14, 3),
(21, 15, 2),
(22, 1, 5),
(22, 2, 1),
(23, 3, 2),
(23, 4, 4),
(24, 5, 3),
(24, 6, 1),
(25, 7, 2),
(25, 8, 4),
(26, 9, 5),
(27, 10, 1),
(27, 11, 2),
(28, 12, 3),
(28, 13, 4),
(29, 14, 1),
(29, 15, 2),
(30, 1, 3),
(30, 2, 4),
(31, 3, 5),
(32, 4, 1),
(32, 5, 2),
(33, 6, 3),
(33, 7, 4),
(34, 8, 5),
(35, 9, 1),
(35, 10, 2),
(36, 11, 3),
(37, 12, 4),
(37, 13, 5),
(38, 14, 1),
(39, 15, 2),
(40, 1, 3),
(41, 2, 4),
(42, 3, 5),
(43, 4, 1),
(44, 5, 2);
GO

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

CREATE TRIGGER USP_DeleteBill
ON Bill
FOR DELETE
AS
BEGIN
    -- Xóa tất cả các bản ghi trong bảng BillInfo có idBill tương ứng với các bản ghi bị xóa trong bảng Bill
    DELETE FROM BillInfo
    WHERE idBill IN (SELECT id FROM Deleted);
END
GO

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