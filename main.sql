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
		VALUES('D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\1.png','����� ������� ����� �������')
			
INSERT INTO MENU(DishName, DishPrice, DishWeight, DishType, DishDescription, DishImage)
VALUES 
    ('������������ �����', 25.00, 500, '�����', '������ ����� �� ��������, �������������� �� �����, � ������ ������ � �������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\steak.png'),
    ('����� ������', 12.50, 300, '�����', '������ ����� � ��������� �� ��������� ���� � ���������� �����, �������� � ��������� ����� �� ������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\salad.png'),
    ('���� �������', 18.90, 400, '�����', '������ ����� � �������, ������ � ��������, �������� � ���������� ��������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\salad1.png'),
    ('����� � ����� ��������', 9.90, 200, '��������', '�������� �� ���� � ����������� ���� � �����, ������� �������� ��� �� ����� ���.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\coctail.png'),
    ('����� "�����������"', 14.50, 350, '�����', '���������� ����� � �������� �� ����, ������� ������������� ���� � ���������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\salad2.png'),
    ('������ ����� �������', 22.00, 600, '�����', '������� �� ��������� ����� ����, �������������� �� �����, �������� � ������� �������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\steak1.png'),
    ('����� "������"', 11.00, 250, '�����', '����� � �������, ������� � �������, ������� ���� ��� ���� ������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\salad3.png'),
    ('������ �� �����', 19.90, 500, '�����', '�����-������� �� �������� ���� � ������, ������������ � ����������� �����.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\steak2.png'),
    ('���� "�������� ����"', 13.90, 400, '����', '���� � ��������� � ������ ������, ������� ������� ��� �������� � �������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\1.png'),
    ('���� "����� �����"', 8.90, 300, '����', '���� � ������ � �������, ������� ������� ��� �� ������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\2.png');

INSERT INTO MENU(DishName, DishPrice, DishWeight, DishType, DishDescription, DishImage)
VALUES 
    ('���� "������� ������"', 15.50, 350, '����', '������ ������� ���� � ������ � �������, ������� ���� ��� ���� ��� ������ � ��������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\3.png'),
    ('����� "����� �������"', 16.90, 420, '�����', '����-������� ����� � �������������� � ������ ������, ������������ � ������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\4.png'),
    ('����� "���� ����"', 12.00, 300, '�����', '����� � �������, ������� � ������ ������, ������� ������� ��� ����.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\5.png'),
    ('����� "�����"', 18.50, 500, '�����', '������� ����� � ���������, ������� � ��������� ������, ������� ������� ���� ������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\6.png'),
    ('���� "����� �������"', 24.90, 300, '����', '�������� ��� � �������, �������, ����� � ������ �������, ����� �������� ��� ��������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\3.png'),
    ('������� �������� "�������� ����"', 15.00, 400, '����', '������ ������� ��������, ���������� �� ������� � �������� � ������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\dinner3.png'),
    ('���� "��������"', 17.50, 350, '����', '���� � ������� � ����������, ��������������� ������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\dinner2.png'),
    ('���� "���� �������"', 8.50, 200, '����', '���� � ������� ������, ������� ������� ��� ����.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\dinner1.png'),
    ('���� "�������"', 10.90, 300, '����', '���� � ������� � ��������� ���������, ��������������� �������.', 'D:\univer\������\PickmeJaeger\PickmeJaeger\Assets\Food\dinner.png');

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