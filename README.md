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

If you get error like "Unable to find a match: dotnet-sdk-7.0" while installing the following commands.

sudo yum install aspnetcore-runtime-7.0
sudo yum install dotnet-sdk-7.0

Then run the below command to register the microsoft packages (https://docs.servicestack.net/deploy-netcore-to-amazon-linux-2-ami#install.net-6.0)

sudo rpm -Uvh https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm 


#Verified Sign on Github commits
https://roelofjanelsinga.com/articles/how-to-setup-gpg-signing-keys-in-github/