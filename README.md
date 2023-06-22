# v3 Samples, you can find them in the main repository [https://github.com/shinyorg/shiny/tree/master/samples](https://github.com/shinyorg/shiny/tree/master/samples)


# OLD Shiny .NET v2 Samples

## NOTES
1. Many samples have Shiny projects linked for debugging/testing by the devs, but the samples are defaulted to use nuget packages.  If the Shiny projects aren't loading, don't worry - IGNORE THEM.  The project will build just fine with nuget.  They are linked through submodules if needed for debugging against the shiny source code
2. DO NOT USE THESE FOR SENDING ISSUES - Why you ask?  Because they can often be out of date with a new Android release, a new Xamarin release, a new Xamarin Forms release, etc.  There is a lot of features & a lot of samples and at present - ONLY 1 maintainer!
3. Most nuget versions are managed through Directory.build.props which means you cannot not use the nuget manager to update packages.  This is due to how we swap between nugets for samples and debugging/testing
4. These samples are meant as GUIDELINES on how to use the libraries (which means that they don't use every feature and again why we don't want bug reports for them)
5. They are no guaranteed to be up-to-date with the latest versions of the SDK or Shiny.  SDK updates can break builds.  AGAIN, samples are samples - use these as guidelines.


## Mobile/Xamarin

|Link/Title|Description|
|----------|-----------|
|[Beacons](Beacons)|Foreground & Background detection of BluetoothLE iBeacons|
|[Beacons - Managed](Beacons)|iBeacon ranging on steroids - the managed mechanism manages broadcasting to the main thread, throttles output to keep your UI nice & snappy|
|[Push - ALL Providers (Native, OneSignal, Firebase, & Azure Notification Hubs)](Push)|Uses purely native push notification API's provided by the OS|
|[NFC](Nfc)|Near Field Communication|
|[Jobs](Jobs)|How to register jobs at startup or dynamically|
|[Key/Value Storage](Stores)|How Shiny uses a "viewmodel" style object to bind to OS preferences, secure storage, and others|
|[Bluetooth LE - Client](BluetoothLE-Client)|The biggest module in all of Shiny BluetoothLE powered by Reactive Extensions|
|[Bluetooth LE - Client Functions](BluetoothLE-Functions)|This shows other examples of the BLE client library|
|[Bluetooth LE - Client - Managed](BluetoothLE-Managed)|The BLE Managed functions make it super easy to scan and work with a BLE peripheral|
|[Bluetooth LE - Hosting](BluetoothLE-Hosting)|BLE Hosting|Foreground only on this one|sorry :)|
|[HTTP Transfers](HttpTransfers)|Perform upload & download operations while in the background.  Even track statistics while in the foreground|
|[GPS](Locations-Gps)|Background GPS|
|[Geofencing](Locations-Geofencing)|Geofence in your app with ease!  We even handle the automatic transition to different APIs when Google Play Services aren't around|
|[Motion Activity](Locations-MotionActivity)|Query your users activity|see walks, runs, drives, and more!|
|[Local Notifications](Notifications)|See how the best-of-breed local notifications for Xamarin module runs|
|[Sensors](Sensors)|Reactive sensors|RX was made for this!|
|[Speech Recognition](SpeechRecognition)|Local speech recognition|while not officially supported by Shiny|we give this away just because|


### Integrations
|Link/Title|Description|
|----------|-----------|
|[Prism + DryIoc + Shiny](Integration-Prism)|Prism Integration Example
|[Better Prism/RXUI Integration via Shiny.Framework](Integration-Best-Prism-RXUI)|Prism + ReactiveUI + Shiny with ease
|[Shiny Framework](Framework)|All the other toys our framework offers|
|[AppCenter](AppCenter)|This sample shows how to configure AppCenter logging in Shiny using Microsoft.Extensions.Logging and Shiny.Logging.AppCenter|


### Boilerplate Stuff
|Link/Title|Description|
|----------|-----------|
|[No Code Gen](Boilerplate-NoCodeGen)|AppDelegate, Android App, & Android Activity are all manually hooked for Shiny to fully operate|
|[All Code Gen](Boilerplate-All-CodeGen)|Everything from your iOS AppDelegate, Android Application & Activity, and the Shiny startup are generated|along with a lot of third party libraries|
|[Standard/Recommended](Jobs)|This will wire in your Xamarin Forms app as well as any Android/iOS boilerplate - you are in charge of the startup file|

### Advanced Customization
|Link/Title|Description|
|----------|-----------|
|[Custom Dependency Injection](DI-custom)|This example shows how to configure Shiny to use Autofac|
|[Register Platform Services](DI-platform)|This example shows how to register a platform specific services with Shiny|



## Server Side Libraries

|Link/Title|Description|
|----------|-----------|
|[Push Notification Manager](Push)|This sample shows how to use the push manager inside of your own API|
|[Localization](ApiExtensions)|Server side example of returning localization|
|[Mail Engine](ApiExtensions)|Our email templating mechanism is awesome! See it in action here|
