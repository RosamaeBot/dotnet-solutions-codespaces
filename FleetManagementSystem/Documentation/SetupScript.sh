
#!/bin/bash
echo "Installing prerequisites..."
dotnet restore
echo "Setting up the database..."
dotnet ef database update
echo "Setup complete. You can now run the application."
