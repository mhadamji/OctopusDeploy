# build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY . .
RUN dotnet restore src/OctopusDeploy.DemoApi/OctopusDeploy.DemoApi.csproj
RUN dotnet publish src/OctopusDeploy.DemoApi/OctopusDeploy.DemoApi.csproj -c Release -o /app/publish

# run
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish ./

# Render provides PORT at runtime; ASPNETCORE_URLS is set via render.yaml
ENTRYPOINT ["dotnet", "OctopusDeploy.DemoApi.dll"]