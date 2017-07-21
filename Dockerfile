# Use the standard Microsoft .NET Core container
FROM microsoft/dotnet

COPY . /app
WORKDIR /app

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

EXPOSE 8080/tcp
EXPOSE 80/tcp
ENV ASPNETCORE_URLS http://*:8080

ENTRYPOINT ["dotnet", "run"]