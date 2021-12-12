#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Icarosdev.Sonos.WebControl/Server/Icarosdev.Sonos.WebControl.Server.csproj", "Icarosdev.Sonos.WebControl/Server/"]
COPY ["Icarosdev.Sonos.WebControl/Client/Icarosdev.Sonos.WebControl.Client.csproj", "Icarosdev.Sonos.WebControl/Client/"]
COPY ["Icarosdev.Sonos.Api/Icarosdev.Sonos.Api.csproj", "Icarosdev.Sonos.Api/"]
RUN dotnet restore "Icarosdev.Sonos.WebControl/Server/Icarosdev.Sonos.WebControl.Server.csproj"
COPY . .
WORKDIR "/src/Icarosdev.Sonos.WebControl/Server"
RUN dotnet build "Icarosdev.Sonos.WebControl.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Icarosdev.Sonos.WebControl.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Icarosdev.Sonos.WebControl.Server.dll"]