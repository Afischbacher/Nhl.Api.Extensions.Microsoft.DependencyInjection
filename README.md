[![Build/Test](https://github.com/Afischbacher/Nhl.Api.Extensions.Microsoft.DependencyInjection/actions/workflows/build-master.yml/badge.svg)](https://github.com/Afischbacher/Nhl.Api.Extensions.Microsoft.DependencyInjection/actions/workflows/build-master.yml)
[![Build/Test](https://github.com/Afischbacher/Nhl.Api.Extensions.Microsoft.DependencyInjection/actions/workflows/build-develop.yml/badge.svg)](https://github.com/Afischbacher/Nhl.Api.Extensions.Microsoft.DependencyInjection/actions/workflows/build-develop.yml)
[![NuGet](https://img.shields.io/nuget/v/Nhl.Api)](https://www.nuget.org/packages/Nhl.Api.Extensions.Microsoft.DependencyInjection)
[![Issues](https://img.shields.io/github/issues/Afischbacher/Nhl.Api.Extensions.Microsoft.DependencyInjection.svg)](https://github.com/Afischbacher/Nhl.Api.Extensions.Microsoft.DependencyInjection/issues)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://GitHub.com/Afischbacher/Nhl.Api.Extensions.Microsoft.DependencyInjection/graphs/commit-activity)

# Nhl.Api.Extensions.Microsoft.DependencyInjection 🧑‍💻
The Microsoft .NET dependency injection library extension for the official unofficial .NET NHL API  🏒

An extension for the Nhl.Api to easily add the Nhl.Api library to any .NET project using the built in .NET dependency injection library

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

### Singleton (Default)
```
builder.Services.AddNhlApi(serviceLifetime: ServiceLifetime.Singleton);
```
### Transient
```
builder.Services.AddNhlApi(serviceLifetime: ServiceLifetime.Transient);
```
### Scoped
```
builder.Services.AddNhlApi(serviceLifetime: ServiceLifetime.Scoped);
```

## Bugs 🐛
If you have any issues with the library or suggestions, please feel free to create an issue and it will be adressed as soon as possible :)

