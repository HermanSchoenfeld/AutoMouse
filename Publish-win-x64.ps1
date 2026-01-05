# Publish AutoMouse.Windows.csproj with .NET Core SDK
dotnet publish "AutoMouse.Windows\AutoMouse.Windows.csproj" -c Release /p:PublishProfile=win-x64

# Delete .pdb and .json files from the specified directory
Remove-Item "Z:\Builds\AutoMouse\latest\win-x64\*.pdb"
Remove-Item "Z:\Builds\AutoMouse\latest\win-x64\*.json"
Remove-Item "Z:\Builds\AutoMouse\latest\win-x64\*.dll"
