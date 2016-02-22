using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;
using CrossCompat.Android.Infrastructure;
using CrossCompat.Core.ViewModels;
using Android.Support.V7.Widget;

namespace CrossCompat.Android.Views
{
	[Activity]
	public class PostView : MvxAppCompatActivity<PostViewModel>
	{
		WebView webView;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.View_Post);

			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);

			SetSupportActionBar (toolbar);

			var actionBar = SupportActionBar;
			if (actionBar != null)
			{
				actionBar.SetDisplayHomeAsUpEnabled (true);
			}

			webView = FindViewById<WebView> (Resource.Id.webView);

			webView.Settings.JavaScriptEnabled = true;

			var webClient = new WebChromeClient();
			webView.SetWebChromeClient (webClient);

			webView.LoadUrl(ViewModel.Link);
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			if (item.ItemId == global::Android.Resource.Id.Home)
			{
				OnBackPressed();
			}

			return base.OnOptionsItemSelected(item);
		}
	}
}