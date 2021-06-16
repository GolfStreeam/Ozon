FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY Ozon.TestProject.UnitTests ./Ozon.TestProject.UnitTests
COPY Ozon.TestProject ./Ozon.TestProject
RUN dotnet restore "Ozon.TestProject.UnitTests/Ozon.TestProject.UnitTests.csproj"
CMD dotnet test "Ozon.TestProject.UnitTests/Ozon.TestProject.UnitTests.csproj" -l "console;verbosity=detailed"


