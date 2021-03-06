﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Android.Gms.Ads;

namespace AdvertTest.Droid
{
	[Activity (Label = "AdvertTest", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			MobileCenter.Configure("215be87a-c5d8-4fd5-a458-6611858e015d");
			MobileAds.Initialize(ApplicationContext, "ca-app-pub-4355768148547933~6046156805");
			LoadApplication (new AdvertTest.App ());
		}
	}
}

