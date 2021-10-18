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

--insert into stockInfo values('Apple','Large cap',5400,45600)
--insert into stockInfo values('ABC','Small cap',5400,45600)
--insert into stockInfo values('Crompton','Mid cap',5400,45600)
--insert into stockInfo values('XYZ','Small cap',5400,45600)
--insert into stockInfo values('Microsoft','Large cap',5400,45600)
--insert into stockInfo values('Havels','Mid cap',5400,45600)
--insert into stockInfo values('Polycab','Mid cap',5400,45600)
--insert into stockInfo values('Samsung','Large cap',5400,45600)
--insert into stockInfo values('Facebook','Large cap',5400,45600)
--insert into stockInfo values('LMN','Small cap',5400,45600)


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