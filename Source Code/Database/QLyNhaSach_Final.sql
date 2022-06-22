Create Database QLNhaSach
Go

---------------------------------------------------------------------

--Tao CSDL QLNhaSach
Use QLNhaSach
Go

---------------------------------------------------------------------

--Tạo bảng NXB
Create Table dbo.NXB(
	MaNXB char(10) PRIMARY KEY,
	TenNXB char(50) NULL,
	DiaChi char(50) NULL,
	SoDT char(10) NULL
)
Go



-- Thêm dữ liệu cho bảng NXB
Insert into NXB Values('NXB01', 'Dai Hoc quoc gia',' TPHCM', '034506')
Insert into NXB Values ('NXB02', 'Nha sach phuong nam', 'Quan 4, HCM', '943034')
Insert into NXB Values ('NXB03', 'Nha sach minh ngoc', 'Ha Dong, Ha Noi', '433054')
Insert into NXB Values ('NXB04', 'Wolters Kluwer', 'New York, USA', '943023')
Insert into NXB Values ('NXB05', 'Mario scot', 'Usa', '087321')
Insert into NXB Values ('NXB06', 'MiMikiw', 'Washinton, USA', '009812')
Insert into NXB Values ('NXB07', 'Addison Wesley', 'Westview Dr SW, USA', '393585')
Go

---------------------------------------------------------------------

--Tạo bảng TacGia
Create Table dbo.TacGia(
	MaTG char(10) ,
	TenTacGia nchar(30),
	Primary key (MaTG) -- Khai báo khóa chính gồm 2 cột
)
Go

--Thêm dữ liệu cho bảng TacGia
Insert into TacGia Values ('TG01', 'Nguyen Thanh Son')
Insert into TacGia Values ('TG02', 'Le Van Vinh')
Insert into TacGia Values ('TG03', 'Truong Thi My Chau')
Insert into TacGia Values ('TG04', 'Nguyen Thi Thu Huong')
Insert into TacGia Values ('TG05', 'Ngoc Thu')
Insert into TacGia Values ('TG06', 'Nguyen Van Thanh')
Insert into TacGia Values ('TG07', 'Jacki john')
Insert into TacGia Values ('TG08', 'Aldrin Yim')
Insert into TacGia Values ('TG09', 'John V. Guttag')
Insert into TacGia Values ('TG10', 'Naomi Cambell')
Insert into TacGia Values ('TG11', 'Oda Eiichiro')
Insert into TacGia Values ('TG12', 'Jojo Moyes')
Insert into TacGia Values ('TG13', 'Nguyen Van Phuoc')
Insert into TacGia Values ('TG14', 'Robinson Sharma')
Insert into TacGia Values ('TG15', 'Kishimoto Masachi')
Insert into TacGia Values ('TG16', 'Kenny oshnon')
Insert into TacGia Values ('TG17', 'Dale Carnegie')
Insert into TacGia Values ('TG18', 'Paulo Coelho')
Insert into TacGia Values ('TG19', 'Hemingway')
Insert into TacGia Values ('TG20', 'Fyodor Dostoevsky')
Insert into TacGia Values ('TG21', 'Hemingway')
Insert into TacGia Values ('TG22', 'Murakami Haruki')
Insert into TacGia Values ('TG23', 'J.D.Salinger')
Insert into TacGia Values ('TG24', 'Tony Hsieh')
Insert into TacGia Values ('TG25', 'David J.Lieberman')
Insert into TacGia Values ('TG26', 'Mario Puzo')
Insert into TacGia Values ('TG27', 'Mari Tamagawa')
Insert into TacGia Values ('TG28', ' Trump')
Insert into TacGia Values ('TG29', 'J. K. Rowling')
Insert into TacGia Values ('TG30', N'Nguyễn Nhật Ánh')
Go

---------------------------------------------------------------------

--Tạo bảng KhachHang
Create Table dbo.KhachHang(
	MaKH char(10) Primary key,
	TenKH nvarchar(30) NULL,
	DiaChi nvarchar(100) NULL,
	NgaySinh Date NULL,
	soDT char(10) NULL,
	FlagXoa bit NOT NULL
)
Go

