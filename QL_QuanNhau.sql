
use master
go
drop database QL_QuanNhau
go
use master
go
create database QL_QuanNhau
go
use QL_QuanNhau
go
set dateformat DMY
go
CREATE LOGIN vikhang WITH PASSWORD = 'admin'
CREATE LOGIN muidao WITH PASSWORD = 'admin'
CREATE ROLE EmployeeRole
CREATE ROLE AdminRole
ALTER SERVER ROLE AdminRole ADD MEMBER vikhang
ALTER SERVER ROLE EmployeeRole ADD MEMBER muidao
GRANT SELECT, INSERT, UPDATE, DELETE ON Bills TO EmployeeRole
GRANT SELECT, INSERT, UPDATE, DELETE ON Orders TO EmployeeRole
GRANT SELECT ON Tables TO EmployeeRole
GRANT SELECT ON Categories TO EmployeeRole
GRANT SELECT ON Items TO EmployeeRole
USE QL_QuanNhau
GRANT CONTROL ON QL_QuanNhau TO vikhang
go
create table Categories
(
	category_id varchar(10) primary key,
	category_name nvarchar(50) default N'Chưa đặt tên loại'
)
go 
insert into Categories values
	('C001', N'Món Xào'),
	('C002', N'Món Lẩu'),
	('C003', N'Món Chiên'),
	('C004', N'Món Hấp'),
	('C005', N'Món Nướng'),
	('C006', N'Món Luộc'),
	('C007', N'Món Chay'),
	('C008', N'Khác'),
	('C009', N'Bia'),
	('C010', N'Nước ngọt'),
	('C011', N'Nước suối'),
	('C012', N'Tráng miệng'),
	('C013', N'Ốc'),
	('C014', N'Cua-ghẹ')
go
create table Tables(
	table_id varchar(10) primary key,
	table_name nvarchar(50) default N'Chưa đặt tên bàn',
	status bit default 0
)
go
insert into Tables values 
	('TB001', N'Bàn số 1', 0),
	('TB002', N'Bàn số 2', 0),
	('TB003', N'Bàn số 3', 0),
	('TB004', N'Bàn số 4', 0),
	('TB005', N'Bàn số 5', 0),
	('TB006', N'Bàn số 6', 0),
	('TB007', N'Bàn số 7', 0),
	('TB008', N'Bàn số 8', 0),
	('TB009', N'Bàn số 9', 0),
	('TB010', N'Bàn số 10', 0),
	('TB011', N'Bàn số 11', 0),
	('TB012', N'Bàn số 12', 0),
	('TB013', N'Bàn số 13', 0),
	('TB014', N'Bàn số 14', 0),
	('TB015', N'Bàn số 15', 0),
	('TB016', N'Bàn số 16', 0),
	('TB017', N'Bàn số 17', 0),
	('TB018', N'Bàn số 18', 0),
	('TB019', N'Bàn số 19', 0),	
	('TB020', N'Bàn số 20', 0),
	('TB021', N'Bàn số 21', 0),
	('TB022', N'Bàn số 22', 0),
	('TB023', N'Bàn số 23', 0),
	('TB024', N'Bàn số 24', 0),
	('TB025', N'Bàn số 25', 0),
	('TB026', N'Bàn số 26', 0),
	('TB027', N'Bàn số 27', 0),
	('TB028', N'Bàn số 28', 0),
	('TB029', N'Bàn số 29', 0),
	('TB030', N'Bàn số 30', 0)
go

create table Account 
(
	Display nvarchar(50) default N'Chưa đặt tên hiện thị',
	UserName varchar(50) primary key,
	PassWord varchar(50) default '123',
	Type bit default 0
)
go
insert into Account values
	(N'Admin', 'admin', 'admin', 1),
	(N'Huỳnh Vĩ Khang', 'vikhang2805', '123', 1),
	(N'Đào Quí Mùi', 'muidao1506', '123', 0),
	(N'Đỗ Hoàng La Giang', 'lagiang1508', '123', 0),
	(N'Phạm Quỳnh Anh', 'quynhanh1810', '123', 1),
	(N'Nguyễn Mạnh Phát', 'manhphat123', '123', 0),
	(N'Ngô Thị Nhàn', 'thinhan123', '123', 0)
