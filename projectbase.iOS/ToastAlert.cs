using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using projectbase.Interfaces;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(projectbase.iOS.ToastAlert))]
namespace projectbase.iOS
{
    class ToastAlert : IToastAlert
    {
        NSTimer alertDelay;
        UIAlertController alert;
        public void DisplayAlert(string message)
        {
            alertDelay = NSTimer.CreateScheduledTimer(3.5, (obj) =>
            {
                dismissMessage();
            });
            alert = UIAlertController.Create(null, message, UIAlertControllerStyle.Alert);
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, true, null);
        }

        void dismissMessage()
        {
            if (alert != null)
            {
                alert.DismissViewController(true, null);
            }
            if (alertDelay != null)
            {
                alertDelay.Dispose();
            }
        }
    }
}