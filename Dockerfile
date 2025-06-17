FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Mathise.Web.Page/Mathise.Web.Page.csproj", "Mathise.Web.Page/"]
RUN dotnet restore "Mathise.Web.Page/Mathise.Web.Page.csproj"
COPY . .
RUN apt-get update && apt-get install -y locales
RUN locale-gen es_ES.UTF-8
ENV LANG es_ES.UTF-8
ENV LANGUAGE es_ES:es
ENV LC_ALL es_ES.UTF-8

RUN dotnet publish "Mathise.Web.Page.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Mathise.Web.Page.dll"]


