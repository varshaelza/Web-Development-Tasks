--use Banking_DB
--create view Accounts 
--as
--select accNo,accName,accType,accBalance,accBalance *0.1 as Bonus,
--										accBalance *.25 as [Monthly Interest],
--										accBalance*.25*3 as[Quarterly Interest],
--										accBalance*.25*12 as [Annual Interest],
--										brNo,brName,brCity
--										from AccountInfo join branchInfo
--										on AccountInfo.accBranch=branchInfo.brNo

select * from Accounts order by accBalance desc
