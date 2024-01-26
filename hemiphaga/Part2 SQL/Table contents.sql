begin tran
insert into Products1
values
('apple', 'green', ''),
('watermelon monster', 'stripped', 'VERY BIG'),
('melon', 'yello', 'Outdated, do not eat'),
('Phone', 'golden', 'Eye-phone'),
('My car', 'black', 'Fast'),
('Something unusual', 'green', '');
commit tran

begin tran
insert into Category1
values
('Electronics', 'All my circuits'),
('Edible', 'Eat my pants'),
('Heavy', 'It''s over 9000'),
('Light', 'Angel''s feather'),
('Human', 'To be killed');
commit tran

begin tran
insert into ProductsByCategory1
values
(1,4),
(1,5),
(2,1),
(2,2),
(2,3),
(3,2),
(3,5),
(4,1),
(4,4),
(5,2);
commit tran