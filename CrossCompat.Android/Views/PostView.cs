using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;
using Cirrious.MvvmCross.Droid.Views;
using CrossCompat.Core.ViewModels;

namespace CrossCompat.Android.Views
{
	[Activity]
	public class PostView : MvxActivity<PostViewModel>
	{
		WebView webView;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			Window.RequestFeature(WindowFeatures.Progress);

			SetContentView(Resource.Layout.View_Post);

			webView = FindViewById<WebView> (Resource.Id.webView);

			webView.Settings.JavaScriptEnabled = true;

			var webClient = new MyWebChromeClient { OnProgress = OnProgress };
			webView.SetWebChromeClient (webClient);

			webView.LoadUrl(ViewModel.Link);
		}

		void OnProgress (int progress)
		{
			SetProgress(progress);
		}
	}

	public class MyWebChromeClient : WebChromeClient
	{
		public Action<int> OnProgress { get; set; }

		public override void OnProgressChanged (WebView view, int newProgress)
		{
			OnProgress?.Invoke (newProgress);
		}
	}
}