go
create table Items
(
	item_id varchar(10) primary key	,
	item_name nvarchar(50) default N'Chưa đặt tên',
	item_description nvarchar(max) default N'Chưa mô tả mặt hàng',
	item_price decimal default 0,
	item_unit nvarchar(10),
	category_id varchar(10), 
	constraint fk_itemCate foreign key (category_id) references Categories(category_id)
)
go 
insert into Items values
	('I001', N'Mì xào rau muống', null, 59000, N'Dĩa', 'C001'),
	('I002', N'Mì xào tỏi', null, 64000, N'Dĩa', 'C001'),
	('I003', N'Mì xào bò', null, 79000, N'Dĩa','C001'),
	('I004', N'Mì xào hải sản', null, 84000, N'Dĩa', 'C001'),
	('I005', N'Lẩu thái', null, 149000, N'Nồi','C002'),
	('I006', N'Lẩu bò', null, 159000, N'Nồi','C002'),
	('I007', N'Lẩu cá đuối', null, 169000, N'Nồi','C002'),
	('I008', N'Cơm chiên trứng', null, 69000, N'Dĩa','C003'),
	('I009', N'Cơm dương châu', null, 79000, N'Dĩa','C003'),
	('I010', N'Tàu hủ chiên', N'Ăn kèm rau ranh giới', 59000, N'Dĩa','C003'),
	('I011', N'Tôm chiên xù', null, 89000, N'Dĩa','C003'),
	('I012', N'Nghiêu hấp thái', null, 79000, N'Dĩa','C004'),
	('I013', N'Nghiêu hấp xả', null, 69000, N'Dĩa','C004'),
	('I014', N'Tôm hấp bia', null, 69000, N'Nồi','C004'),
	('I015', N'Bò nướng lá lốp', null, 89000, N'Dĩa','C005'),
	('I016', N'Heo ba chỉ nướng', null, 79000, N'Dĩa','C005'),
	('I017', N'Tôm nướng muối ớt', null, 74000, N'Dĩa','C005'),
	('I018', N'Gà nướng muối ớt', null, 84000, N'Con','C005'),
	('I019', N'Gà luộc nguyên con', null, 119000, N'Con','C006'),
	('I020', N'Hột vịt lộn', null, 9000, N'Trứng','C006'),
	('I021', N'Cút lộn', null, 4000, N'1 Trứng','C006'),
	('I022', N'Rau luộc', N'Kho quẹt', 19000, N'Dĩa','C006'),
	('I023', N'Cơm chay', null, 49000, N'Dĩa','C007'),
	('I024', N'Mì chay', null, 39000, N'Dĩa','C007'),
	('I025', N'Tàu hủ', N'Dùng với nước tương', 69000, N'Dĩa','C007'),
	('I026', N'Bia Saigon Lager - Sài Gòn Xanh', N'330 ml, 24 lon/thùng', 17000, N'Lon','C009'),
	('I027', N'Bia Saigon Export - Sài Gòn Đỏ', N'355 ml, 20 chai/két nhựa', 18000, N'Chai','C009'),
	('I028', N'Bia 333', N'Nồng độ cồn 5.3%', 19000, N'Lon','C009'),
	('I029', N'Bia Saigon Special - Sài Gòn lùn', N'Nồng độ cồn 4.9%', 18500, N'Chai','C009'),
	('I030', N'Bia Sài Gòn Gold lon 330ml', N'Nồng độ cồn 5.0%', 22600, N'Lon','C009')

go

create table Bills(
	bill_id varchar(10) primary key,
	dateCheckin date default getdate(),
	dateCheckout date,
	status bit default 0,
	cashier_id varchar(50),
	table_id varchar(10)  REFERENCES Tables(table_id),
	total_bill decimal default 0,
	discount decimal default 0
)

go

