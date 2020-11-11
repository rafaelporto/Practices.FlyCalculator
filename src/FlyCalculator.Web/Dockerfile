FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS publish
WORKDIR /build
COPY . .
RUN dotnet publish -c Release -o output

FROM nginx:alpine
WORKDIR /app
COPY --from=publish /build/output/wwwroot /usr/share/nginx/html
EXPOSE 8080