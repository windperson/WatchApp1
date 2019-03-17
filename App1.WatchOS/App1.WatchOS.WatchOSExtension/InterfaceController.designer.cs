// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
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

        [Action ("sliderAction:")]
        [GeneratedCode ("iOS Designer", "1.0")]
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