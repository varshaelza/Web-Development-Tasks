--use Shopping_DB
--alter function greetings() returns varchar(50)
--as 
--begin
--	return 'Hello and Welcome to TSQL'
--end
--select dbo.greetings() as Message
--select dbo.greetings() as [Message],cName as Customer from customerList 

--alter function greetings2(@name varchar(20) ) returns varchar (50)
--begin
--	return 'Hello ' +@name
--end
--select dbo.greetings2(cName) as Greetings from customerList

--create function calculate(@num1 int,@num2 int,@action varchar(3)) returns int
--begin
--	if(@action='add')
--	begin
--		return @num1+@num2;
--	end
--	else if(@action='sub')
--	begin
--		return @num1-@num2;
--	end
--	else if(@action='mul')
--	begin
--		return @num1*@num2;
--	end
--	else if(@action='div')
--	begin
--		return @num1/@num2;
--	end
--	return 0;
--end
--select 1 as [Num1],2 as [Num2], dbo.calculate(1,2,'add') as [Sum],
--								dbo.calculate(1,2,'sub') as [Difference],
--								dbo.calculate(1,2,'mul') as [Product],
--								dbo.calculate(1,2,'div') as [Quotient],
--								dbo.calculate(1,2,'kk') as [Other]

--create function SimpleInterest(@principle float,@roi float,@time int) returns float
--begin
--	declare @interest float;
--	set @interest=(@principle*@roi*@time)/100;
--	return @interest;
--end;
--select dbo.SimpleInterest(10000,9,10) as [S.I]


--use Banking_DB
--alter function Bonus(@balance int,@type varchar(20))returns float
--as
--begin
--	declare @rate int;
--	if(@type='Savings')
--	begin
--		set @rate=10;
--	end
--	else if(@type='Current')
--	begin
--		set @rate=20;
--	end
--	else
--	begin
--		set @rate=2;
--	end
--	return (@balance*@rate)/100;
--end
--select accNo,accName,accBalance,accType,dbo.Bonus(accBalance,accType) as[Bonus] from AccountInfo

--alter function CityBonus(@accNo int,@accBalance float )returns float
--as 
--begin
--	declare @brno int;
--	declare @brcity varchar(20);
--	set @brno=(select accBranch from AccountInfo where accNo=@accNo)
--	set @brcity =(select brCity from branchInfo where brNo=@brno)
--	declare @rate int;
--	if(@brcity='Kochi')
--	begin
--		set @rate=5;
--	end
--	else if(@brcity='Trivendrum')
--	begin
--		set @rate=10;
--	end
--	else if(@brcity='Mumbai')
--	begin
--		set @rate=15;
--	end;
	
	
--	return (@accBalance*@rate)/100;
--end
--select dbo.CityBonus(accNo,accBalance) as [City Bonus]from AccountInfo

--alter function GetEmail(@accNo int) returns varchar(50)
--as
--begin
--	declare @name varchar(20)=(select accName from AccountInfo where accNo=@accNo)
--	declare @type varchar(20)= (select accType from AccountInfo where accNo=@accNo)
--    declare @city varchar(20)=(select brCity from branchInfo where brNo=(select accBranch from AccountInfo where accNo=@accNo))
--	return LOWER(CONCAT(@name,'.',LEFT(@type,2),'@citybank.co.',LEFT(@city,2)))
--end
--select accName as [Name],accType as[Type],brCity as [City],dbo.GetEmail(accNo) as [Email] from Accountinfo join branchInfo on accBranch=brNo


--TASK
--ALTER function CTCCalculator(@YOE int,@gender varchar(1)) returns float
--as
--begin
--	declare @basicsal float;
--	if(@YOE>=0 and @YOE<=2)
--	begin
--		set @basicsal=8000;
--	end
--	else if(@YOE>2 and @YOE<=5)
--	begin
--		set @basicsal=10000;
--	end
--	else if(@YOE>5 and @YOE<=7)
--	begin
--		set @basicsal=12000;
--	end
--	else if(@YOE>7)
--	begin
--		set @basicsal=15000;
--	end
--	declare @hra float =(12.5*@basicsal)/100;
--	declare @food float=500;
--	declare @travel float=1200;
--	declare @pf float =500;
--	declare @gross float=@basicsal+@hra+@food+@travel-@pf;
--	declare @tax float;
--	if(@gender='f')
--	begin
--		set @tax=(8.5*@basicsal)/100;
--	end
--	else if(@gender='m')
--	begin
--		set @tax=(12*@basicsal)/100;
--	end
--	declare @net float=@gross-@tax
--	return @net*12
--end
--select dbo.CTCCalculator(5,'m') as CTC 
		
--alter table AccountInfo add accEmail varchar(30)
--alter procedure addAccount(@accName varchar(20),@accType varchar(20),@accBalance int,@accBranch int)
--as
--begin
--	declare @accNo int=(select max(accNo)+1 from AccountInfo)
--	declare @city varchar(20)=(select brCity from branchInfo where brNo=@accBranch)
--	declare @accEmail varchar(30)=LOWER(CONCAT(@accName,'.',LEFT(@accType,2),'@citibank.co.',LEFT(@city,2)))
--	insert into AccountInfo values(@accNo,@accName,@accType,@accBalance,@accBranch,@accEmail)
--end

--exec addAccount 'Mayaa','PF',2000,20

