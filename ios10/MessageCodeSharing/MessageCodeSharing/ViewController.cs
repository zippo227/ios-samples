﻿using System;
using CrashlyticsKit;
using UIKit;

namespace MessageCodeSharing
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

            Crashlytics.Instance.Initialize();
            Firebase.Analytics.Loader.ForceLoad();
            Couchbase.Lite.Storage.SystemSQLite.Plugin.Register();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
