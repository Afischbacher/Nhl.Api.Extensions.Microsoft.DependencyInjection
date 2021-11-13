# Nhl.Api.Extensions.Microsoft.DependencyInjection 🧑‍💻
The Microsoft .NET dependency injection library extension for the official unofficial .NET NHL API  🏒

An extension for the Nhl.Api to easily add it to any .NET project using the built in .NET dependency injection library

## Installing Nhl.Api.Extensions.Microsoft.DependencyInjection 💭
You should install Nhl.Api.Extensions.Microsoft.DependencyInjection with NuGet:
```
Install-Package Nhl.Api.Extensions.Microsoft.DependencyInjection
```
Or via the .NET Core command line interface:
```
dotnet add package Nhl.Api.Extensions.Microsoft.DependencyInjection
```

## Implementation 🚀
Using and implementing the Nhl.Api dependency injection extension is as simple as one line on C# code ⌨️
```
builder.Services.AddNhlApi();
```

You can also use a method parameter to specify the type of dependency life time

### Transient (Default)
```
builder.Services.AddNhlApi(serviceLifetime: ServiceLifetime.Transient);
```
### Singleton  
```
builder.Services.AddNhlApi(serviceLifetime: ServiceLifetime.Singleton);
```
### Scoped
```
builder.Services.AddNhlApi(serviceLifetime: ServiceLifetime.Scoped);
```