insert into Bills (bill_id, dateCheckin, dateCheckout, status, cashier_id, table_id) values
	('BI021', CURRENT_TIMESTAMP , CURRENT_TIMESTAMP , 0, 'muidao1506', 'TB001'),
	('BI001', '2023-10-1 8:30:03', '2023-10-1 12:23:03', 1, 'muidao1506', 'TB001'),
	('BI002', '2023-10-1 9:23:03', '2023-10-1 11:23:03', 1,'muidao1506', 'TB002'),
	('BI003', '2023-10-1 10:23:03','2023-10-1 12:23:03', 1,'quynhanh1810', 'TB001'),
	('BI004', '2023-10-1 12:23:03', '2023-10-1 13:23:03', 1,'manhphat123', 'TB003'),
	('BI005', '2023-10-1 15:23:03', '2023-10-1 14:23:03', 1,'muidao1506', 'TB005'),
	('BI006', '2023-10-1 20:23:03', '2023-10-1 21:23:03', 1,'muidao1506', 'TB007'),
	('BI007', '2023-10-1 22:23:03', '2023-10-1 23:23:03', 1,'manhphat123', 'TB010'),
	('BI008', '2023-10-1 23:23:03', '2023-10-2 02:23:03', 1,'quynhanh1810', 'TB012'),
	('BI009', '2023-10-1 23:59:03', '2023-10-2 01:23:03', 1,'manhphat123', 'TB015'),

	('BI010', '2023-10-2 8:30:03', null, 0, 'muidao1506', 'TB003'),
	('BI012', '2023-10-2 9:23:03', null, 0,'muidao1506', 'TB002'),
	('BI013', '2023-10-2 10:23:03',null, 0,'quynhanh1810', 'TB006'),
	('BI014', '2023-10-2 12:23:03', null, 0,'muidao1506', 'TB013'),
	('BI015', '2023-10-2 15:23:03', null, 0,'muidao1506', 'TB015'),
	('BI016', '2023-10-2 20:23:03', null, 0,'muidao1506', 'TB017'),
	('BI017', '2023-10-2 22:23:03', null, 0,'quynhanh1810', 'TB012'),
	('BI018', '2023-10-2 23:23:03', null, 0,'quynhanh1810', 'TB019'),
	('BI019', '2023-10-2 23:59:03', null, 0,'muidao1506', 'TB011')
go
create table Orders(
	bill_id varchar(10),
    item_id  varchar(10),
    quantity INT default 1,
	constraint pk_billOrder primary key (bill_id, item_id),
    constraint fk_ordersBillId FOREIGN KEY (bill_id) REFERENCES Bills(bill_id),
    constraint fk_orderItemsId FOREIGN KEY (item_id) REFERENCES Items(item_id)
)
go
insert into Orders values 
	('BI001', 'I004', 1),
	('BI001', 'I024', 1),
	('BI001', 'I026', 24),
	('BI001', 'I021', 1),
	('BI001', 'I022', 1),
	('BI001', 'I025', 1),
	('BI002', 'I021', 1),
	('BI002', 'I014', 1),
	('BI002', 'I005', 1),
	('BI002', 'I006', 1),
	('BI002', 'I026', 24),
	('BI002', 'I024', 1),
	('BI003', 'I026', 24),
	('BI003', 'I005', 1),
	('BI003', 'I021', 1),
	('BI003', 'I011', 1),
	('BI003', 'I014', 1),
	('BI003', 'I024', 1),
	('BI004', 'I021', 1),
	('BI004', 'I014', 1),
	('BI004', 'I024', 1),
	('BI004', 'I026', 24),
	('BI005', 'I021', 1),
	('BI005', 'I014', 1),
	('BI005', 'I024', 1),
	('BI005', 'I026', 24),
	('BI006', 'I001', 1),
	('BI006', 'I003', 1),
	('BI006', 'I004', 1),
	('BI006', 'I005', 1),
	('BI006', 'I006', 1),
	('BI006', 'I007', 1),
	('BI006', 'I008', 1),
	('BI007', 'I009', 1),
	('BI007', 'I010', 1),
	('BI007', 'I012', 1),
	('BI007', 'I013', 1),
	('BI007', 'I014', 1),
	('BI007', 'I015', 1),
	('BI008', 'I016', 1),
	('BI008', 'I017', 1),
	('BI008', 'I018', 1),
	('BI008', 'I019', 1),
	('BI008', 'I020', 1),
	('BI009', 'I021', 1),
	('BI009', 'I022', 1),
	('BI009', 'I023', 1),
	('BI009', 'I024', 1),
	('BI009', 'I025', 1),
	('BI010', 'I014', 1),
	('BI010', 'I024', 1),
	('BI010', 'I021', 1),
	('BI010', 'I001', 1),
	('BI010', 'I006', 2),
	('BI012', 'I026', 48),
	('BI012', 'I021', 3),
	('BI012', 'I013', 1),
	('BI012', 'I012', 2),
	('BI012', 'I016', 4),
	('BI012', 'I009', 1),
	('BI013', 'I002', 1),
	('BI013', 'I003', 2),
	('BI013', 'I015', 1),
	('BI013', 'I016', 1),
	('BI013', 'I028', 24),
	('BI014', 'I012', 1),
	('BI014', 'I011', 1),
	('BI014', 'I016', 1),
	('BI014', 'I026', 24),
	('BI015', 'I016', 1),
	('BI015', 'I004', 1),
	('BI015', 'I012', 1),
	('BI015', 'I026', 14)

