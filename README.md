# ctorx.Core.Mvc.Cookies
This might very well be the smallest and simplest Github repository.


Nevertheless...

## What is it?
It is nothing more than a simple wrapper around HttpContext via IHttpContextAccessor exposing Get, Set and Delete methods for simple cookie management.

## Getting Started
Use the extension method like this:

```csharp
services.AddCookieManagement();
```

Or, if you must, you can wire it up cowboy style like this:

```csharp
services.AddScoped<ICookieManager, DefaultCookieManager>();
```

## Where can I get it?
Install from [Nuget](https://www.nuget.org/packages/ctorx.Core.Mvc.Cookies/) 
```
Install-Package ctorx.Core.Mvc.Cookies
```

## License, etc.
ctorx.Core.Mvc.Cookies is copyright © 2017 Matthew Marksbury and other contributors under the MIT license.


## Roadmap
There is no roadmap at this time
