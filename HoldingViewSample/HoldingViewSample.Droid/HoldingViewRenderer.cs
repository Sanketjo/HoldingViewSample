using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using HoldingViewSample;
using HoldingViewSample.Droid;

[assembly: ExportRenderer(typeof(HoldingView), typeof(HoldingViewRenderer))]
namespace HoldingViewSample.Droid
{
    public class HoldingViewRenderer : ViewRenderer
    {
        private int _seconds;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                Touch -= HandleTouch;
            }

            if (e.NewElement != null)
            {
                Touch += HandleTouch;
            }
        }

        private void HandleTouch(object sender, TouchEventArgs e)
        {
            Console.WriteLine(e.Event.Action);

            if (e.Event.Action == MotionEventActions.Down)
            {
                _seconds = DateTime.UtcNow.Second;
            }
            else if (e.Event.Action == MotionEventActions.Up)
            {
                var dif = Math.Abs(DateTime.UtcNow.Second - _seconds);
                if (dif > 1)
                {
                    ((HoldingView)Element).FireHolding();
                }
            }
        }
    }
}