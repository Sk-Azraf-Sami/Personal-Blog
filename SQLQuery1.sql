create table blog
(
  Bid int not null primary key identity(1,1),
  Btitle nvarchar (150),
  Bcatagory nvarchar(150),
  BDesc nvarchar(300),
  BUrl nvarchar(300),
  Bposteddate datetime 
) 