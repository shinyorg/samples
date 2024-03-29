﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Shiny;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ShinyApplication(
    ShinyStartupTypeName = "Sample.Startup",
    XamarinFormsAppTypeName = "Sample.App"
)]

namespace Sample.Droid
{
    [Activity(
        Label = "Sample",
        Icon = "@mipmap/icon",
        Theme = "@style/MainTheme",
        MainLauncher = true,
        ConfigurationChanges =
            ConfigChanges.ScreenSize |
            ConfigChanges.Orientation |
            ConfigChanges.UiMode |
            ConfigChanges.ScreenLayout |
            ConfigChanges.SmallestScreenSize
    )]
    public partial class MainActivity : FormsAppCompatActivity
    {
        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    TabLayoutResource = Resource.Layout.Tabbar;
        //    ToolbarResource = Resource.Layout.Toolbar;
        //    base.OnCreate(savedInstanceState);
        //    Forms.Init(this, savedInstanceState);

        //    this.LoadApplication(new App());
        //}


        //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        //{
        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //    this.ShinyOnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}
    }
}