#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["LegalDebtWebsiteDotNet7/LegalDebtWebsiteDotNet7.csproj", "LegalDebtWebsiteDotNet7/"]
RUN dotnet restore "LegalDebtWebsiteDotNet7/LegalDebtWebsiteDotNet7.csproj"
COPY . .
WORKDIR "/src/LegalDebtWebsiteDotNet7"
RUN dotnet build "LegalDebtWebsiteDotNet7.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LegalDebtWebsiteDotNet7.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LegalDebtWebsiteDotNet7.dll"]