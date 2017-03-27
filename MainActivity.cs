﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace minefine
{
    [Activity(Label = "minefine", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);
            var toShop = FindViewById<Button>(Resource.Id.toShop);
            var mainImage = FindViewById<ImageView>(Resource.Id.mainImage);
            
            var expHour = FindViewById<TextView>(Resource.Id.expHour);

            toShop.Click += delegate
            {
                StartActivity(typeof(ShopActivity));
            };
            mainImage.Click += delegate
            {
                
            };
        }
    }
}

