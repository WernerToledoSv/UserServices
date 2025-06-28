# Imagen base para ejecución (runtime)
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base

# Instala certificados y soporte para globalización
RUN apk add --upgrade --no-cache \
    krb5-libs \
    ca-certificates \
    tzdata \
    icu-libs \
    icu-data-full

# Configura zona horaria y cultura
ENV TZ=America/El_Salvador
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=0
ENV DOTNET_EnableDiagnostics=0

# Establece usuario y directorio de trabajo
USER app
WORKDIR /app

# Expone puertos
EXPOSE 80
EXPOSE 443

# Imagen para compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build

ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copia los archivos de proyecto (ajustado a carpetas reales)
COPY ["WebApi/WebApi.csproj", "WebApi/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Infraestructure/Infraestructure.csproj", "Infraestructure/"]

# Restaurar dependencias
RUN dotnet restore "WebApi/WebApi.csproj"

# Copia el resto del código fuente
COPY . .

# Establecer directorio de trabajo para compilación
WORKDIR "/src/WebApi"

# Compilar
RUN dotnet build "WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publicar
FROM build AS publish

RUN dotnet publish "WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Imagen final
FROM base AS final

WORKDIR /app

# Copiar archivos publicados
COPY --from=publish /app/publish .

# Entrypoint
ENTRYPOINT ["dotnet", "WebApi.dll"]
    