# Imagen base con el runtime de ASP.NET Core 8.0
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Imagen para compilar y publicar la app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiamos todo el proyecto
COPY . .

# Restauramos las dependencias
RUN dotnet restore "Mathise.Web.Page.csproj"

# Compilamos y publicamos el proyecto
RUN dotnet publish "Mathise.Web.Page.csproj" -c Release -o /app/publish

# Imagen final
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

# Ejecutamos la app
ENTRYPOINT ["dotnet", "Mathise.Web.Page.dll"]
