FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MyStore.Applcation/MyStore.Applcation.csproj", "MyStore.Applcation/"]
RUN dotnet restore "MyStore.Applcation/MyStore.Applcation.csproj"
COPY . .
WORKDIR "/src/MyStore.Applcation"
RUN dotnet build "MyStore.Applcation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyStore.Applcation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyStore.Applcation.dll"]
