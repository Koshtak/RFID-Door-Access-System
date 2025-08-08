create database rfidsystem
create table authorizedCards(
Id int identity(1,1) primary key,
CardUID nvarchar(50) unique not null,
UserName nvarchar(100),
CreatedAt datetime default getdate()
);


insert into authorizedCards(CardUID, UserName)
values('03:FB:91:F6', 'efe mehmet')

