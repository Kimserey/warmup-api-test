FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["WarmupApiTest/WarmupApiTest.csproj", "WarmupApiTest/"]
RUN dotnet restore "WarmupApiTest/WarmupApiTest.csproj"
COPY . .
WORKDIR "/src/WarmupApiTest"
RUN dotnet build "WarmupApiTest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WarmupApiTest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WarmupApiTest.dll"]