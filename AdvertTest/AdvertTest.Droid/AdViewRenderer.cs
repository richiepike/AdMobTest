using Android.Widget;
using Android.Gms.Ads;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AdvertTest.Controls;

[assembly: ExportRenderer(typeof(AdvertTest.Controls.AdView), typeof(AdvertTest.Droid.AdViewRenderer))]
namespace AdvertTest.Droid
{
	public class AdViewRenderer : ViewRenderer<Controls.AdView, Android.Gms.Ads.AdView>
	{
		string adUnitId = string.Empty;
		AdSize adSize = AdSize.SmartBanner;
		Android.Gms.Ads.AdView adView;
		protected override Android.Gms.Ads.AdView CreateNativeControl()
		{
			if (adView != null)
				return adView;

			adUnitId = "ca-app-pub-4355768148547933/2394686402";// Forms.Context.Resources.GetString(Resource.String.banner_ad_unit_id);
			adView = new Android.Gms.Ads.AdView(Forms.Context);
			adView.AdSize = adSize;
			adView.AdUnitId = adUnitId;

			var adParams = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);

			adView.LayoutParameters = adParams;

			adView.LoadAd(new AdRequest
							.Builder()
							.Build());
			return adView;
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Controls.AdView> e)
		{
			base.OnElementChanged(e);
			if (Control == null)
			{
				CreateNativeControl();
				SetNativeControl(adView);
			}
		}
	}
}