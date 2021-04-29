--[01]Print the city name and the count of authors from every city. 
 select city,count(*) from authors group by city

 --[02]Print the authors who are not from the city in which the publisher 'New Moon Book' is from.
 select distinct city,au_fname from authors where city not in
(select city from publishers where pub_name = 'New Moon Books')

--[03]Create a procedure that will take a author first and last name and new price.The procedure should update the price of books written by author with the given name.
alter proc proc_PriceUpdate(@au_fname varchar(20),@au_lname varchar(40),@price float)
as 
begin
update titles set price = @price
select au_fname,au_lname,price,title from authors,titles where au_fname = @au_fname
end

exec proc_PriceUpdate Ann,Dull,200

--[04]Create a function that will calculate tax for every sale of book.
    --The function should take quantity and return tax.
alter function fun_BookTax(@quantity varchar(10))
returns @TaxTable table(title_id varchar(10),tax varchar(10))
as
begin
declare 
@count int,
@tax varchar(10),
@t_id varchar(15)
set @count=(select distinct qty from sales where ord_num=@quantity)
	if(@count<10)
		set @tax='2%'
	else if(@count>10 and @count<20)	
		set @tax='5%'
	else if(@count>20 and @count<50)	
		set @tax='6%'
	else if(@count >=50)	
		set @tax='7.5%'
	set @t_id=(select title_id from sales where ord_num=@quantity)
	insert into @TaxTable values(@t_id,@tax) 
	return
end
select title_id,tax from dbo.fun_BookTax('QQ2299')