-- Thêm dữ liệu cho KhachHang
Insert into KhachHang values ('KH01', N'Nguyễn Văn A', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-12-12', '12345435','0')
Insert into KhachHang values ('KH02', N'Nguyễn Văn B', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2000-1-12', '06329731','0')
Insert into KhachHang values ('KH03', N'Nguyễn Văn C', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2003-1-1', '04146871','0')
Insert into KhachHang values ('KH04', N'Nguyễn Văn D', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-12-2', '01354689','0')
Insert into KhachHang values ('KH05', N'Nguyễn Văn E', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-5-12', '03216489','0')
Insert into KhachHang values ('KH06', N'Nguyễn Văn F', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-2-2', '01523426','0')
Insert into KhachHang values ('KH07', N'Nguyễn Văn G', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-12-10', '01323251','0')
Insert into KhachHang values ('KH08', N'Nguyễn Văn H', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-3-3', '75134620','0')
Insert into KhachHang values ('KH09', N'Nguyễn Văn I', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-3-6', '05285654','0')
Insert into KhachHang values ('KH10', N'Nguyễn Văn J', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-12-7', '02030105','0')
Insert into KhachHang values ('KH11', N'Nguyễn Văn K', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-5-20', '01324545','0')
Insert into KhachHang values ('KH12', N'Nguyễn Văn L', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-4-7', '75848962','0')
Insert into KhachHang values ('KH13', N'Nguyễn Văn M', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-7-12', '15154274','0')
Insert into KhachHang values ('KH14', N'Nguyễn Văn N', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-8-23', '85828789','0')
Insert into KhachHang values ('KH15', N'Nguyễn Văn O', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-2-4', '02030605','0')
Insert into KhachHang values ('KH16', N'Nguyễn Văn P', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-5-1', '08090745','0')
Insert into KhachHang values ('KH17', N'Nguyễn Văn Q', N'01 Nguyễn Trãi, Q.1, TP.HCM', '2002-1-8', '08097060','0')
GO
---------------------------------------------------------------------

--Tạo bảng DauSach
Create Table dbo.DauSach(
	MaSach char(10) PRIMARY KEY,
	TuaSach nchar(50) NULL,
	MaNXB char(10) references NXB(MaNXB),
	MaTG char(10)  references TacGia(MaTG),
	GiaMua int NULL,
	GiaMuon int NUll
)
Go

-- Thêm dữ liệu cho bảng DauSach
Insert into DauSach Values ('MS01', 'Giao Trinh CSDL', 'NXB01','TG01', 110000,15000)
Insert into DauSach Values ('MS02', 'Lap Trinh Window', 'NXB02','TG02', 121000,25000)
Insert into DauSach Values ('MS03', 'Giao Trinh TTHCM', 'NXB06','TG03', 132000,1500)
Insert into DauSach Values ('MS04', 'Giao Trinh PLDC', 'NXB05','TG04',134000, 15000)
Insert into DauSach Values ('MS05', 'Dien tu can ban', 'NXB02','TG05', 98000, 25000)
Insert into DauSach Values ('MS06', 'LT Python', 'NXB03','TG06',65000,15000)
Insert into DauSach Values ('MS07', 'Tai lieu Toeic No.1', 'NXB03','TG07', 200000,15000)
Insert into DauSach Values ('MS08', 'Matplotlib', 'NXB06','TG08',190000,16000)
Insert into DauSach Values ('MS09', 'DMatplotlib for Py', 'NXB01','TG09', 176000, 18000)
Insert into DauSach Values ('MS10', 'Make me feel', 'NXB02','TG10', 154000,15000)
Insert into DauSach Values ('MS11', 'Fairy tail', 'NXB04','TG11', 178000, 15000)
Insert into DauSach Values ('MS12', 'Champagne', 'NXB03','TG12', 145000, 15000)
Insert into DauSach Values ('MS13', 'Go to goal', 'NXB01','TG13', 134000, 12000)
Insert into DauSach Values ('MS14', 'Hat giong tam hon', 'NXB06','TG14', 150000, 15000)
Insert into DauSach Values ('MS15', 'Boruto', 'NXB02','TG15', 125000, 17000)
Insert into DauSach Values ('MS16', 'Milky Way', 'NXB07','TG16',95000, 15000)
Insert into DauSach Values ('MS17', 'Milky Way back', 'NXB07','TG17',78000, 18000)
Insert into DauSach Values ('MS18', 'Milky go home', 'NXB07','TG18',200000, 15000)
Insert into DauSach Values ('MS19', 'Milky lost', 'NXB07','TG19',68000, 25000)
Insert into DauSach Values ('MS20', 'Milky Run home', 'NXB07','TG20',50000, 15000)
Insert into DauSach Values ('MS21', 'Milky Miss you', 'NXB07','TG21',110000, 15000)
Insert into DauSach Values ('MS22', N'Tôi là ai', 'NXB04','TG21', 145000, 25000)
Insert into DauSach Values ('MS23', N'Rừng Na Uy', 'NXB03','TG22', 188000, 19000)
Insert into DauSach Values ('MS24', N'Thế giới như tôi thấy', 'NXB01','TG13', 150000, 17000)
Insert into DauSach Values ('MS25', N'Người dưng', 'NXB06','TG14', 156000, 15000)
Insert into DauSach Values ('MS26', N'Gullible du ký', 'NXB02','TG15', 175000, 27000)
Insert into DauSach Values ('MS27', N'Gullible du ký 2', 'NXB07','TG15', 175000, 25000)
Insert into DauSach Values ('MS28', N' Nhà giả kim', 'NXB07','TG17',168000,18000)
Insert into DauSach Values ('MS29', N'Tội Ác Và Hình Phạt', 'NXB07','TG19',200000, 15000)
Insert into DauSach Values ('MS30', N'Dạy Con Làm Giàu', 'NXB07','TG17',126000, 25000)
Insert into DauSach Values ('MS31', N'Cà Phê Cùng Tony', 'NXB07','TG20',79000, 15000)
Insert into DauSach Values ('MS32', N'Đừng Bao Giờ Bỏ Cuộc', 'NXB07','TG21',110000, 15000)
Insert into DauSach Values ('MS33', N'Bắt Trẻ Đồng Xanh', 'NXB07','TG30',95000, 15000)
Insert into DauSach Values ('MS34', N'Ông Già Và Biển Cả', 'NXB07','TG23',78000, 18000)
Insert into DauSach Values ('MS35', N'Tỷ Phú Bán Giày', 'NXB07','TG24',200000, 15000)
Insert into DauSach Values ('MS36', N'Đọc Vị Bất Kỳ Ai', 'NXB07','TG25',68000, 25000)
Insert into DauSach Values ('MS37', N'Bố già', 'NXB07','TG26',50000, 15000)
Insert into DauSach Values ('MS38', N'Mặc Kệ Thiên Hạ, Sống Như Người Nhật', 'NXB07','TG27',110000, 15000)
Insert into DauSach Values ('MS39', N'Cuốn Theo Chiều Gió ', 'NXB07','TG28',50000, 15000)
Insert into DauSach Values ('MS40', N'Đắc Nhân Tâm', 'NXB07','TG29',110000, 15000)
Go

---------------------------------------------------------------------


-- Tạo bảng CuonSach
Create Table dbo.CuonSach(
	Masach char(10) references DauSach(MaSach),
	MaCuon char(10) Primary key,
	ViTri char(10) NULL,
	--- Flag la cờ xđ cuốn sách còn(1) hay đã mượn/mua(0)
	FlagXoa bit NOT NULL
)
Go

--Thêm dữ liệu vào bảng CuonSach
Insert into CuonSach values ('MS01', 'CS01', 'A101','1')
Insert into CuonSach values ('MS01', 'CS02', 'A102','1')
Insert into CuonSach values ('MS02', 'CS03', 'A202','1')
Insert into CuonSach values ('MS03', 'CS04', 'A301','1')
Insert into CuonSach values ('MS04', 'CS05', 'A401','1')
Insert into CuonSach values ('MS05', 'CS06', 'A501','1')
Insert into CuonSach values ('MS05', 'CS07', 'A502','1')
Insert into CuonSach values ('MS06', 'CS08', 'A601','1')
Insert into CuonSach values ('MS06', 'CS09', 'A602','1')
Insert into CuonSach values ('MS07', 'CS10', 'A701','1')
Insert into CuonSach values ('MS08', 'CS11', 'A801','1')
Insert into CuonSach values ('MS10', 'CS12', 'A1401','1')
Insert into CuonSach values ('MS11', 'CS13', 'A1101','1')
Insert into CuonSach values ('MS11', 'CS14', 'A1102','0')
Insert into CuonSach values ('MS15', 'CS15', 'A1901','1')
Insert into CuonSach values ('MS14', 'CS16', 'A1601','1')
Insert into CuonSach values ('MS16', 'CS17', 'A1501','1')
Insert into CuonSach values ('MS17', 'CS18', 'A1501','1')
Insert into CuonSach values ('MS18', 'CS19', 'A1501','1')
Insert into CuonSach values ('MS19', 'CS20', 'A1701','1')
Insert into CuonSach values ('MS20', 'CS21', 'A1301','0')
Insert into CuonSach values ('MS21', 'CS22', 'A1511','0')
Insert into CuonSach values ('MS18', 'CS23', 'A1502','0')
Insert into CuonSach values ('MS10', 'CS24', 'A1401','0')
Insert into CuonSach values ('MS11', 'CS25', 'A1101','0')
Insert into CuonSach values ('MS15', 'CS26', 'A1901','0')
Insert into CuonSach values ('MS14', 'CS27', 'A1601','0')
Insert into CuonSach values ('MS16', 'CS28', 'A1501','0')
Insert into CuonSach values ('MS17', 'CS29', 'A1501','0')
Insert into CuonSach values ('MS18', 'CS30', 'A1501','0')
Insert into CuonSach values ('MS19', 'CS31', 'A1701','0')
Insert into CuonSach values ('MS20', 'CS32', 'A1301','0')
Insert into CuonSach values ('MS21', 'CS33', 'A1511','0')
Insert into CuonSach values ('MS18', 'CS34', 'A1502','0')
Insert into CuonSach values ('MS01', 'CS35', 'A101','0')
Insert into CuonSach values ('MS01', 'CS36', 'A102','0')
Insert into CuonSach values ('MS02', 'CS37', 'A202','0')
Insert into CuonSach values ('MS03', 'CS38', 'A301','0')
Insert into CuonSach values ('MS04', 'CS39', 'A401','0')
Insert into CuonSach values ('MS05', 'CS40', 'A501','0')
Insert into CuonSach values ('MS05', 'CS41', 'A502','0')
Insert into CuonSach values ('MS06', 'CS42', 'A601','0')
Insert into CuonSach values ('MS06', 'CS43', 'A602','0')
Insert into CuonSach values ('MS07', 'CS44', 'A701','0')
Insert into CuonSach values ('MS08', 'CS45', 'A801','0')
Insert into CuonSach values ('MS10', 'CS46', 'A1401','0')
Insert into CuonSach values ('MS11', 'CS47', 'A1101','0')
Insert into CuonSach values ('MS15', 'CS48', 'A1901','0')
Insert into CuonSach values ('MS14', 'CS49', 'A1601','0')
Insert into CuonSach values ('MS16', 'CS50', 'A1501','0')
Insert into CuonSach values ('MS27', 'CS51', 'A1502','0')
Insert into CuonSach values ('MS25', 'CS52', 'A1503','0')
Insert into CuonSach values ('MS26', 'CS53', 'A1704','0')
Insert into CuonSach values ('MS27', 'CS54', 'A1305','0')
Insert into CuonSach values ('MS28', 'CS55', 'A1506','0')
Insert into CuonSach values ('MS29', 'CS56', 'A1507','0')
Insert into CuonSach values ('MS30', 'CS57', 'A1018','0')
Insert into CuonSach values ('MS31', 'CS58', 'A1029','0')
Insert into CuonSach values ('MS32', 'CS59', 'A2021','0')
Insert into CuonSach values ('MS33', 'CS60', 'A3012','0')
Insert into CuonSach values ('MS34', 'CS61', 'A4013','0')
Insert into CuonSach values ('MS35', 'CS62', 'A5014','0')
Insert into CuonSach values ('MS36', 'CS63', 'A5025','0')
Insert into CuonSach values ('MS37', 'CS64', 'A6016','0')
Insert into CuonSach values ('MS38', 'CS65', 'A6027','0')
Insert into CuonSach values ('MS39', 'CS66', 'A7018','0')
Insert into CuonSach values ('MS40', 'CS67', 'A1401','0')
Insert into CuonSach values ('MS40', 'CS68', 'A1401','0')
Insert into CuonSach values ('MS11', 'CS69', 'A1101','0')
Insert into CuonSach values ('MS39', 'CS70', 'A7018','0')
Insert into CuonSach values ('MS14', 'CS71', 'A1601','1')
Insert into CuonSach values ('MS34', 'CS72', 'A4013','1')
Insert into CuonSach values ('MS35', 'CS73', 'A5014','1')
Insert into CuonSach values ('MS36', 'CS74', 'A5025','1')
Insert into CuonSach values ('MS37', 'CS75', 'A6016','1')
Insert into CuonSach values ('MS38', 'CS76', 'A6027','1')
Insert into CuonSach values ('MS39', 'CS77', 'A7018','1')
Insert into CuonSach values ('MS11', 'CS78', 'A1107','1')

GO

---------------------------------------------------------------------

-- Tạo bảng Muon
Create Table dbo.Muon(
	MaCuon char(10) REFERENCES CuonSach(MaCuon),
	MaKH char(10) REFERENCES KhachHang(MaKH),
	NgayMuon Date NULL,
	NgayTra Date NULL,
	HanTra Date NULL,
	TienPhat int NULL,
	DangMuon bit NOT NULL,
	DaThanhToan bit NOT NULL,
	Primary key(MaCuon, MaKH) --Khai báo 2 cột là khóa chính
)
Go

-- Thêm dữ liệu cho bảng Muon

Insert into Muon values ('CS06', 'KH06', '2022-3-14', null, '2022-4-14', 0, 1,0)
Insert into Muon values ('CS07', 'KH07', '2022-3-10', '2022-3-14', '2022-4-14',0, 1,1)
Insert into Muon values ('CS08', 'KH08', '2022-5-14', null, '2022-6-14', 0, 1,0)
Insert into Muon values ('CS09', 'KH09', '2022-1-14', null, '2022-2-14', 0, 1,0)
Insert into Muon values ('CS10', 'KH10', '2022-3-21', null, '2022-4-21', 0, 1,0)
Insert into Muon values ('CS11', 'KH11', '2022-3-1', null, '2022-4-1', 0, 1,0)
Insert into Muon values ('CS12', 'KH12', '2022-5-1', null, '2022-6-1', 0, 1,0)
Insert into Muon values ('CS13', 'KH13', '2022-2-1', null, '2022-3-1', 0, 1,0)


--Insert into Muon values('CS01', 'KH01','2022-3-20', '2022-3-15','2022-4-20',0,'0','1')
--Insert into Muon values('CS02', 'KH02', '2022-1-30', '2022-2-2','2022-3-1',0,'0','1')
--Insert into Muon values('CS03', 'KH03', '2021-12-3', '2022-1-3','2022-1-3',0,'0','1')
--Insert into Muon values('CS04', 'KH04','2021-4-24', '2022-5-25','2022-5-24',5000,'0','1')
--Insert into Muon values('CS05', 'KH05','2022-2-2', '2022-3-3','2022-3-4',0,'0','1')
--Insert into Muon values('CS06', 'KH06','2022-5-29', NULL,'2022-6-29',0,'1','0')
--Insert into Muon values('CS08', 'KH08','2022-5-24', NULL,'2022-6-24',0,'1','0')
--Insert into Muon values('CS09', 'KH09','2022-4-28', '2022-6-2','2022-5-28',20000,'0','1')
--Insert into Muon values('CS10', 'KH10','2022-5-24', NULL,'2022-6-24',0,'1','0')
--Insert into Muon values('CS12', 'KH12','2022-5-20', NULL,'2022-6-20',20000,'1','0')
--Insert into Muon values('CS13', 'KH13','2022-3-2', '2022-4-2','2022-4-2',0,'0','1')
--Insert into Muon values('CS12', 'KH13','2022-3-2', '2022-4-15','2022-4-2',65000,'0','1')
--Insert into Muon values('CS14', 'KH14','2022-3-1', '2022-3-30','2022-4-1',0,'0','1')
--Insert into Muon values('CS15', 'KH15','2022-1-15', '2022-2-20','2022-2-15',25000,'0','1')
--Insert into Muon values('CS14', 'KH16','2022-2-25', '2022-3-1','2022-3-25',0,'0','1')
--Insert into Muon values('CS11', 'KH13','2022-4-25', '2022-5-20','2022-5-25',0,'0','1')
--Insert into Muon values('CS15', 'KH13','2022-2-20', '2022-3-30','2022-3-20',0,'0','1')
--Insert into Muon values('CS16', 'KH13','2022-3-01', '2022-4-2','2022-4-01',5000,'0','1')
--Insert into Muon values('CS16', 'KH17','2022-6-06', NULL,'2022-7-06',0,'1','0')
--Insert into Muon values('CS19', 'KH17','2022-6-01', NULL,'2022-7-01',0,'1','0')
--Insert into Muon values('CS21', 'KH17','2022-5-15', NULL,'2022-6-15',25000,'1','0')
--Insert into Muon values('CS23', 'KH17','2022-5-01', '2022-6-1','2022-6-01',0,'0','1')
--Insert into Muon values('CS50', 'KH16','2022-5-25', NULL,'2022-6-25',0,'0','0')
--Insert into Muon values('CS51', 'KH13','2022-4-25', '2022-5-20','2022-5-25',0,'0','1')
--Insert into Muon values('CS52', 'KH13','2022-2-20', '2022-3-30','2022-3-20',0,'0','1')
--Insert into Muon values('CS53', 'KH13','2022-3-01', '2022-4-7','2022-4-01',30000,'0','1')

Go

---------------------------------------------------------------------

-- Tạo bang Mua
Create Table dbo.Mua(
	MaCuon char(10) REFERENCES CuonSach(MaCuon),
	MaKH char(10) REFERENCES KhachHang(MaKH),
	NgayMua Date NULL,
	DaThanhToan bit NOT NULL
	Primary key(MaCuon, MaKH) --Khai báo 2 cột là khóa chính
)
Go

-- Thêm dữ liệu cho bảng Mua
Insert into Mua values('CS01', 'KH01' , '2022-5-15','1')
Insert into Mua values('CS02', 'KH02', '2022-2-3','1')
Insert into Mua values('CS03', 'KH03', '2022-2-3','1')
Insert into Mua values('CS04', 'KH04', '2022-5-29','1')
Insert into Mua values('CS05', 'KH05', '2021-5-3','1')
Insert into Mua values('CS15', 'KH15',  '2022-3-22','1')
Insert into Mua values('CS16', 'KH16',  '2022-5-20','1')
Insert into Mua values('CS17', 'KH13', '2022-5-22','1')
Insert into Mua values('CS18', 'KH13','2022-5-30','1')
Insert into Mua values('CS19', 'KH17', '2022-6-30','1')
Insert into Mua values('CS20', 'KH17','2022-6-20','1')
Insert into Mua values('CS77', 'KH14',  '2022-3-31','1')
Insert into Mua values('CS76', 'KH15',  '2022-3-22','1')
Insert into Mua values('CS75', 'KH16',  '2022-5-20','1')
Insert into Mua values('CS74', 'KH13', '2022-4-22','1')
Insert into Mua values('CS73', 'KH13','2022-1-30','1')
Insert into Mua values('CS72', 'KH17', '2022-3-30','1')
Insert into Mua values('CS71', 'KH17','2022-5-20','1')
Go

---------------------------------------------------------------------

Create Table dbo.NhanVien(
	MaNV char(10) Primary key,
	TenNV char(30) NULL,
	CongViec char(20) NULL,
	Luong char(20) NULL,
	DiaChi char(50) NULL,
	NgaySinh Date NULL,
	GioiTinh bit NULL,
	soDT char(10) NULL,
	FlagXoa bit NOT NULL
)
Go

-- Thêm dữ liệu cho bảng NhanVien
Insert into NhanVien values ('NV01', 'Nguyen Van Sang', 'Quan Li','8000000', '22 Le Duan', '2002-10-16', '1', '062344','0')
Insert into NhanVien values ('NV02', 'Nguyen Thi Hong', 'Nhan vien ban hang', '4000000', '01 Vo Van Ngan', '1998-6-13','0', '064835','0')
Insert into NhanVien values ('NV03', 'Tran Tien Khoi', 'Thu ngan 1','4500000', 'Quoc lo 13','2000-1-05', '1', '041215','0')
Insert into NhanVien values ('NV04', 'Le Thi Viet', 'Thu ngan 2','4500000', '105 Dinh Tien Hoang', '2001-12-25', '0', '048121','0')
Insert into NhanVien values ('NV05', 'Ho Viet Khoa', 'Bao ve 1','5000000', 'Duong 23 Quoc Lo 1A', '2001-9-8', '1', '075156','0')
Insert into NhanVien values ('NV06', 'Tran Kim Tien', 'Bao ve 2','5000000', '15 Hoang Dieu', '1997-7-16', '1', '045317','0')
Insert into NhanVien values ('NV07', 'Nguyen Thuy Tien', 'Nhan vien ban hang', '4000000', '6 Le Van Viet', '2001-10-21', '0', '078116','0')
Insert into NhanVien values ('NV08', 'Huynh Thuy Nhung', 'Nhan vien ban hang', '4000000', '47 Vo Thi Sau', '2002-11-14', '0', '033549','0')
Insert into NhanVien values ('NV09', 'Dinh Van Toan', 'Nhan vien ban hang', '4000000', '25 Le Duan', '1999-5-17', '1', '048789','0')
Go

---------------------------------------------------------------------

-- Tạo bảng TaiKhoan 
Create Table dbo.TaiKhoan(
	MaNV char(10) primary key,
	Quyen char(10) NUll,
	TenTK char(20) NULL,
	MatKhau char(20) NULL,
	FlagXoa bit NOT NULL
	foreign key (MaNV) references NhanVien(MaNV)
)
Go

-- Thêm dữ liệu cho bảng TaiKhoan
Insert into TaiKhoan values('NV01','Quanli','admin','admin','0')
Insert into TaiKhoan values('NV02','Nhanvien','thuhien','123@','0') 
Insert into TaiKhoan values('NV03','Nhanvien','vanthien','thien123','0') 
Insert into TaiKhoan values('NV04','Nhanvien','thangluong','thang2353','0') 
Insert into TaiKhoan values('NV05','Nhanvien','Dungdo','dodung4747','0') 
Insert into TaiKhoan values('NV06','Nhanvien','HienHo','hien64@','0') 
Insert into TaiKhoan values('NV07','Nhanvien','kido','kido222','0') 
Insert into TaiKhoan values('NV08','Nhanvien','kimtran','456d@','0') 
Insert into TaiKhoan values('NV09','Nhanvien','thaobi','bi64@','0')
Go

