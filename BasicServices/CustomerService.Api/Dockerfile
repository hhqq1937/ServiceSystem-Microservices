#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BasicServices/CustomerService.Api/CustomerService.Api.csproj", "BasicServices/CustomerService.Api/"]
COPY ["BasicServices/CustomerService.Application/CustomerService.Application.csproj", "BasicServices/CustomerService.Application/"]
COPY ["BasicServices/CustomerService.Domain/CustomerService.Domain.csproj", "BasicServices/CustomerService.Domain/"]
COPY ["BasicServices/Base.infrastructure/Base.infrastructure.csproj", "BasicServices/Base.infrastructure/"]
COPY ["BasicServices/CustomerService.Infrastructure/CustomerService.Infrastructure.csproj", "BasicServices/CustomerService.Infrastructure/"]
RUN dotnet restore "BasicServices/CustomerService.Api/CustomerService.Api.csproj"
COPY . .
WORKDIR "/src/BasicServices/CustomerService.Api"
RUN dotnet build "CustomerService.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CustomerService.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CustomerService.Api.dll"]
