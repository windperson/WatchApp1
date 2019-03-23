// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace App1.WatchOS.WatchOSExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel currentLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceSlider myValueSlider { get; set; }

		[Action ("btnClicked")]
		partial void btnClicked ();

		[Action ("sliderAction:")]
		partial void sliderAction (System.Single sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (currentLabel != null) {
				currentLabel.Dispose ();
				currentLabel = null;
			}

			if (myValueSlider != null) {
				myValueSlider.Dispose ();
				myValueSlider = null;
			}
		}
	}
}
