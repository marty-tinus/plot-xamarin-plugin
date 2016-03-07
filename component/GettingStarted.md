# Getting Started with Plot Projects
We assume in this guide you already have an account for our dashboard. Don’t have an account yet? [Sign up for free!](http://www.plotprojects.com/getourplugin/)

## Both iOS and Android
*Step 1*: Our library supports both iOS and Android. Start with adding this component to your iOS and Android projects.

It is possible to make use of the IPlot interface in your own portable library projects, but then you still have to add the Plot Projects Xamarin Plugin to the platform specific projects as well.

## Android steps
You can skip this section when your app doesn’t need Android support.

*Step 2*: Place plotconfig.json in the Assets folder of your Android project. You can configure Plot through the configuration file. You can find an example config file and your public token on the Developer page on our dashboard.

*Step 3*: Call PlotProjects.Plugin.Plot.GetInstance(activity) from the OnCreate method of one of your activities.

Known issue for Android: When the Android Package name contains a dash or an underscore the mail debug log feature doesn’t work. You can fix this by adding the following element to the application element of your AndroidManifest, with YOUR_PACKAGE_NAME replaced:
    <provider
         android:authorities="YOUR_PACKAGE_NAME.plot.debuglogprovider"
         android:name="com.plotprojects.retail.android.DebugLogProvider"
         android:exported="true" />

When your android package name doesn’t contain any special characters, no steps are required.

## iOS steps
You can skip this section when your app doesn’t need iOS support.

*Step 4*: Place plotconfig.json in the Resources folder of your project. You can configure Plot through the configuration file. You can find an example config file and your public token on the Developer page on our dashboard.

*Step 5*: Add the following line to your FinishedLaunching method in your AppDelegate:

    PlotProjects.Plugin.Plot.GetInstance(launchOptions, true);


*Step 6*: Also copy the following snippet to your AppDelegate:

    public override void ReceivedLocalNotification (UIApplication application, UILocalNotification notification)
    {
        PlotProjects.Plugin.Plot.HandleNotification (notification);
    }

*Step 7*: Add the property “Location Always Usage Description” in Info.plist with as value a message for your users describing why your app uses the location of the device. This can be done in the Info.plist file while selecting the source tab. The description could be for example: “Your location is used to instantly inform you when you are near a location that is interesting to you.” This description text is shown when permission to use the location of the device is requested via the opt-in dialog. Note that for the app to be accepted in the App Store, the description why the app needs location services must be clear to the end user.

## Done
You are now ready to receive your first notification. For more details, look at the [extensive documentation](/documentation/) or our [Github page](https://github.com/Plotprojects/plot-xamarin-plugin).