go

create trigger trig_AddBillTableCover
on Bills
for insert
as
begin
	update Tables 
	set status = 1
	from inserted i 
	where Tables.table_id = i.table_id
end
go

go
create proc USP_GetTableList
as select * from Tables
go
create proc USP_LoginAccount 
@username varchar(50),
@password varchar(50)
as
begin	
	select * from Account 
	where UserName = @username
	and PassWord = @password
end
go
create proc USP_GetAllOrderOfBill
@ID_BILL varchar(10)
as 
begin
	select i.item_name as N'Mặt hàng',
	i.item_unit as N'ĐVT',
	i.item_price as N'Giá',
	o.quantity as N'Số lượng',
	(i.item_price * o.quantity) as N'Thành tiền' 
	from Orders o, Items i 
	where i.item_id = o.item_id 
	and bill_id = @ID_BILL
end
go
create proc USP_LoadDataItem 
@searchInput nvarchar(50)
as	
	select i.item_id as 'ID',
	i.item_name as N'Mặt hàng',
	i.item_unit as N'ĐVT' ,
	i.item_price as N'Giá', 
	c.category_name as N'Danh mục',
	i.item_description as N'Mô tả',
	item_unit as N'Đơn vị' 
	from Items i, Categories c 
	where c.category_id = i.category_id
	and category_name like @searchInput
go
create proc USP_LoadDateCategory
as	select category_id as 'ID',
	category_name as N'Tên danh mục' 
	from Categories
go
create proc USP_LoadDataTable
as	select table_id as 'ID',
	table_name as N'Tên bàn' 
	from Tables
go
create proc USP_LoadDataBill
as	
	select b.bill_id as N'Mã hóa đơn',
	t.table_name as N'Bàn khách ngồi',
	b.cashier_id as N'Thu ngân',
	FORMAT(b.dateCheckin, 'HH:mm:ss') as N'Giờ vào',
	FORMAT(b.dateCheckout, 'HH:mm:ss') as N'Giờ ra',
	FORMAT(b.dateCheckout, 'dd/MM/yyyy') as N'Ngày',
	CASE WHEN b.status = 1 
	THEN 'Đã thanh toán'
	ELSE 'Chưa thanh toán' 
	END AS N'Tình trạng', 
	b.total_bill as N'Tổng hóa đơn' 
	from Bills b, Tables t 
	where b.table_id = t.table_id
	and b.status = 1
go
create proc USP_LoadDataBillByDate
@dateFrom date, @dateTo date
as	
	select b.bill_id as N'Mã hóa đơn',
	t.table_name as N'Bàn khách ngồi',
	b.cashier_id as N'Thu ngân',
	FORMAT(b.dateCheckin, 'HH:mm:ss') as N'Giờ vào',
	FORMAT(b.dateCheckout, 'HH:mm:ss') as N'Giờ ra',
	FORMAT(b.dateCheckout, 'dd/MM/yyyy') as N'Ngày',
	CASE WHEN b.status = 1 
	THEN 'Đã thanh toán'
	ELSE 'Chưa thanh toán' 
	END AS N'Tình trạng', 
	b.total_bill as N'Tổng hóa đơn' 
	from Bills b, Tables t 
	where b.table_id = t.table_id
	and b.status = 1
	and dateCheckin >= @dateFrom
	and dateCheckout <= @dateTo
