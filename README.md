# Blazor CRUD Web App

## Database
1. Create a SQL Server database named `UserData` in either `(localdb)/MSSQLLocalDB` or any SQL Server in your network.
2. Create a new table using the folowing script
```sql
USE UserData;
GO
CREATE TABLE [dbo].[User](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
    [Address] [nvarchar](500) NULL,
    [Phone] [nvarchar](50) NULL,
    [Age] [nvarchar](50) NULL,
    CONSTRAINT [PK_userdetails] PRIMARY KEY CLUSTERED
    (
        [Id] ASC
    )
)
GO
```
3. Insert records using the following script to newly created `User` table 
```sql
USE UserData;
GO
INSERT INTO  [dbo].[User]
	(FirstName, LastName, [Address], Phone, Age)
VALUES
	('John', 'Doe', '100 Main St, Sacramento, CA 95814','123-123-0000','35'),
	('Chris', 'Parker', '100 2nd St, Sacramento, CA 95814','444-545-0000','30'),
	('Jennifer', 'Pratt', '100 Truxel Rd, Sacramento, CA 95834','888-656-4874','25')
GO
```

## Application
1. Open UserList.sln using Visual Studio 2022.
2. Go to `\BlazorUserList\UserList\Server\appsettings.json` and update the connection string `DefaultConnection` to point to the newly created Database.

## References
Below are the nuget packages that the project uses
- [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer) 
- [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools) 
- [MediatR](https://www.nuget.org/packages/MediatR)
- [MediatR.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/MediatR.Extensions.Microsoft.DependencyInjection/)
