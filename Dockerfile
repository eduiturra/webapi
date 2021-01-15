FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app 
#
# copy csproj and restore as distinct layers
COPY *.sln .
COPY webapi.api/*.csproj ./webapi.api/
COPY webapi.business/*.csproj ./webapi.business/
COPY webapi.core/*.csproj ./webapi.core/
COPY webapi.test/*.csproj ./webapi.test/ 
COPY webapi.root/*.csproj ./webapi.root/ 
COPY webapi.data/*.csproj ./webapi.data/ 

#
RUN dotnet restore 
#
# copy everything else and build app
COPY webapi.api/. ./webapi.api/
COPY webapi.business/. ./webapi.business/
COPY webapi.core/. ./webapi.core/
COPY webapi.root/. ./webapi.root/
COPY webapi.data/. ./webapi.data/
COPY webapi.test/. ./webapi.test/

#
WORKDIR /app
RUN dotnet publish -c Release -o out 
#
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app 
EXPOSE 80
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "webapi.api.dll"]