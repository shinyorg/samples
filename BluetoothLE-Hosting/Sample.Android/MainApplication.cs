using Android.App;
using Android.Runtime;
using Shiny;
using System;

namespace Sample.Droid
{
    [Application]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }


        public override void OnCreate()
        {
            base.OnCreate();
            this.ShinyOnCreate(new Startup());
        }
    }
}