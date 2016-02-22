using Android.Content;
using CrossCompat.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using System.Collections.Generic;
using System.Reflection;

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

		protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
		{
			typeof(global::Android.Support.Design.Widget.NavigationView).Assembly,
			typeof(global::Android.Support.V7.Widget.Toolbar).Assembly,
			typeof(MvvmCross.Droid.Support.V7.RecyclerView.MvxRecyclerView).Assembly
		};

		void RegisterTypes ()
		{
		}
	}
}	