--TASK
--create table Login 
--(
--username varchar(20),
--password varchar(20),
--status varchar(20),
--hits int,
--constraint pk_login primary key(username),
--constraint check_pwd check(len(password)>=6)
--)
--create procedure adduser(@username varchar(20),@password varchar(20))
--as 
--begin
--	insert into Login values(@username,@password,'Active',0);
--end
--exec adduser 'aakash','aakash123'
--exec adduser 'varsha','varsha123'
--exec adduser 'gikku','gikku123'
--exec adduser 'meera','meera123'

--alter procedure  proc_Login (@username varchar(20),@password varchar(20))
--as
--begin
--	if((select count(*) from Login where username=@username and password=@password and status='Active')=1)
--	begin
--		print 'Login Successful. Welcome!'
--		update Login set status='Logged in', hits=0 where username=@username and password=@password
--	end
--	else if((select count(*) from Login where username=@username and password=@password)=0)
--	begin
--		print 'Invalid credentials.'
--		if((select hits from Login where username=@username)<3)
--			begin
--			update Login set  hits=hits+1 where username=@username
--			end
--		else
--			begin
--			print 'Account locked.Please contact administrator.'
--			update Login set status='Locked' where username=@username
--			end
--	end
--	else if((select count(*) from Login where username=@username and password=@password and status='Logged in')=1)
--	begin
--		print 'Already Logged in'
--	end
--	else
--	begin
--		print 'Account locked.Please contact administrator.'
--	end
--end
--exec proc_Login 'varsha','varsha123'


--create table ICICIBank
--(
--accNo int identity(100,1),
--accName varchar(20) not null,
--accBalance float not null
--constraint pk_icici primary key(accNo)
--)

--insert into ICICIBank values('Varsha',10000)
--insert into ICICIBank values('Meera',20000)
--insert into ICICIBank values('Gikku',30000)
--insert into ICICIBank values('Aakash',40000)
--insert into ICICIBank values('Christi',50000)
--insert into ICICIBank values('Malu',60000)
--insert into ICICIBank values('Vincy',70000)
--insert into ICICIBank values('Sreelakshmi',80000)
--insert into ICICIBank values('Devi',90000)
--insert into ICICIBank values('Divya',88000)


--create table HDFCBank
--(
--accNo int identity(500,1),
--accName varchar(20) not null,
--accBalance float not null
--constraint pk_hdfc primary key(accNo)
--)
--insert into HDFCBank values('Sankar',11000)
--insert into HDFCBank values('Sharook',22000)
--insert into HDFCBank values('Arjun',33000)
--insert into HDFCBank values('Aleena',44000)
--insert into HDFCBank values('Vinaya',55000)
--insert into HDFCBank values('Aparna',66000)
--insert into HDFCBank values('Leba',77000)
--insert into HDFCBank values('Sneha',88000)
--insert into HDFCBank values('Harry',99000)
--insert into HDFCBank values('Akhil',15800)

--create table TransactionsInfo 
--(
--trno int identity(1000,1),
--dateoftrans date,
--fromacc int,
--toacc int,
--frombank varchar(20),
--tobank varchar(20),
--trtype varchar(20),
--amount float
--)

--alter table TransactionsInfo add constraint check_trtype check(trtype in ('Swipe','Online','Tap'))
--alter table TransactionsInfo add constraint pk_transact primary key(trno)
	 
--alter procedure transact(@fromacc int,@toacc int,@frombank varchar(5),@tobank varchar(5),@trtype varchar(20),@amount float)
--as 
--begin

--	declare @success int=0
	
--	if(@frombank='HDFC')
--	begin
--		if((select accBalance from HDFCBank where accNo=@fromacc)>@amount)
--		begin
--			update HDFCBank set accBalance=accBalance-@amount where accNo=@fromacc
--			set @success=1
--		end
--	end
--	else if(@frombank='ICICI')
--	begin
--		if((select accBalance from ICICIBank where accNo=@fromacc)>@amount)
--		begin
--			update ICICIBank set accBalance=accBalance-@amount where accNo=@fromacc
--			set @success=1
--		end
	
--	end
--	if(@success=1)
--	begin
--		if(@tobank='HDFC')
--		begin
		
--			update HDFCBank set accBalance=accBalance+@amount where accNo=@toacc
			
--		end
--		else if(@tobank='ICICI')
--		begin
		
--			update ICICIBank set accBalance=accBalance+@amount where accNo=@toacc
			
--		end
--		else
			
--		insert into TransactionsInfo values(Getdate(),@fromacc,@toacc,@frombank,@tobank,@trtype,@amount)
--	end
--	else
--	begin
--		print 'Transaction failed'
--	end
	
--end

--alter table HDFCBank add constraint check_bal check(accBalance>=0)
--alter table ICICIBank add constraint check_bal check(accBalance>=0)
--alter procedure transacts(@fromacc int,@toacc int,@frombank varchar(5),@tobank varchar(5),@trtype varchar(20),@amount float)
--as 
--begin

	
--	declare @from varchar(20)=@frombank+'BANK'
--	declare @to varchar(20)=@tobank+'BANK'
	
--	exec('update ' +@from+' set accBalance=accBalance- '+@amount +' where accNo='+@fromacc)
		
--	EXEC('update ' +@to+' set accBalance=accBalance+ '+@amount +' where accNo='+@toacc)
			
--	insert into TransactionsInfo values(Getdate(),@fromacc,@toacc,@frombank,@tobank,@trtype,@amount)
	
	
--end

--exec transact 101,501,'ICICI','HDFC','Swipe',100
--exec transact 601,102,'HDFC','ICICI','Tap',100
--exec transacts 102,104,'ICICI','ICICI','Online',100


