CREATE TABLE [dbo].[NhanVien]
(
	[MaNV] INT NOT NULL PRIMARY KEY, 
    [HoTenNV] NVARCHAR(50) NULL, 
    [NamSinh] INT NULL, 
    [GioiTinh] BIT NULL
)
CREATE TABLE [dbo].[KetQua]
(
	[MaNV] INT NOT NULL , 
    [TenSP] NVARCHAR(50) NOT NULL, 
    [DonGia] DECIMAL(10, 2) NULL, 
    [SoLuong] INT NULL, 
    PRIMARY KEY ([MaNV], [TenSP]), 
    CONSTRAINT [FK_KetQua_ToNhanVien] FOREIGN KEY ([MaNV]) REFERENCES [NhanVien]([MaNV])
)
