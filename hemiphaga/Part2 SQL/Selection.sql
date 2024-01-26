select * from Products1;
select * from Category1;
select * from ProductsByCategory1;

select Products1.Name as 'Product', Category1.Name as 'Category' from Products1
left join  ProductsByCategory1
on Products1.ID = ProductsByCategory1.ProductId
left join Category1
on ProductsByCategory1.CategoryId = Category1.ID