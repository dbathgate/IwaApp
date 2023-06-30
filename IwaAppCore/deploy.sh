rm -rf ./publish

dotnet publish -c Release --self-contained -r win-x64 -o publish

cf push