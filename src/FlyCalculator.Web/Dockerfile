FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine AS publish
WORKDIR /build
COPY . .
RUN apk update && \ apk add --no-cache icu-libs
RUN dotnet publish -c Release -o /app

FROM base AS final
ENV ASPNETCORE_ENVIRONMENT Production
ENV TZ=America/Sao_Paulo
RUN apk update && \ apk add --no-cache icu-libs
ENV LC_ALL pt_BR.UTF-8
ENV LANG pt_BR.UTF-8
RUN apk add tzdata && \ ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT false
WORKDIR /app
COPY --from=publish /app .

EXPOSE 80
ENTRYPOINT ["dotnet", "FlyCalculator.Web.dll"]