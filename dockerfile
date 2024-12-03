# Use .NET 8 SDK to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
# Set the working directory
WORKDIR /app
# Copy the project files
COPY . .
# Restore and build the project
RUN dotnet restore "./PaymentGateway.Api/PaymentGateway.Api.csproj" --disable-parallel
RUN dotnet publish "./PaymentGateway.Api/PaymentGateway.Api.csproj" -c release -o /app --no-restore

#RUN dotnet restore
#RUN dotnet publish -c Release -o out
# Final stage: run the application using the ASP.NET Core runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
# Expose port 80 for the application
EXPOSE 80
# Set the application to listen on IPv4 only
ENV ASPNETCORE_URLS=http://0.0.0.0:80
# Run the application
ENTRYPOINT ["dotnet", "PaymentGateway.Api.dll"]