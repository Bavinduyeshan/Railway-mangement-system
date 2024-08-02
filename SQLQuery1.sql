create TABLE Railwaysystemlogin(

ID int IDENTITY(1,1) PRIMARY KEY,
  UserName varchar(20) not null,
  password varchar(20) not null,

);

INSERT INTO Railwaysystemlogin(UserName,password)
values ('ADMIN','ADMIN');


select * from Railwaysystemlogin
