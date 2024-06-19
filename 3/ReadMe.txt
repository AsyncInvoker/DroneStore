ссылки:
.net sdk 7.0.100: https://dotnet.microsoft.com/en-us/download/dotnet/7.0
SQL Server: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
SQL Server Managment studio: https://learn.microsoft.com/ru-ru/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

Команды:
Подключиться к проекту с магазином: cd <Путь к папке c проектом>

Установить пакеты:
dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0

Установить тул для создания и миграции БД:
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef --version 7.0.0