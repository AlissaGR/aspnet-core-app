FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiamos solo la carpeta actual (donde está el Dockerfile y el .csproj)
COPY . .

RUN dotnet restore "Mathise.Web.Page.csproj"
RUN dotnet publish "Mathise.Web.Page.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Mathise.Web.Page.dll"]

