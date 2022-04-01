dotnet publish -p:PublishSingleFile=true -r win-x64 -c Release --self-contained true -p:PublishTrimmed=true -p:EnableCompressionInSingleFile=true
dotnet publish -p:PublishSingleFile=true -r osx-x64 -c Release --self-contained true -p:PublishTrimmed=true -p:EnableCompressionInSingleFile=true
dotnet publish -p:PublishSingleFile=true -r linux-x64 -c Release --self-contained true -p:PublishTrimmed=true -p:EnableCompressionInSingleFile=true

Compress-Archive .\bin\Release\net6.0\win-x64\publish\Grumble.exe Grumble_win-x64.zip
Compress-Archive .\bin\Release\net6.0\osx-x64\publish\Grumble Grumble_osx-x64.zip
Compress-Archive .\bin\Release\net6.0\linux-x64\publish\Grumble Grumble_linux-x64.zip