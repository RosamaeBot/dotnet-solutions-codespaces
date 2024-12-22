
#!/bin/bash
echo "Installing prerequisites..."
dotnet tool install --global dotnet-ef
export PATH="$PATH:$HOME/.dotnet/tools"
dotnet restore
dotnet ef --version
# Install dotnet-ef if not already installed
if ! command -v dotnet-ef &> /dev/null
then
    echo "Installing dotnet-ef..."
    dotnet tool install --global dotnet-ef
fi

dotnet add package Microsoft.EntityFrameworkCore
#dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.DependencyInjection

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package xunit
dotnet add package Moq
dotnet add package xunit.runner.visualstudio
dotnet add package Microsoft.NET.Test.Sdk



dotnet restore
echo "Setting up the database..."


dotnet build
dotnet ef migrations add InitialCreate
dotnet ef database update

dotnet ef database update
dotnet run

echo "Setup complete. You can now run the application."
