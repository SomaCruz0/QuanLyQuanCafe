Create proc USP_GetTableList
As Select * from dbo.BAN
Go


create PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.HOADON 
	        (NGAYHOADON, 
	          BAN,
	          TRANGTHAI
	        )
	VALUES  ( GETDATE() , 
	          @idTable ,
	          0
	        )
END
GO

CREATE PROC [dbo].[USP_SwitchTabel]
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = MAHOADON FROM dbo.HOADON WHERE BAN = @idTable2 AND status = 0
	SELECT @idFirstBill = MAHOADON FROM dbo.HOADON WHERE BAN = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.HOADON
		        ( NGAYHOADON,
		          BAN ,
		          TRANGTHAI
		        )
		VALUES  ( GETDATE() , 
		          @idTable1 , 
		          0  
		        )
		        
		SELECT @idFirstBill = MAX(MAHOADON) FROM dbo.HOADON WHERE BAN = @idTable1 AND status = 0
		
	END

	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.CTHD WHERE MAHOADON = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.HOADON
		        ( NGAYHOADON,
		          BAN ,
		          TRANGTHAI
		        )
		VALUES  ( GETDATE() , 
		          @idTable2 ,
		          0 
		        )
		SELECT @idSeconrdBill = MAX(MAHOADON) FROM dbo.HOADON WHERE BAN = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.CTHD WHERE MAHOADON = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT MACTHD INTO IDBillInfoTable FROM dbo.CTHD WHERE MAHOADON = @idSeconrdBill
	
	UPDATE dbo.CTHD SET MAHOADON = @idSeconrdBill WHERE MAHOADON = @idFirstBill
	
	UPDATE dbo.CTHD SET MAHOADON = @idFirstBill WHERE MAHOADON IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.BAN SET status = N'Trống' WHERE MABAN = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.BAN SET status = N'Trống' WHERE MABAN = @idTable1
END
GO