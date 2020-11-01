CREATE DATABASE FoodDB 
ON
(
name='FoodDB',
FILENAME='F:\´óÈý\NET Core\ASP.NET-Core-\MVCFootDemo\SQL\FoodDB'
)
create table FoodList
(
FoodID int primary key identity(1,1),
FoodName nvarchar(30),
Pic nvarchar(100),
TypeID int,
Price decimal(10,2),
SalesVolume int
)
create table FoodType
(
TypeID int primary key identity(1,1),
TypeName nvarchar(50)
)