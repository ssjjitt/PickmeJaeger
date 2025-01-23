create database PickmeJaeger;
drop database PickmeJaeger;
use PickmeJaeger;

select * from USERS;
select * from MENU;
select * from RESTABLES;
select * from REVIEWS;
select * from RESTABLES;

delete from USERS where UserLogin = 'user1';

drop table USERS;

CREATE TABLE USERS(
	UserID int identity(1,1) primary key,
	UserLogin nvarchar(20),
	UserPassword nvarchar(20),
	UserAffiliation nvarchar(13) default 'client'
)

CREATE TABLE MENU(
	DishId int identity(1,1) primary key,
	DishName nvarchar(50),
	DishPrice decimal(5,2),
	DishWeight int,
	DishDescription nvarchar(500),
	DishType nvarchar(20),
	DishImage nvarchar(500)
)

CREATE TABLE RESTABLES(
	TableID int identity(1,1) primary key,
	OrdinalNumber smallint
)

CREATE TABLE ORDERS(
	OrderID int identity(1,1) primary key,
	UserOID int foreign key references USERS(UserID),
	BookingDatetime smalldatetime,
	TableOID int foreign key references RESTABLES(TableID),
	UserEmail nvarchar(30),
	Wishes nvarchar(200),
	OrderStatus int default 0
)

CREATE TABLE REVIEWS(
	ReviewID int identity(1,1) primary key,
	UserRID int foreign key references USERS(UserID),
	ReviewText nvarchar(500),
	ReviewImage nvarchar (500)
)

INSERT INTO USERS(UserLogin, UserPassword, UserAffiliation) 
				VALUES ('Admin', '1234', 'administrator');

INSERT INTO USERS(UserLogin, UserPassword) 
				VALUES ('ssjjitt', '1234');

INSERT INTO USERS(UserLogin, UserPassword) 
				VALUES ('user1', '1234');

INSERT INTO USERS(UserLogin, UserPassword) 
				VALUES ('user2', '1234');

INSERT INTO USERS(UserLogin, UserPassword) 
				VALUES ('user3', '1234');

INSERT INTO USERS(UserLogin, UserPassword) 
				VALUES ('user4', '1234');

INSERT INTO ORDERS(UserOID, BookingDatetime, TableOID, UserEmail, Wishes)
		VALUES (2, '2024-05-04 16:00:00', 1, 'ssjjitt@gmail.com', 'Maybe table 2')

INSERT INTO REVIEWS(ReviewImage, ReviewText)
		VALUES('D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\1.png','класс спасибо очень приятно')
			
INSERT INTO MENU(DishName, DishPrice, DishWeight, DishType, DishDescription, DishImage)
VALUES 
    ('Титанический Стейк', 25.00, 500, 'Стейк', 'Сочный стейк из говядины, приготовленный на гриле, с острым соусом и овощами.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\steak.png'),
    ('Стена Салата', 12.50, 300, 'Салат', 'Свежие овощи с заправкой из лимонного сока и оливкового масла, подаются в хрустящей стене из лаваша.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\salad.png'),
    ('Ужас Титанов', 18.90, 400, 'Салат', 'Острый салат с курицей, лапшой и специями, подается с хрустящими гренками.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\salad1.png'),
    ('Кровь и Плоть Коктейль', 9.90, 200, 'Коктейль', 'Коктейль из ягод с добавлением рома и лайма, который взбодрит вас во время боя.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\coctail.png'),
    ('Салат "Завоеватель"', 14.50, 350, 'Салат', 'Шоколадный пирог с начинкой из ягод, который символизирует силу и стойкость.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\salad2.png'),
    ('Мясные Лавры Рейнера', 22.00, 600, 'Стейк', 'Ассорти из различных видов мяса, приготовленных на гриле, подается с острыми соусами.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\steak1.png'),
    ('Салат "Микаса"', 11.00, 250, 'Салат', 'Салат с курицей, авокадо и орехами, который даст вам силу Микасы.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\salad3.png'),
    ('Титаны на гриле', 19.90, 500, 'Стейк', 'Гриль-ассорти из куриного филе и овощей, маринованных в специальном соусе.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\steak2.png'),
    ('Боул "Скорость Эрен"', 13.90, 400, 'Боул', 'Боул с говядиной и острым перцем, который придаст вам скорость и энергию.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\1.png'),
    ('Боул "Стена Мария"', 8.90, 300, 'Боул', 'Боул с кремом и ягодами, который защитит вас от голода.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\2.png');

INSERT INTO MENU(DishName, DishPrice, DishWeight, DishType, DishDescription, DishImage)
VALUES 
    ('Боул "Дыхание Титана"', 15.50, 350, 'Боул', 'Острый куриный боул с лапшой и овощами, который даст вам силы для борьбы с титанами.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\3.png'),
    ('Паста "Кровь Титанов"', 16.90, 420, 'Паста', 'Ярко-красная лапша с морепродуктами и острым соусом, напоминающая о битвах.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\4.png'),
    ('Паста "Боец Эрен"', 12.00, 300, 'Паста', 'Паста с курицей, авокадо и острым соусом, который придаст вам силы.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\5.png'),
    ('Паста "Титан"', 18.50, 500, 'Паста', 'Большая паста с говядиной, овощами и пикантным соусом, который насытит даже титана.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\6.png'),
    ('Боул "Атака Титанов"', 24.90, 300, 'Боул', 'Японский рис с лососем, авокадо, манго и соусом терияки, чтобы зарядить вас энергией.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\3.png'),
    ('Куриные Крылышки "Скорость Эрен"', 15.00, 400, 'Ужин', 'Острые куриные крылышки, обжаренные во фритюре и подаются с соусом.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\dinner3.png'),
    ('Ужин "Защитник"', 17.50, 350, 'Ужин', 'Ужин с грибами и пармезаном, символизирующее защиту.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\dinner2.png'),
    ('Ужин "Сила Титанов"', 8.50, 200, 'Ужин', 'Ужин с ягодным соусом, который придаст вам силы.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\dinner1.png'),
    ('Ужин "Надежда"', 10.90, 300, 'Ужин', 'Ужин с корицей и ванильным мороженым, символизирующий надежду.', 'D:\univer\курсач\PickmeJaeger\PickmeJaeger\Assets\Food\dinner.png');

INSERT INTO RESTABLES (OrdinalNumber)
VALUES (1),
	   (2),
	   (3),
	   (4),
	   (5),
	   (6),
	   (7),
	   (8),
	   (9),
	   (10),
	   (11),
	   (12),
	   (13),
	   (14),
	   (15)