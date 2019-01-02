# BungieNetApi

This is a REST client for Bungie.net's API for Destiny.

The primary product is a pair of libraries, MadReflection.BungieNetApi.Entities and MadReflection.BungieNetApi.Client.  The LibraryGenerator project generates code in those projects using the Open API / Swagger endpoint definitions.

## Getting Started

### Install NuGet Package

There are two packages available on nuget.org.  The client package depends on the entities package so installing the former will also install the latter.

```powershell
Install-Package MadReflection.BungieNetApi.Client
```

Or you can install just the entities package.

```powershell
Install-Package MadReflection.BungieNetApi.Entities
```
