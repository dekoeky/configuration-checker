#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG TARGETARCH
WORKDIR /src
COPY ["configuration-visualization/configuration-visualization.csproj", "configuration-visualization/"]
RUN dotnet restore "configuration-visualization/configuration-visualization.csproj" -a $TARGETARCH
COPY . .
WORKDIR "/src/configuration-visualization"
RUN dotnet build "configuration-visualization.csproj" -a $TARGETARCH -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "configuration-visualization.csproj" -a $TARGETARCH -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dekoeky.ConfigurationVisualization.dll"]