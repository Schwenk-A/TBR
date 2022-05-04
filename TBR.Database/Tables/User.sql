Create table [User] (
UserId int Primary Key Clustered Identity(1,1),
UserName varchar (max) not null ,
Password varchar (max) not null, 
FirstName varchar not null,
LastName varchar (max) not null,
Email varchar not null,
Birthday datetime2 not null,
CreatedDateUTC datetime2 default getutcdate()
)
