Easy Riot API
---
## Description
This is a simple Dotnet 8 wrapper around the Riot API. Main focus is to make it easy to call the Riot API and get the data you need. 
Retry logic is not included and should be handled by the consumer. Not every API call is implemented, as the application process for a production key is currently in progress.

## Usage
The riot API consists of many different group of API endpoints. Every group is represented as a service in the EasyRiotApi. 
To be able to use each service, simply call the AddEasyRiotApi() extension method on the IServiceCollection in the ConfigureServices method in the Startup.cs file. 
```csharp
services.AddEasyRiotApi(configuration);
```
The configuration object should contain the following properties:
```json
{
  "EasyRiotApi": {
    "ApiKey": "YOUR_API_KEY"
  }
}
```

## To do:
- [] If application is approved, implement all API calls
- [] Allow end user to specify if the library should retry on failure
- [] Implement caching of data

## Support

If you find this library helpful, you can support its development by making a donation:

[![Donate with PayPal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.me/pascalvorwerk)

Thank you for your support!
## Disclaimer
EasyRiotApi isn't endorsed by Riot Games and doesn't reflect the views or opinions of Riot Games or anyone officially involved in producing or managing Riot Games properties. Riot Games, and all associated properties are trademarks or registered trademarks of Riot Games, Inc.