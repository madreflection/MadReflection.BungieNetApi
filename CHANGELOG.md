# Change Log

***Note:*** Expect breaking changes unrelated to service changes in upcoming versions:

* Upgrading the minimum runtime to .NET Core 3.1, possibly higher.
* Switching to `System.Text.Json` for serialization and deserialization.
* Changing to a proper typed client.
* Adding dependency injection registration for `Microsoft.Extensions.DependencyInjection`.
* Removing the sync methods.  The mechanism used is not the right pattern in most cases.  If consumers need to use the API in a non-async context, they should call the async methods and get the result using whatever mechanism is appropriate in their situation.

## 0.1.12

* Regenerated the code for version 2.15.0 of the API.

## 0.1.11

* Regenerated the code for version 2.13.1 of the API.

## 0.1.10

* Regenerated the code for version 2.9.2 of the API.

## 0.1.9

* Regenerated the code for version 2.9.1 of the API.

## 0.1.8

* Regenerated the code for version 2.9.0 of the API.

## 0.1.7

* Regenerated the code for version 2.8.2 of the API.

## 0.1.6

* Improved socket usage by changing how `HttpClient` is used.
* Regenerated the code for version 2.8.1 of the API.

## 0.1.5

* Endpoints served by stats.bungie.net now use that host name directly instead of relying on the redirect.

## 0.1.4

* Temporary solution that follows the redirect for endpoints served by stats.bungie.net.

## 0.1.3

* Regenerated the code for version 2.8.0 of the API.

## 0.1.2

* Small bug fixes to code generation.
  * Some new endpoints don't have a trailing slash.  The trailing slash is significant, so it must be present or absent exactly as the definition has it.
  * Added special handling of `IReadOnlyCollectionOf*` responses.  This new case was resulting in `object` as the return type.  Other collection-like responses (e.g. `IEnumerableOf*`) contain metadata that results in array return types.
* Regenerated the code for version 2.3.6 of the API.

## 0.1.1

* Regenerated the code for version 2.3.5 of the API.

## 0.1.0

* Changed type processing to use `x-enum-is-bitmask` to apply the `[Flags]` attribute instead of using a static, separately maintained list.
* Regenerated the code for version 2.3.4 of the API.

## 0.0.12

* Regenerated the code for version 2.3.3 of the API.

## 0.0.11

* Added a Strong Name to the assembly.

## 0.0.3-0.0.10

Multiple builds to solve packaging issues.

## 0.0.1-0.0.2

Continued development.

## 0.0.0

Initial implementation.
