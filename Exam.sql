

create table Customers
(
	Id serial primary key,
	FullName varchar,
	Email varchar,
	PhoneNumber varchar,
	Address varchar,
	ProfileImage bytea
);

create table Accounts
(
	Id serial primary key,
	Account_number varchar,
	Account_type varchar,
	Balance decimal,
	CustomerId int references Customers(Id)
);

create table Transactions 
(
	Id serial primary key,
	SenderId int references Customers(Id),
	RecipientId int references Customers(Id),
	Amount decimal,
	TransactionDate date
);





