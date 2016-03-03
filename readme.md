Plot Xamarin Plugin
===================
Add location based notifications to your Xamarin project easily.

### Supported platforms ###

This plugins supports both IOS 6 or newer, and Android 2.3 or newer.

Tested under Xamarin Studio 5.10. Because this library uses native bindings the Xamarin Starter Edition is *NOT* supported.

### Integration and configuration ###

You can find the integration guide at our website: [http://www.plotprojects.com/xamarin-integration/](http://www.plotprojects.com/xamarin-integration/)

Additional settings are possible using the configuration file, an example is shown below. The publicToken and enableOnFirstRun fields are required, the notificationSmallIcon, notificationAccentColor and askPermissionAgainAfterDays options are Android only, the maxRegionsMonitored is an iOS only setting.

Information about these settings can be found in our extensive documentation, in chapter 1.4: [http://www.plotprojects.com/documentation#ConfigurationFile](http://www.plotprojects.com/documentation#ConfigurationFile)

```
{
  "publicToken": "REPLACE_ME",
  "enableOnFirstRun": true,
  "notificationSmallIcon": "ic_mood_white_24dp",
  "notificationAccentColor": "#01579B",
  "askPermissionAgainAfterDays": 3,
  "maxRegionsMonitored": 20
}
```

### Function Reference ###

#### PlotProjects.Plugin.Plot (Class) ####

_public static IPlot GetInstance(Android.Content.Context)_ **Android only**

Gets the Plot interface.

_public static IPlot GetInstance(Android.App.Activity)_ **Android only**

Gets the Plot interface.

_public static GetInstance(Foundation.NSDictionary launchOptions,System.Boolean debug)_ **iOS only**

Gets the Plot interface.

_public static void HandleNotification(UIKit.UILocalNotification localNotification)_ **iOS only**

Forwards the notification to the Plot library. Required to ensure the notification statictics are updated.

_public static void PlotProjects.Plugin.Plot.MailDebugLog_

Mails the debug log. Only works when, on Android the debug meta-data property of the PlotService is set to true, or on
iOS the debug parameter of GetInstance was set to true.

#### PlotProjects.Plugin.Abstractions.IPlot (Interface) ####

You can get an instance of this class by calling Plot.GetInstance(…). You shouldn't implement this
class yourself.

_public void Enable()_

Enable the Plot library. It will remember this between sessions.

_public void Disable()_

Disable the Plot library. It will remember this between sessions.

_public string Version_

Gets the current version number of the Plot library backing this plugin.


### More information ###
Website: [http://www.plotprojects.com/](http://www.plotprojects.com/)

Documentation: [http://www.plotprojects.com/documentation](http://www.plotprojects.com/documentation)

### License ###
The source files included in the repository are released under the Apache License, Version 2.0. The Plot Projects library is available under its own [Terms and conditions](http://www.plotprojects.com/terms-and-conditions/).