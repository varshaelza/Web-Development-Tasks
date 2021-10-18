--use Banking_DB
--create table branchInfo
--(
--	brNo int primary key,
--	brName varchar(20),
--	brCity varchar(20)
--)

--insert into branchInfo values(10,'Bandra','Mumbai');
--insert into branchInfo values(20,'Munnar','Kochi');
--insert into branchInfo values(30,'Ginger','Trivendrum');
--insert into branchInfo values(40,'Nariman','Mumbai');
--insert into branchInfo values(50,'Dadar','Mumbai');

--create table AccountInfo
--(
--	accNo int primary key,
--	accName varchar(20),
--	accType varchar(20),
--	accBalance int,
--	accBranch int,
--	constraint fk_brno foreign key(accBranch) references branchInfo(brNo)
--)
--insert into AccountInfo values(101,'Nidhi','Savings',9000,20)
--insert into AccountInfo values(102,'Roshni','Savings',9000,10)
--insert into AccountInfo values(103,'Aman','Savings',9000,30)
--insert into AccountInfo values(104,'Amar','Current',9000,20)
--insert into AccountInfo values(105,'Akbar','Savings',9000,30)
--insert into AccountInfo values(106,'Anthony','Savings',9000,20)
--insert into AccountInfo values(107,'Ramesh','Savings',9000,30)
--insert into AccountInfo values(108,'Suresh','Current',9000,10)
--insert into AccountInfo values(109,'Moin','Savings',9000,30)
--insert into AccountInfo values(110,'Madhu','Current',9000,30)
--insert into AccountInfo values(111,'Anjali','Savings',9000,30)

--select * from AccountInfo
--select * from branchInfo
--select * from AccountInfo,branchInfo
--select * from AccountInfo ,branchInfo where AccountInfo.accBranch=branchInfo.brNo
--select * from AccountInfo as a join branchInfo as b on a.accBranch =b.brNo where a.accType='Savings' order by a.accBalance desc
--insert into AccountInfo(accNo,accName,accType,accBalance) values(112,'Malavika','Savings',9000)
--insert into AccountInfo(accNo,accName,accType,accBalance) values(113,'Christi','Current',9000)
--insert into AccountInfo(accNo,accName,accType,accBalance) values(114,'Vincy','Savings',9000)
--select * from AccountInfo as a full join branchInfo as b on a.accBranch =b.brNo 
--select a.accName as [Name],a.accType as [Type],b.brName as[Branch],CONCAT(LOWER(a.accName),'.',LOWER(LEFT(a.accType,2)),'@mybank.co.'+LOWER(LEFT(b.brName,2))) as Email from AccountInfo as a join branchInfo as b on a.accBranch=b.brNo
--update AccountInfo set accBranch =40 where accNo in(112,114)
--update accountInfo set accBranch=50 where accNo=113

--update AccountInfo set accBalance =accBalance +200 where accNo in(101,105,108,109,115)
--update AccountInfo set accBalance=accBalance+780 where accName like 'a%'

--select accType as [Type],SUM(accBalance) as [Total Balance] from AccountInfo group by accType
--insert into AccountInfo values(115,'Aleena','PF',5600,10)
--select  accType as [Type],SUM(accBalance) as [Total Balance] from AccountInfo group by accType order by accType 

--select accName as [Name] from AccountInfo where accBalance= (select Max(accBalance )from AccountInfo)
--select top 1 accName as [Name] from AccountInfo order by accBalance desc

--select b.brCity as [City],count(accNo) as [No. of Accounts] from AccountInfo as a join branchInfo as b on a.accBranch=b.brNo group by b.brCity
--select top 1 b.brCity as [City],sum(accBalance) as [Total Balance] from AccountInfo as a join branchInfo as b on a.accBranch=b.brNo group by b.brCity order by sum(accBalance) desc
--select b.brCity as [City],count(accNo) as [No. of Savings Accounts] from AccountInfo as a join branchInfo as b on a.accBranch=b.brNo where a.accType='Savings' group by b.brCity
--select b.brCity as [City]from AccountInfo as a join branchInfo as b on a.accBranch=b.brNo where a.accBalance=(select max(accBalance) from AccountInfo)
--select distinct b.brCity as [City] from AccountInfo as a join branchInfo as b on a.accBranch=b.brNo  where (select avg(accBalance) from AccountInfo join branchInfo on AccountInfo.accBranch=branchInfo.brNo where brCity=b.brCity)<(select avg(accBalance) from AccountInfo )
--select a.accNo as [Acc.No],a.accName as [Name],b.brCity as [City] from AccountInfo as a join branchInfo as b on a.accBranch=b.brNo where a.accBalance in (select max(accBalance) from AccountInfo join branchInfo on AccountInfo.accBranch=branchInfo.brNo group by brCity)

