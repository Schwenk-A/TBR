Create table UsersLibrary (
ID int Primary key Clustered identity(1,1),
UserId int FOREIGN KEY REFERENCES [User] (UserId),
BookId int FOREIGN KEY REFERENCES Book(BookId),
ReadingPosition int,
CreatedDateUTC datetime2 default getutcdate()

);