
--use Banking_DB

--create Table tbl_accounts
--(accno int,
--accname varchar(20) not null,
--acctype varchar(20)not null,
--accbalance float,
--accbranch int,
--accpan float not null,
--accisactive bit,
--constraint pk_no primary key(accno),
--constraint  check_name check(len(accname)>=3),
--constraint  check_type check(acctype in ('Savings','Current','PF')),
--constraint unk_pan unique(accpan)

--)

--insert into tbl_accounts values(101,'Varsha','Savings',5000,1,12356,1);
--insert into tbl_accounts values(102,'Meera','PF',5800,1,88356,1);
--insert into tbl_accounts values(103,'Gikku','Current',5800,1,12456,null);
--alter table tbl_accounts add constraint pk_acc primary key(accno)

--alter table tbl_accounts drop constraint unk_pan
--alter table tbl_accounts alter column accpan varchar(20)
--alter table tbl_accounts add constraint unk_pan unique(accpan)

--sp_help tbl_accounts

--create table tbl_branchinfo
--(
--brno int,
--brname varchar(20),
--brcity varchar(20),
--bremail varchar(20),

--constraint pk_brno primary key(brno),
--constraint uk_brname unique(brname),
--constraint check_brcity check(brcity in('Kochi','Mumbai','Delhi','Trivandrum'))
--)

--insert into tbl_branchinfo values(1,'Bandra','Mumbai','bandra@abcbank')
--insert into tbl_branchinfo values(2,'Kazhakuttam','Kochi','kazhakuttam@abcbank')
--insert into tbl_branchinfo values(3,'Agra','Delhi','agra@abcbank')

--alter table tbl_accounts  add constraint fk_branch foreign key(accbranch) references tbl_branchinfo(brno)

insert into tbl_accounts values(104,'Aakash','Savings',8500,2,97356,0);