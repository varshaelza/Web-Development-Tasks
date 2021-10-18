
--													DAY 1

--create database Shopping_DB
--use Shopping_DB

--create table productList
--(
--pID int,
--pName varchar(20) not null,
--pCategory varchar(20) not null,
--pPrice float not null,
--pAvailableQty int not null,
--constraint pk_pID primary key(pID),
--constraint check_pName check(len(pName)>=3),
--constraint check_pCategory check(pCategory in ('Utensils','Home Appliance','Stationary','Eatables','Gadgets')),
--constraint check_pAvailableQty check(pAvailableQty>=0)
--)
--insert into productList values(101,'Pressure Cooker','Utensils',3500,15)
--insert into productList values(102,'Instrument Box','Stationary',7800,12)
--insert into productList values(103,'Washing Machine','Home Appliance',3500,15)
--insert into productList values(104,'Maggi Noodles','Eatables',3500,15)
--insert into productList values(105,'Redmi Note 7 Pro','Gadgets',3500,15)
--insert into productList values(106,'Lays','Eatables',3500,15)
--insert into productList values(107,'Air Conditioner','Home Appliance',3500,15)
--insert into productList values(108,'Milk Cooker','Utensils',3500,15)
--insert into productList values(109,'Books','Stationary',3500,22)
--insert into productList values(110,'Frying pan','Utensils',8000,3)

--create table customerList
--(
--cID int,
--cName varchar(20) not null,
--cMobile varchar(20),
--cEmail varchar(20),
--cAddress varchar(100),
--constraint pk_cID primary key(cID),
--constraint uk_cMobile unique(cMobile),
--constraint uk_cEmail unique(cMobile)
--)
--insert into customerList values(1,'Varsha','9999999999','varshagikku@soti.net','ABC Kottayam')
--insert into customerList values(2,'Christina','8888888888','christina@soti.net','ABC Kochi')
--insert into customerList values(3,'Malavika','7777777777','malavika@soti.net','ABC Banglore')
--insert into customerList values(4,'Vincy','66666666666','vincy@soti.net','ABC NewYork')
--insert into customerList values(5,'Sreelakshmi','5555555555','sree@soti.net','ABC TVM')
--insert into customerList values(6,'Ayona','4444444444','ayo@soti.net','ABC Mathura')
--insert into customerList values(7,'Aju','3333333333','aju@soti.net','ABC Canada')
--insert into customerList values(8,'Roshy','2222222222','rosh@soti.net','ABC Chennai')
--insert into customerList values(9,'Harry','11111111111','harry@soti.net','ABC Torronto')
--insert into customerList values(10,'Alan','0000000000','alan@soti.net','ABC Kollam')

--create table orders
--(
--oID int,
--productID int not null,
--customerID int not null,
--OrderQty int not null,
--amount float not null,
--orderDate date not null,
--constraint pk_oID primary key(oID),
--constraint fk_pID foreign key(productID) references productList(pID),
--constraint fk_cID foreign key(customerID) references customerList(cID),
--constraint check_qty check(OrderQty>=1),
--)
----alter table orders add constraint uk_orders unique(customerID,productID,orderDate)
--insert into orders values(1001,101,5,1,3500,GETDATE())
--insert into orders values(1002,105,5,2,9000,GETDATE())
--insert into orders values(1003,105,8,1,4500,GETDATE())
--insert into orders values(1004,104,1,2,7000,GETDATE())
--insert into orders values(1005,102,1,1,7800,GETDATE())
--insert into orders values(1006,108,4,1,3500,GETDATE())
--insert into orders values(1007,109,3,1,8700,GETDATE())
--insert into orders values(1008,107,6,2,90000,GETDATE())
--insert into orders values(1009,102,6,1,7800,GETDATE())
--insert into orders values(1010,103,6,1,10000,GETDATE())
--insert into orders values(1011,104,5,1,3500,GETDATE())
--insert into orders values(1012,106,5,2,9000,GETDATE())
--insert into orders values(1013,108,8,1,4500,GETDATE())
--insert into orders values(1014,107,1,2,7000,GETDATE())
--insert into orders values(1015,106,1,1,7800,GETDATE())
--insert into orders values(1016,106,4,2,7000,GETDATE())
--insert into orders values(1017,105,3,1,8700,GETDATE())
--insert into orders values(1018,104,6,1,45000,GETDATE())
--insert into orders values(1019,108,6,1,7800,GETDATE())
--insert into orders values(1020,109,6,1,7800,GETDATE()

--select * from productList
--select pID as ID,pName as  Product ,pAvailableQty as Available,pPrice as Price from productList
--select pName as Product,pPrice as Price,pPrice*0.1 as Discount,pPrice-pPrice*0.1 as [Offer Price],pAvailableQty as [Qty Left] from productList 
--select CONVERT(varchar,pID) +'-'+pName as Product from productList
--select distinct pCategory as Categories  from productList
--select UPPER(pName) as Product from productList
--select LOWER(pName) as Product from productList
--select UPPER(LEFT(pname,1))+Lower(SUBSTRING(pName,2,20)) from productList
--select REPLACE('Hello Everyone','Hello','Hi') as [Text]


--													DAY 2

--use Shopping_DB
--select pID,pName,pCategory,pPrice,case pCategory when 'Home Appliance' then pPrice*10/100 
	--											when 'Eatables' then pPrice*20/100
		--										when 'Gadgets' then pPrice*30/100 
			--									when 'Stationary' then pPrice*40/100 
				--								when 'Utensils' then pPrice*50/100 
					--							else pPrice*5/100
						--						end
							--					as [Discount] from productList
--select  CONCAT(CONVERT(varchar,pID),'-',Upper(pName)) as Products from productList 

--use Banking_DB
--select * from tbl_accounts
--alter table tbl_accounts add  accemail varchar(20)
--alter table tbl_accounts drop column  accemail 
--select accno as Number ,accname as [Name],CONCAT(LOWER(accname),'.',LOWER(LEFT(ACCTYPE,2)),'@citibank.com') as Email from tbl_accounts

--use Shopping_DB
--select * from productList
--select Count(pPrice) as [Count],Max(pPrice) as [Maximum],Min(pPrice) as [Minimum],Avg(pPrice)  as [Average],Sum(pPrice) as [Sum] from productList

--select getdate() as [START],dateadd(year,5,getdate()) as [END]
--select datediff(day,'18-sep-2021',dateadd(day,5,getdate())) as Interval
--select Convert(date,'16-Aug-2021') as [Joining Date] ,
--	   dateadd(week,2,convert(date,'16-aug-2021')) as [Training Start Date],
--	   dateadd(day,45,dateadd(week,2,convert(date,'16-aug-2021'))) as [Training End Date],
--	   dateadd(month,3,convert(date,'16-aug-2021')) as [Project Start Date],
--	   dateadd(month,6,convert(date,'16-aug-2021')) as [Meeting Date],
--	   dateadd(month,12,convert(date,'16-aug-2021')) as [Salary Appraisal Date],
--	   dateadd(year,5,convert(date,'16-aug-2021')) as [Gratuity Eligibility Date] ,
--	   datediff(day,Convert(date,'16-Aug-2021'),dateadd(year,5,convert(date,'16-aug-2021'))) as [Total Days]

--select * from productList for json path

--select * from productList where pName like 'Washing Machine'
--select * from productList order by pPrice desc,pAvailableQty desc

--select orders.oID,productList.pID from productList,orders
--select * from orders,productList




