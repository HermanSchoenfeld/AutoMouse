# Publish Sphere10.AutoMouse.Windows.csproj with .NET Core SDK
dotnet publish "Sphere10.AutoMouse.Windows\Sphere10.AutoMouse.Windows.csproj" -c Release /p:PublishProfile=win-x64

# Delete .pdb and .json files from the specified directory
Remove-Item "Z:\Builds\AutoMouse\current\win-x64\*.pdb"
Remove-Item "Z:\Builds\AutoMouse\current\win-x64\*.json"
Remove-Item "Z:\Builds\AutoMouse\current\win-x64\*.dll"