go
create proc USP_LoadDataBillByDateAndPage
@date1 date, @date2 date, @page int
as
	begin
		declare @pageRows int = 10
		declare @selectRows int = @pageRows - @page
		declare @excepRows int = (@page - 1)* @pageRows
		;with BillShowByPage as (select b.bill_id as N'Mã hóa đơn',
		t.table_name as N'Bàn khách ngồi',
		b.cashier_id as N'Thu ngân',
		FORMAT(b.dateCheckin, 'HH:mm:ss') as N'Giờ vào',
		FORMAT(b.dateCheckout, 'HH:mm:ss') as N'Giờ ra',
		FORMAT(b.dateCheckout, 'dd/MM/yyyy') as N'Ngày',
		CASE WHEN b.status = 1 
		THEN 'Đã thanh toán'
		ELSE 'Chưa thanh toán' 
		END AS N'Tình trạng', 
		b.total_bill as N'Tổng hóa đơn' 
		from Bills b, Tables t 
		where b.table_id = t.table_id
		and dateCheckin >= @date1
		and dateCheckin <= @date2
		and b.status = 1)
		select top(@selectRows) * from BillShowByPage
		except
		select top(@excepRows) * from BillShowByPage
	end
go
create proc USP_GetNumBillByDate
@dateFrom date, @dateTo date
as	
	select COUNT(*)
	from Bills b, Tables t 
	where b.table_id = t.table_id
	and b.status = 1
	and dateCheckin >= @dateFrom
	and dateCheckin <= @dateTo
go
go
create proc USP_LoadAccount
as	select Display as N'Tên hiện thị',
	UserName as N'Tên tài khoản',
	PassWord as N'Mật khẩu' ,
	CASE WHEN a.Type = 1 
	THEN N'Admin' 
	ELSE 'Staff' 
	END AS N'Vai trò'
	from Account a
go
create proc USP_InsertItem 
@id varchar(10),
@name nvarchar(50),
@des nvarchar(max),
@price decimal(18,0),
@unit nvarchar(10),
@cate varchar(10)
as	
	Insert into Items 
	(item_id, item_name, item_description, item_price, item_unit, category_id) 
	values (@id, @name, @des, @price, @unit, @cate)
go
create proc USP_UpdateItem
@id varchar(10),
@name nvarchar(50),
@des nvarchar(max),
@price decimal(18,0),
@unit nvarchar(10),
@cate varchar(10)
as 
	update Items 
	set item_name = @name,
	item_price = @price,
	item_unit = @unit, 
	category_id = @cate 
	where item_id = @id
go
create proc USP_InsertCategory
@id varchar(10), @name nvarchar(50)
as
	Insert into Categories
	values (@id, @name)
go
create proc USP_DeleteCategory
@id varchar(10)
as
	delete from Categories 
	where category_id = @id
go
create proc USP_DeleteItem
@id varchar(10)
as
	delete from Items
	where item_id = @id
go
create proc USP_insertTable
@id varchar(10), @name nvarchar(50)
as
	insert into Tables 
	(table_id, table_name)
	values (@id, @name)
go
create proc USP_UpdateTable
@id varchar(10), @name nvarchar(50)
as
	update Tables 
	set table_name = @name
	where table_id = @id
go
create proc USP_UpdateCategory
@id varchar(10), @name nvarchar(50)
as
	update Categories 
	set category_name = @name
	where category_id = @id
go
create proc USP_DeleteTable
@id varchar(10)
as
	delete from Tables 
	where table_id = @id
go
create proc USP_InsertAccount
@display nvarchar(50), @user varchar(50), @pass varchar(50), @type bit
as
	begin transaction
		begin try
			if exists (select * 
			from Account
			where UserName = @user)
			begin
				print N'User đã tồn tại'
				rollback transaction
				return
			end
			if @type != 1 or @type != 0
				set @type = 0
			insert into Account
			values (@display, @user, @pass, @type)
		end try
		begin catch
			print N'Lỗi thêm tài khoản'
				rollback transaction
			return 0
		end catch
	commit transaction
	return 1
go
create proc USP_DeleteAccount
@user varchar(50)
as
	delete from Account
	where UserName = @user
