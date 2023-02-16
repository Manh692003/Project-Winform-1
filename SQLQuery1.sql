create database KIEMTRACUOIKY
go

use KIEMTRACUOIKY
go

create table TaiKhoan
(
	HoTen nvarchar(50),
	Lop varchar(50),
	MaSV varchar(50) not null,
	MatKhau varchar(50),

	primary key (MaSV)
)
go

create table KetQua
(
	Lop varchar(50),
	TenDangNhap varchar(50),
	MonThi nvarchar(50),
	Diem int
)
go

create table LopHoc
(
	TenLop varchar(50),
	MoTa nvarchar(50),
	TrangThai nvarchar(50) 
)
go

alter table KetQua add constraint FK_KQ foreign key (TenDangNhap) references TaiKhoan (TenDangNhap)

create table TaiKhoanQL
(
	TenDangNhap varchar(50) not null,
	MatKhau varchar(50)

	primary key (TenDangNhap)
)
go

create table TaoDe
(
	KyThi nvarchar(50),
	MonThi nvarchar(50),
	BatDau date,
	KetThuc date,
	ThoiGian int
)
go

select * from TaoDe
select * from LopHoc
select * from TaiKhoan
select * from KetQua
select * from TaiKhoanQL

insert into TaiKhoanQL values ('Admin', 'Phanmanh24')