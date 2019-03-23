﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace App1.WatchOS.WatchOSExtension
{
    public static class NSLogHelper
    {
        const string FoundationLibrary = "/System/Library/Frameworks/Foundation.framework/Foundation";

        [System.Runtime.InteropServices.DllImport(FoundationLibrary)]
        public static extern void NSLog(IntPtr format, IntPtr s);

        [System.Runtime.InteropServices.DllImport(FoundationLibrary, EntryPoint = "NSLog")]
        public static extern void NSLog_ARM64(IntPtr format, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6, IntPtr p7, IntPtr p8, IntPtr s);

        static readonly bool Is64Bit = IntPtr.Size == 8;
        static readonly bool IsDevice = ObjCRuntime.Runtime.Arch == ObjCRuntime.Arch.DEVICE;

        static readonly Foundation.NSString nsFormat = new Foundation.NSString(@"%@");

        public static void OutputStringToConsole(string text)
        {
            using (var nsText = new Foundation.NSString(text))
            {
                if (IsDevice && Is64Bit)
                {
                    NSLog_ARM64(nsFormat.Handle, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, nsText.Handle);
                }
                else
                {
                    NSLog(nsFormat.Handle, nsText.Handle);
                }
            }
        }

    }
}