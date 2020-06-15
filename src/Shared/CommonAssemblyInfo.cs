using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyProduct("Bungie.net API Client for .NET")]
[assembly: AssemblyCopyright("Copyright © 2018-2020 Benn Benson")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: AssemblyVersion("0.1.6")]
[assembly: AssemblyFileVersion("0.1.6")]
[assembly: AssemblyInformationalVersion("0.1.6 for API version 2.8.0")]

#if SIGNED
[assembly: InternalsVisibleTo("MadReflection.BungieNetApi.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100a5319e6aa91a47e3a83f39db873f1f39bc80c96a2199524158365d4b4e0f8433bd6259fb4e3fb895e9d4d953385356433852d268daaad0bfacf75d431f0e7bfe51315ee64eafbdf5bcfbb4e903db1ae4025312bc07aea73f0470e5cd297f23110462e85df4fbbde120cf9cfbff0785857372bd91810bb1e43c6cd5b2a713099f")]
#else
[assembly: InternalsVisibleTo("MadReflection.BungieNetApi.Tests")]
#endif
