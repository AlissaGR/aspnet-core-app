FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia solo el archivo .csproj para restaurar dependencias primero
COPY Mathise.Web.Page/Mathise.Web.Page.csproj Mathise.Web.Page/
RUN dotnet restore Mathise.Web.Page/Mathise.Web.Page.csproj

# Copia todo el código fuente
COPY . .

# Instala locales y configura UTF-8 para español
RUN apt-get update && apt-get install -y locales \
    && locale-gen es_ES.UTF-8

ENV LANG=es_ES.UTF-8
ENV LANGUAGE=es_ES:es
ENV LC_ALL=es_ES.UTF-8

# Publica el proyecto en Release
RUN dotnet publish Mathise.Web.Page/Mathise.Web.Page.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Mathise.Web.Page.dll"]

