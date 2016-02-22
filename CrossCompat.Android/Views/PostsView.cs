using Android.App;
using Android.OS;
using CrossCompat.Android.Infrastructure;
using CrossCompat.Core.ViewModels;

namespace CrossCompat.Android.Views
{
	[Activity(MainLauncher=true)]
	public class PostsView : MvxAppCompatActivity<PostsViewModel>
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.View_Posts);
		}
	}
}