using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinDrawing.Droid
{
    [Activity(Label = "XamarinDrawing.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            DrawView draw = new DrawView(this);
            draw.Start(); 
            SetContentView(draw);
        }
    }
}


