#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Gateway/Ocelot/Ocelot-GateWay.csproj", "Gateway/Ocelot/"]
RUN dotnet restore "Gateway/Ocelot/Ocelot-GateWay.csproj"
COPY . .
WORKDIR "/src/Gateway/Ocelot"
RUN dotnet build "Ocelot-GateWay.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ocelot-GateWay.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ocelot-GateWay.dll"]