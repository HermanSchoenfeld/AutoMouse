# Publish Sphere10.AutoMouse.Windows.csproj with .NET Core SDK
dotnet publish "Sphere10.AutoMouse.Windows\Sphere10.AutoMouse.Windows.csproj" -c Release /p:PublishProfile=portable


# Delete .pdb and .json files from the specified directory
Remove-Item "Z:\Builds\AutoMouse\current\portable\*.pdb"
Remove-Item "Z:\Builds\AutoMouse\current\portable\*.json"

# Remove runtimes directory with contents
Remove-Item "Z:\Builds\AutoMouse\current\portable\runtimes" -Force -Recurse
