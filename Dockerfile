#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
ENV ASPNETCORE_URLS http://+
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["RUFR.Api.Web/RUFR.Api.Web.csproj", "RUFR.Api.Web/"]
COPY ["RUFR.Api.Model/RUFR.Api.Model.csproj", "RUFR.Api.Model/"]
COPY ["RUFR.Api.DataLayer/RUFR.Api.DataLayer.csproj", "RUFR.Api.DataLayer/"]
COPY ["RUFR.Api.Service/RUFR.Api.Service.csproj", "RUFR.Api.Service/"]
RUN dotnet restore "RUFR.Api.Web/RUFR.Api.Web.csproj"
COPY . .
WORKDIR "/src/RUFR.Api.Web"
RUN dotnet build "RUFR.Api.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RUFR.Api.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RUFR.Api.Web.dll"]