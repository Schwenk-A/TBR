Create table Book(

BookId int Primary Key Clustered Identity(1,1),
Title varchar not null, 
Author varchar not null,
ISBN varchar not null,
BookUrl varchar,
ImageUrl varchar,
Subject varchar,
PublishedYear int,
PageCount int,
CreatedDateUTC datetime2 default getutcdate(),
);