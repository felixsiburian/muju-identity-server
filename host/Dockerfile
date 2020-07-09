FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["host/Host.csproj", "host/"]
COPY ["src/IdentityServer4.csproj", "src/"]
RUN dotnet restore "host/Host.csproj"
COPY . .
WORKDIR "/src/host"
RUN dotnet build "Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Host.dll"]