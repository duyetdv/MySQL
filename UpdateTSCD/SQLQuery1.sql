CREATE DATABASE TSCD
GO
USE TSCD
GO

CREATE TABLE DanhSachTSCD
(
	ID INT PRIMARY KEY IDENTITY,
	LoaiTS NVARCHAR(30),
	ThongSo NVARCHAR(100),
	Photo VARCHAR(100),
	NguoiSD VARCHAR(6),
	TinhTrang NVARCHAR(30),
	GhiChu NVARCHAR(100),
	NgayTao DATETIME
)
GO
SELECT dst.ID, dst.LoaiTS, dst.ThongSo, dst.Photo, dst.NguoiSD, dst.TinhTrang, dst.GhiChu, dst.NgayTao FROM DanhSachTSCD dst
GO

INSERT INTO DanhSachTSCD (LoaiTS, ThongSo, Photo, NguoiSD, TinhTrang, GhiChu, NgayTao)
	VALUES ('', N'', '', '', N'', N'', GETDATE());

	UPDATE DanhSachTSCD 
SET LoaiTS = N''   ,ThongSo = N''   ,Photo = ''   ,NguoiSD = ''   ,TinhTrang = N''   ,GhiChu = N''   ,NgayTao = GETDATE() WHERE ID = 0;
