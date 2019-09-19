# Stage 1 Build
FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app
COPY webapp/*.csproj ./
COPY . ./
RUN dotnet restore

#stage 2 publish 
FROM build-env AS publish
RUN dotnet publish -c Release -o /app

#stage 3 Create final image
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
LABEL Author="Lyndon Hills"
LABEL Maintainer="mydevnotes"
COPY --from=publish /app .
COPY --from=publish /app/webapp .
#ENTRYPOINT ["dotnet", "webapp.dll", "--server.urls", "http://*:80"]
ENTRYPOINT ["dotnet", "webapp.dll"]