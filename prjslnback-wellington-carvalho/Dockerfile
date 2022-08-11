#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["prjslnback-wellington-carvalho/prjslnback-wellington-carvalho.csproj", "prjslnback-wellington-carvalho/"]
RUN dotnet restore "prjslnback-wellington-carvalho/prjslnback-wellington-carvalho.csproj"
COPY . .
WORKDIR "/src/prjslnback-wellington-carvalho"
RUN dotnet build "prjslnback-wellington-carvalho.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "prjslnback-wellington-carvalho.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "prjslnback-wellington-carvalho.dll"]