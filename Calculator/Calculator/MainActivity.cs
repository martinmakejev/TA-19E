﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Calculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var calcbutton = FindViewById<Button>(Resource.Id.toCalcButton);
            var tipCalcbutton = FindViewById<Button>(Resource.Id.toTipCalcButton);
            calcbutton.Click += Button_Click;
            tipCalcbutton.Click += TipCalcButton_Click;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(CalculatorActivity));
            StartActivity(intent);
        }

        private void TipCalcButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(TipcalcActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}