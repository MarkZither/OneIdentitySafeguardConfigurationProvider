#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview AS build
WORKDIR /src
COPY ["samples/SampleWebApi/SampleWebApi.csproj", "samples/SampleWebApi/"]
RUN dotnet restore "samples/SampleWebApi/SampleWebApi.csproj"
COPY . .
WORKDIR "/src/samples/SampleWebApi"
RUN dotnet build "SampleWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleWebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleWebApi.dll"]