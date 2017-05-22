using System;

using UIKit;
//using CrashlyticsKit;

namespace IceCreamBuilder {
	public partial class ViewController : UIViewController {
		protected ViewController (IntPtr handle) : base(handle)
		{
            //Crashlytics.Instance.Log("Will trigger 'can't lipo directories'");
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}
	}
}

