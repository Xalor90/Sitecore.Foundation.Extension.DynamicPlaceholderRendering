# Dynamic Placeholder Rendering Extension for Sitecore 9

This extension will allow you to capture unused Placeholders and Dynamic Placeholders for easy access by intercepting the Processor Pipeline.

## License
[MIT](/LICENSE.md)

## How to install:
- To begin, clone this repo into an existing Sitecore 9, Helix-based Solution under `/src/Foundation/Extension`.
- Build project and ensure NuGet restores missing NuGet packages.
- Copy the contents of `/App_Config` into your primary web project alongside your existing `/App_Config` files.
- Add a reference of this project to your primary web app and rebuild the entire Solution.

## How to use:
- To access the list of unused Placeholder keys, use `Sitecore.Context.Items["unusedPlaceholderKeys"]`.

## Attribution:
- [Richard Seal](https://sitecore.stackexchange.com/a/7944/3838)

While working with native Dynamic Placeholders in Sitecore 9, I came across an issue that was solved by following the answer to [this question](https://sitecore.stackexchange.com/questions/7943/find-out-if-dynamic-placeholder-has-renderings) on the Sitecore StackExchange, as provided by Richard Seal (link above).