using Android.Content;
using CrossCompat.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;

namespace CrossCompat.Android
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context applicationContext)
			: base(applicationContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			RegisterTypes ();

			return new App();
		}

		void RegisterTypes ()
		{
		}
	}
}	