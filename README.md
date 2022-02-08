# ctorx.Core.AspNet.Cookies
This might very well be the smallest and simplest Github repository.


Nevertheless...

## What is it?
It is nothing more than a simple wrapper around HttpContext via IHttpContextAccessor exposing Get, Set and Delete methods for simple cookie management.

## Getting Started
Use the extension method like this:

```csharp
services.AddCookieManagement();
```

## Where can I get it?
Install from [Nuget](https://www.nuget.org/packages/ctorx.Core.AspNet.Cookies/) 
```
Install-Package ctorx.Core.AspNet.Cookies
```

## License, etc.
ctorx.Core.Mvc.Cookies is copyright © 2022 Matthew Marksbury and other contributors under the MIT license.
