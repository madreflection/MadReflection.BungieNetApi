# MadReflection.BungieNetApi

This is a REST client for Bungie.net's API for Destiny.

The primary product is a pair of libraries, MadReflection.BungieNetApi.Entities and MadReflection.BungieNetApi.Client.  The LibraryGenerator project generates code in those projects using the Open API 3.0 specification.

## Getting Started

### Install NuGet Package

There are two packages available on nuget.org.  The [Client](https://www.nuget.org/packages/MadReflection.BungieNetApi.Client/) package depends on the [Entities](https://www.nuget.org/packages/MadReflection.BungieNetApi.Entities/) package so installing the former will also install the latter.

```powershell
Install-Package MadReflection.BungieNetApi.Client
```

Or you can install just the [Entities](https://www.nuget.org/packages/MadReflection.BungieNetApi.Entities/) package.

```powershell
Install-Package MadReflection.BungieNetApi.Entities
```

## How To Use



If you're using another container, check its documentation for how to register a singleton.

## Design

The Destiny API is divided into logical areas.  Most clients will prefix the endpoint name with the area, e.g. `Destiny2GetManifest`.  This library exposes each area as an interface provided by a property on the client's main interface.  Because the interfaces are explicity implemented by the client object, the property is essentially a cast (which can be inlined by the JIT).

Technically, the following are equivalent:

```csharp
client.Destiny2.GetManifest(...)

((IDestiny2Client)client).GetManifest(...)
```


## Caution

I do not follow [Semantic Versioning](https://semver.org/) on this project.

Due to the potential that the Open API description will introduce something that will "break" the generator or that a change needed to support a change in the description will require refactoring, I do not promise binary (ABI) compatibility from version to version.  Always recompile and test when upgrading to a newer version.

## Disclaimers

I am not affiliated with or employed by Bungie, nor have I ever been.  I created this library for fun, for my own projects which are no longer active.  I continue to maintain it because I like that it's being used by others in their own projects.

I make no committment to maintaining this for any specific amount of time or that I will support any given feature.

A significant part of this library is generated from the published Open API 3.0 specification of the Destiny API provided Bungie.  I am not responsible for the identifier names and documentation text taken therefrom.
