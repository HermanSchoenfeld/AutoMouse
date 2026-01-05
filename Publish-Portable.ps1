# Publish AutoMouse.Windows.csproj with .NET Core SDK
dotnet publish "AutoMouse.Windows\AutoMouse.Windows.csproj" -c Release /p:PublishProfile=portable


# Delete .pdb and .json files from the specified directory
Remove-Item "Z:\Builds\AutoMouse\latest\portable\*.pdb"
Remove-Item "Z:\Builds\AutoMouse\latest\portable\*.json"

# Remove runtimes directory with contents
Remove-Item "Z:\Builds\AutoMouse\latest\portable\runtimes" -Force -Recurse
