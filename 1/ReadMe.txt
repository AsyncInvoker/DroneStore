cd /d <Путь к папке c решением>

dotnet new globaljson --sdk-version 7.0.100 --output DroneSln/DroneStore 
dotnet new web --no-https --output DroneSln/DroneStore --framework net7.0
dotnet new sln -o DroneSln 

dotnet sln DroneSln add DroneSln/DroneStore

dotnet new xunit -o DroneSln/DroneStore.Tests --framework net7.0
dotnet sln DroneSln add DroneSln/DroneStore.Tests
dotnet add DroneSln/DroneStore.Tests reference DroneSln/DroneStore

dotnet add DroneSln/DroneStore.Tests package Moq --version 4.18.4