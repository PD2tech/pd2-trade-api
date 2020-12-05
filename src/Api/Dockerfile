FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal
ARG source
WORKDIR /app
EXPOSE 9090
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "Api.dll"]