using System;

using Foundation;
using WatchKit;

namespace App1.WatchOS.WatchOSExtension
{
    public partial class InterfaceController : WKInterfaceController
    {
        protected InterfaceController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            myValueSlider.SetValue(0);

            Console.WriteLine("{0} awake with context", this);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine("{0} will activate", this);
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }

        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedMember.Local
        partial void btnClicked()
        {
            LogMessage("button clicked!");
        }

        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedMember.Local
        partial void sliderAction(float sender)
        {
            var debugMsg = $"slider value change to:{sender}";
            LogMessage(debugMsg);
            currentLabel.SetText(sender.ToString("0"));
        }

        private void LogMessage(string msg)
        {
            if (ObjCRuntime.Runtime.Arch == ObjCRuntime.Arch.DEVICE)
            {
                NSLogHelper.OutputStringToConsole(msg);
            }
            else
            {
                Console.WriteLine(msg);
            }
        }
    }
}

