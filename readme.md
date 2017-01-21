# Global Exception Handling in AspNet Core with Mongo #

### Summary ###
This sample shows how to implement global exception handling in AspNet Core by injecting your own filter globally into the pipeline. Solution is using Mongo as log store for the purpose of my scenario.

### Solution ###
Solution | Author(s)
---------|----------
GEH.Sample | Ilker Karimanov

### Version history ###
Version  | Date | Comments
---------| -----| --------
1.0  | September 10th 2016 | Initial release

### Disclaimer ###
**THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.**


----------

# Solution Settings #
* In order to use this samples should install MongoDB instance and apply ncessary changes in appsettings.json

* Review logging configuration in Startup.cs, as minimum log level or applying different settings based environment running into.

Code snippet:
```C#
 loggerFactory.AddMongoLogging<ErrorLog>(_serviceProvider, (text, logLevel) 
            => logLevel >= LogLevel.Debug);

```


