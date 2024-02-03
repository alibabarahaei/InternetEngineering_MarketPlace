#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MarketPlace.Presentation/MarketPlace.Presentation.csproj", "MarketPlace.Presentation/"]
COPY ["MarketPlace.Application/MarketPlace.Application.csproj", "MarketPlace.Application/"]
COPY ["MarketPlace.Domain/MarketPlace.Domain.csproj", "MarketPlace.Domain/"]
COPY ["MarketPlace.Infrastructure.EFCore/MarketPlace.Infrastructure.EFCore.csproj", "MarketPlace.Infrastructure.EFCore/"]
RUN dotnet restore "./MarketPlace.Presentation/./MarketPlace.Presentation.csproj"
COPY . .
WORKDIR "/src/MarketPlace.Presentation"
RUN dotnet build "./MarketPlace.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MarketPlace.Presentation.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarketPlace.Presentation.dll"]