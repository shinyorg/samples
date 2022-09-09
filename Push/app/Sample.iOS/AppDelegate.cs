using Foundation;
using Microsoft.Extensions.Configuration;
using Shiny;
using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


namespace Sample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			this.ShinyFinishedLaunching(new Startup
            {
#if FIREBASE
                // if you want to try initialization with straight config vars instead of a google-services.json - set the Firebase node in config and switch some comments in Startup.cs
                RegisterPlatform = (services, config) =>
                {
                    var cfg = config.GetSection("Firebase").Get<Shiny.Push.FirebaseConfiguration>() ?? throw new ArgumentException("Missing Firebase configuration");
                    services.UseFirebaseMessaging<MyPushDelegate>(cfg);
                }
#endif
            }, options);
			Forms.Init();
			this.LoadApplication(new App());
			return base.FinishedLaunching(app, options);
		}


        public override void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
            => this.ShinyRegisteredForRemoteNotifications(deviceToken);


        public override void FailedToRegisterForRemoteNotifications(UIApplication application, NSError error)
            => this.ShinyFailedToRegisterForRemoteNotifications(error);


        public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
            => this.ShinyDidReceiveRemoteNotification(userInfo, completionHandler);
    }
}
