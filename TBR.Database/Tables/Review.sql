
Create table Reviews(
ReviewId int not null,
UserId int not null,
BookId int not null,
StarRating int,
Content nvarchar(255) ,
CreatedDateUTC datetime2 default getutcdate(),
);