go
create proc USP_UpdateAccount
@display nvarchar(50),
@user varchar(50),
@pass varchar(50), 
@type bit
as
	update Account 
	set Display = @display,
	PassWord = @pass,
	Type = @type
	where UserName = @user
go
create proc USP_GetUnCheckBillByIdTable
@id varchar(10)
as
	select bill_id from Bills where table_id = @id and status = 0
go
create proc USP_GetListAllOrder
@id varchar(10)
as
	select * from Orders where bill_id = @id
go
create proc USP_GetListMenuByTable
@idTable varchar(10)
as
	select i.item_name as N'Món',
	o.quantity as N'Số lượng',
	i.item_price as N'Giá',
	i.item_price*o.quantity as N'Tổng' 
	from Orders as o,
	Items as i,
	Bills as b
	where o.bill_id = b.bill_id
	and o.item_id = i.item_id
	and b.status = 0 
	and b.table_id =  @idTable
go
create proc USP_GetItemByCategoryId
@id varchar(10)	
as
	select * from Items 
	where category_id = @id
go
create proc USP_InsertBill
@idBill varchar(10), @idTable varchar(10)
as
	insert into Bills 
	(bill_id, dateCheckin, dateCheckout, table_id, discount) values 
	(@idBill, CURRENT_TIMESTAMP, null, @idTable, 0)
go
--Thêm các order kiểm trả bill được thêm vào nếu có order đó rồi thì tăng số lượng ngược lại thêm một order mới
create proc USP_InsertOrders
@idBill varchar(10), @idItem varchar(10), @sl int
as	
begin	
	if exists (select * from Orders 
				where bill_id = @idBill 
				and item_id = @idItem)
	begin
		update Orders set quantity += @sl
		where bill_id = @idBill 
		and item_id = @idItem
	end
	else
	begin
		insert into Orders values (@idBill, @idItem, @sl)
	end
end
--chuyển bàn thay đổi trạng thái bàn cũ về trống
go
create proc USP_swapTable
@idTableNew varchar(10), @idBill varchar(10)
as
begin
	if exists (	select * from Tables 
				where table_id = @idTableNew
				and status = 0)
	begin
		declare @idTableOld varchar(10)
		select @idTableOld = table_id 
		from Bills
		where bill_id = @idBill

		update Tables
		set status = 0
		where table_id = @idTableOld

		update Bills
		set table_id = @idTableNew
		where bill_id = @idBill

		update Tables
		set status = 1
		where table_id = @idTableNew
	end
end
go
create function FUNC_GetIdBill_OccupiedTable
(@idTable varchar(10))
returns varchar(10)
as	
begin
	declare @idBill varchar(10)
	select @idBill = bill_id 
	from Bills 
	where table_id = @idTable 
	and status = 0
	return @idBill
end
go
create proc USP_CheckOutBill
@idBill varchar(10),
@discount decimal, 
@total decimal, @idTable varchar(10)
as 
begin
	update Bills set status = 1,
	discount = @discount, 
	dateCheckout = CURRENT_TIMESTAMP, 
	total_bill = @total
	where bill_id = @idBill
	
	update Tables set status = 0 where table_id = @idTable 
end
go
create proc USP_GetTableAvailable
as
	select * from Tables 
	where status = 0
go
create proc FUNC_CheckPassOld
    @username NVARCHAR(50),
    @passwordOld NVARCHAR(50)
AS
BEGIN
    DECLARE @isValid BIT = 0;

    IF EXISTS (SELECT 1 FROM Account WHERE Username = @username AND Password = @passwordOld)
    BEGIN
        SET @isValid = 1;
    END

    RETURN @isValid;
END
go
alter proc USP_CheckAllTableNotBill
as
	begin
		declare tableCursor cursor for select table_id, status from Tables
		open tableCursor 
		declare @id varchar(10)
		declare @status bit
		fetch next from tableCursor into @id, @status
		while @@FETCH_STATUS = 0
		begin
			if  @status = 1 
				if exists	(select * from 
						Bills 
						where table_id = @id 
						and status = 1)
						or not exists	(select * from 
										Bills 
										where table_id = @id)
					update Tables 
					set status = 0 
					where table_id = @id
			fetch next from tableCursor into @id, @status
		end
		close tableCursor
		deallocate tableCursor
	end
