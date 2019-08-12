# Create final image from base
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine3.9 AS final
WORKDIR /app
# Copy app from publish
COPY ./src/Core/publish ./
ENTRYPOINT ["dotnet", "helloworld.Core.dll"]
