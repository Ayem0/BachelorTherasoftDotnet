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

RUN dotnet tool install --global dotnet-ef

ENV PATH="$PATH:/root/.dotnet/tools"

COPY . .

# Build the project
RUN dotnet build "./BachelorTherasoftDotnetApi/BachelorTherasoftDotnetApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This step is required only if you're still doing a full publish (for production)
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./BachelorTherasoftDotnetApi/BachelorTherasoftDotnetApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage: for developmsnt (dotnet watch run)
FROM build AS devs
WORKDIR /src


# Command to run the app in watch mode for development (with the project path specified)
CMD ["dotnet", "watch", "run", "--project", "/src/BachelorTherasoftDotnetApi/BachelorTherasoftDotnetApi.csproj", "--urls", "http://0.0.0.0:8080"]