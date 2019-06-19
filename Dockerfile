FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["KubePoc.API/KubePoc.API.csproj", "KubePoc.API/"]
RUN dotnet restore "KubePoc.API/KubePoc.API.csproj"
COPY . .
WORKDIR "/src/KubePoc.API"
RUN dotnet build "KubePoc.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "KubePoc.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "KubePoc.API.dll"]