using Android.App;
using Android.OS;
using CrossCompat.Android.Infrastructure;
using CrossCompat.Core.ViewModels;
using Android.Support.V7.Widget;

namespace CrossCompat.Android.Views
{
	[Activity(MainLauncher=true)]
	public class PostsView : MvxAppCompatActivity<PostsViewModel>
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.View_Posts);

			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);

			SetSupportActionBar (toolbar);
		}
	}
}