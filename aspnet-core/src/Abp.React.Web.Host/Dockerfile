FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Abp.React.Web.Host/Abp.React.Web.Host.csproj", "src/Abp.React.Web.Host/"]
COPY ["src/Abp.React.Web.Core/Abp.React.Web.Core.csproj", "src/Abp.React.Web.Core/"]
COPY ["src/Abp.React.Application/Abp.React.Application.csproj", "src/Abp.React.Application/"]
COPY ["src/Abp.React.Core/Abp.React.Core.csproj", "src/Abp.React.Core/"]
COPY ["src/Abp.React.EntityFrameworkCore/Abp.React.EntityFrameworkCore.csproj", "src/Abp.React.EntityFrameworkCore/"]
WORKDIR "/src/src/Abp.React.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Abp.React.Web.Host", "src/Abp.React.Web.Host"]
COPY ["src/Abp.React.Web.Core", "src/Abp.React.Web.Core"]
COPY ["src/Abp.React.Application", "src/Abp.React.Application"]
COPY ["src/Abp.React.Core", "src/Abp.React.Core"]
COPY ["src/Abp.React.EntityFrameworkCore", "src/Abp.React.EntityFrameworkCore"]
WORKDIR "/src/src/Abp.React.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Abp.React.Web.Host.dll"]
