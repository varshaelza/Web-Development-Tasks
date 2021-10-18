--use Stocks

--create table stockInfo
--(
--stockId int identity(100,1),
--stockName varchar(20) not null,
--stockCategory varchar(20) not null,
--stockAvailableQty int not null,
--stockPrice float not null,
--constraint pk_stock primary key(stockId)
--)

--insert into stockInfo values('Apple','Fruits',54,500)
--insert into stockInfo values('Frying pan','Utensils',25,2000)
--insert into stockInfo values('Chips','Edibles',10,4500)
--insert into stockInfo values('Pressure Cooker','Utensils',51,4800)
--insert into stockInfo values('Mango','Fruits',25,8000)
--insert into stockInfo values('Instrument Box','Stationary',45,1000)
--insert into stockInfo values('Shirt','Cloths',28,4600)
--insert into stockInfo values('Saree','Cloths',41,6000)
--insert into stockInfo values('AC','Home Appliance',20,50000)
--insert into stockInfo values('Refridgerator','Home Appliance',40,45600)


--create table orders
--(
--orderId int identity(500,1),
--dateoforder date,
--stockId int,
--orderQty int,
--amount float,
--discount float,
--tax float,
--net float,
--constraint pk_orders primary key(orderId),
--constraint fk_stocks foreign key(stockId) references stockInfo
--)
--use Stocks

--create table reorder
--(
--rId int identity(1000,1),
--stockId int,
--dateofreorder date,
--constraint pk_reorder primary key(rId),
--constraint fk_reorder foreign key(stockId) references stockInfo
--)



--TRIGGERS

--use Banking_DB
--create Trigger trg_branch_insert
--on
--branchInfo
--for insert
--as
--begin
--	if(datename(weekday,getdate())='Friday')
--	begin
--		rollback
--		print 'Sorry , cannot add new branch on Friday'
--	end
--end

--insert into branchInfo values(60,'Somewhere','Mumbai')


--use Employee_DB
--create table employee
--(
--empno int primary key identity(100,1),
--empname varchar(20) not null,
--empdesig varchar(20),
--empsal float
--)

--create table employee_tracker
--(
--eventid int primary key identity(500,1),
--dateofactivity date not null,
--empno int ,
--empname varchar(20),
--empdesig varchar(20),
--empsal float,
--action varchar(20),
--constraint fk_tracker foreign key(empno) references employee
--)

--create trigger trg_employee_insert
--on
--employee
--after
--insert
--as
--begin
--	declare @empno int=(select i.empno from inserted i)
--	declare @empname varchar(20)=(select i.empname from inserted i)
--	declare @empdesig varchar(20)=(select i.empdesig from inserted i)
--	declare @empsal float =(select i.empsal from inserted i)
--	insert into employee_tracker values(getdate(),@empno,@empname,@empdesig,@empsal,'Joined')
--end
--insert into employee values('Varsha','JR.Developer',45000)

--drop trigger trg_employee_insert

--alter trigger trg_employee
--on 
--employee
--after
--insert,delete,update
--as
--begin
--	declare @empno int
--	declare @empname varchar(20)
--	declare @empdesig varchar(20)
--	declare @empsal float
--	if (exists(select * from inserted) and exists(select * from deleted))
--	begin
--		set @empno =(select i.empno from inserted as i)
--		set @empname =(select i.empname from inserted as i)
--		set @empdesig =(select i.empdesig from inserted as i)
--		set @empsal  =(select i.empsal from inserted as i)
--		insert into employee_tracker values(getdate(),@empno,@empname,@empdesig,@empsal,'Updated')
--	end
--	else if (exists(select * from inserted))
--	begin
--		set @empno =(select i.empno from inserted as i)
--		set @empname =(select i.empname from inserted as i)
--		set @empdesig =(select i.empdesig from inserted as i)
--		set @empsal  =(select i.empsal from inserted as i)
--		insert into employee_tracker values(getdate(),@empno,@empname,@empdesig,@empsal,'Joined')
--	end
--	else if (exists(select * from deleted))
--	begin
--		set @empno =(select d.empno from deleted as d)
--		set @empname =(select d.empname from deleted as d)
--		set @empdesig =(select d.empdesig from deleted as d)
--		set @empsal =(select d.empsal from deleted as d)
--		insert into employee_tracker values(getdate(),@empno,@empname,@empdesig,@empsal,'Resigned')
--	end
--end

--insert into employee values('Christi','SR.Manager',34000)
--alter table employee_tracker drop constraint fk_tracker
--delete from employee where empno=101
--update employee set empname='Varsha Gikku' where empno=100



--use Stocks
--alter table stockInfo add constraint check_stockavailablity check(stockAvailableQty>=0)

--alter procedure proc_neworder(@stockId int,@stockqty int)
--as
--begin
--	if((select stockAvailableQty from stockInfo where stockId=@stockId)>=@stockqty)
--	begin
--		declare @amount float=@stockqty*(select stockPrice from stockInfo where stockId=@stockId)
--		declare @discount int=10
--		declare @tax int=5
--		declare @net float= @amount-(@amount*@discount)/100-(@amount*@tax)/100
--		insert into orders values(getdate(),@stockId,@stockQty,@amount,@discount,@tax,@net)
--	end
--	else
--	begin
--		print 'Insufficient stock'
--	end
--end
--go
--create trigger trg_orders_insert
--on 
--orders
--for
--insert
--as
--begin
--	declare @qty int=(select i.orderQty from inserted as i)
--	declare @id int =(select i.stockId from inserted as i)
	
--	update stockInfo set stockAvailableQty=stockAvailableQty-@qty where stockId=@id
--end

--exec proc_neworder 113,8

--use Banking_DB
--create view AccountInfoView
--as 

--select * from AccountInfo as a join branchInfo as  b on a.accBranch=b.brNo
select * from AccountInfoView	
--insert into AccountInfoView values(118,'Aishu','Current',20000,30,'hi.com',30,'Ginger','Trivendrum')

--create trigger trg_AccountInfoView_insert
--on AccountInfoView
--instead of
--insert
--as
--begin
--			declare @aNo int = (select i.accNo from inserted i)
--			declare @aName varchar(20) = (select i.accName from inserted i)
--			declare @aType varchar(20) = (select i.accType from inserted i)
--			declare @aBalance int = (select i.accBalance from inserted i)
--			declare @aBranch int = (select i.accBranch from inserted i)
		
--			insert into AccountInfo values(@aNo,@aName,@aType,@aBalance,@aBranch,LOWER(CONCAT(@aname,'.',LEFT(@atype,2),'.citibank.com')))
--end




	