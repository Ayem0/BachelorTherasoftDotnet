# Utiliser l'image .NET SDK pour construire et publier l'application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copier les fichiers .csproj des différents projets
COPY ./BachelorTherasoftDotnetApplication/BachelorTherasoftDotnetApplication.csproj ./BachelorTherasoftDotnetApplication/
COPY ./BachelorTherasoftDotnetDomain/BachelorTherasoftDotnetDomain.csproj ./BachelorTherasoftDotnetDomain/
COPY ./BachelorTherasoftDotnetInfrastructure/BachelorTherasoftDotnetInfrastructure.csproj ./BachelorTherasoftDotnetInfrastructure/
COPY ./BachelorTherasoftDotnetApi/BachelorTherasoftDotnetApi.csproj ./BachelorTherasoftDotnetApi/

# Restaurer les dépendances (en incluant tous les projets nécessaires)
RUN dotnet restore ./BachelorTherasoftDotnetApi/BachelorTherasoftDotnetApi.csproj

# Copier tout le code source des différents projets
COPY ./BachelorTherasoftDotnetApplication ./BachelorTherasoftDotnetApplication/
COPY ./BachelorTherasoftDotnetDomain ./BachelorTherasoftDotnetDomain/
COPY ./BachelorTherasoftDotnetInfrastructure ./BachelorTherasoftDotnetInfrastructure/
COPY ./BachelorTherasoftDotnetApi ./BachelorTherasoftDotnetApi/

# Compiler l'application
WORKDIR /src/BachelorTherasoftDotnetApi
RUN dotnet build "BachelorTherasoftDotnetApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "BachelorTherasoftDotnetApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BachelorTherasoftDotnetApi.dll"]
