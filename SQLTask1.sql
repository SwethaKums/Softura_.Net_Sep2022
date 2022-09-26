use AdventureWorks2019
go
use Test
go
select Firstname ,lastname
from Person.Person
where title is not null

select Firstname ,lastname
from Person.Person
where FirstName like'%[a]' and Lastname  like'%[a]'
 select * from HumanResources.Department

select scr.CurrencyCode,sc.Name
from Sales.Currency sc,sales.CountryRegionCurrency scr


 
 create schema HR
 go
 select * into HR.Dept from HumanResources.Department

 create table studentails(
 sno int identity(1,1),
 Firstname varchar(25),
 Lastname varchar(25),
 Dateofjoining date,
 Department varchar(25))

 insert into studentails values('swetha','kumar','07/23/1999','cse')
 insert into studentails values('Arjun','kumar','23/12/1999','it')
 insert into studetails values('swathi','Murugan','09/17/2022','CSE')
insert into studetails values('kaviya','vel','09/17/2022','it')
insert into studetails values('divya','venkat','09/17/2022','mech')
insert into studetails values('mercy','Samuel','09/17/2022','civil')
insert into studetails values('sandy','Venkat','09/17/2022','bio')
insert into studetails values('mythili','k','09/17/2022','e&i')
insert into studetails values('Priya','V','09/17/2022','cse')
insert into studetails values('vishnu','k','09/17/2022','civil')
insert into studetails values('jaya','S','09/17/2022','it')
insert into studetails values('Jancy','Vel','09/17/2022','mech')
insert into studetails values('kumutha','arumugam','09/17/2022','eee')
insert into studetails values('giri','arumugam','09/17/2022','eee')
insert into studetails values('devi','p','09/17/2022','e&i')
insert into studetails values('meena','kumar','09/17/2022','it')
insert into studetails values('lalitha','Babu','09/17/2022','civil')
insert into studetails values('muthu','kumar','09/17/2022','bio')
insert into studetails values('praveen','raj','09/17/2022','bio')
select* from studentails
go

Select bedid.BusinessEntityID,bedid.AddressTypeID
from Person.BusinessEntityAddress bedid
inner join HumanResources.department deptt
on deptt.ModifiedDate=bedid.ModifiedDate

select distinct GroupName from
HumanResources.Department

select pro.StandardCost,sum(prop.ListPrice+prop.StandardCost) as Sumoflistprice
SumOfListPrice_SC
from Production.ProductCostHistory pro
join Production.product prop
on prop.StandardCost=pro.StandardCost group by pro.StandardCost

select DATEDIFF(YEAR,StartDate,EndDate) as Yearsonrole
from HumanResources.EmployeeDepartmentHistory

select sum(SalesQuota+5000) as total
from Sales.SalesPersonQuotaHistory
where SalesQuota>100000 group by SalesQuota order by SalesQuota asc

Select max(TaxRate) as MAXtaxRate
from Sales.SalesTaxRate

select DepartmentID,emp.BusinessEntityID,ShiftID,BirthDate,FLOOR(DATEDIFF(DAY,BirthDate,getdate())/365.25) as age
from HumanResources.Employee Emp
join HumanResources.EmployeeDepartmentHistory Edhi ON
Edhi.BusinessEntityID=Emp.BusinessEntityID

CREATE VIEW HumanResources.Name_age
as
select DepartmentID,emp.BusinessEntityID,ShiftID,BirthDate,FLOOR(DATEDIFF(DAY,BirthDate,getdate())/365.25) as age
from HumanResources.Employee emp
join HumanResources.EmployeeDepartmentHistory edhi on
edhi.BusinessEntityID=emp.BusinessEntityID

select D.DepartmentID,max(ephi.rate)Rate
from HumanResources.Department D
join HumanResources.EmployeeDepartmentHistory edhi on
edhi.DepartmentID=D.DepartmentID
join HumanResources.EmployeePayHistory ephi on ephi.BusinessEntityID=edhi.BusinessEntityID
group by D.DepartmentID order by D.DepartmentID

select FirstName,MiddleName,Title,AddressTypeID,pp.BusinessEntityID
from Person.Person pp
left join Person.BusinessEntityAddress pbea on pp.BusinessEntityID=pbea.BusinessEntityID
where pp.Title is not null

select ProductID,LocationID,Shelf
from Production.ProductInventory 
where (ProductID between 300 and 350) and (LocationID=50) or (Shelf='E')

select ppi.LocationID,Shelf,Name
from Production.ProductInventory ppi
join Production.Location plo
on
ppi.LocationID=plo.LocationID

select AddressID,AddressLine1,AddressLine2,psp.StateProvinceID,StateProvinceCode,CountryRegionCode
from person.StateProvince psp
join Person.Address pad
on 
psp.StateProvinceID=pad.StateProvinceID

select scrc.CurrencyCode,sum(ssoh.SubTotal+ssoh.TaxAmt) as Total
from Sales.SalesOrderHeader ssoh
inner join Sales.SalesTerritory sst on 
ssoh.TerritoryID=sst.TerritoryID
inner join sales.CountryRegionCurrency scrc on 
scrc.CountryRegionCode=sst.CountryRegionCode
group by CurrencyCode



