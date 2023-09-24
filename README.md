# dotnet-container-app-aws-ec2

Based on https://codewithmukesh.com/blog/hosting-aspnet-core-webapi-on-amazon-ec2/

```c#
dotnet new gitignore
dotnet new sln -n ProductCRUD
dotnet new webapi -o src/ProductCRUD.API --framework net7.0
dotnet sln add .\src\ProductCRUD.API\ProductCRUD.API.csproj
git add .
git commit -m "initial changes"
git push
```