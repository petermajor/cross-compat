using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using CrossCompat.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace CrossCompat.Android.Views
{
	[Activity]
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