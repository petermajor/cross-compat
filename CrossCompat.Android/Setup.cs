using Android.Content;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using CrossCompat.Core;
using Cirrious.CrossCore;

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