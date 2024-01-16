#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Используем образ для сборки приложения
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS build-env
WORKDIR /app

# Копируем файлы проекта и восстанавливаем зависимости
COPY *.csproj ./
RUN dotnet restore

# Копируем остальные файлы исходного кода и публикуем приложение
COPY . ./
RUN dotnet publish -c Release -o out

# Используем образ dotnet/aspnet для запуска приложения
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
RUN --from=build-env /app/out .

# Открываем порт 80 для веб-сервера
EXPOSE 80

# Запускаем приложение
ENTRYPOINT ["dotnet", "Web.dll"]