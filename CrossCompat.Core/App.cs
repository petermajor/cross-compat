using Cirrious.MvvmCross.ViewModels;
using CrossCompat.Core.ViewModels;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;
using System.Net.Http;
using ModernHttpClient;
using CrossCompat.Core.Models;

namespace CrossCompat.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			base.Initialize();

			RegisterTypes ();

			InitializeNavigation();
		}

		void RegisterTypes()
		{
			CreatableTypes ()
				.InNamespace ("CrossCompat.Core.Commands")
				.AsInterfaces ()
				.RegisterAsLazySingleton ();

			Mvx.RegisterType<IFeedParser, FeedParser>();
			Mvx.RegisterSingleton<HttpMessageHandler>(new NativeMessageHandler());
		}

		void InitializeNavigation()
		{
			RegisterAppStart<PostsViewModel>();
		}
	}
}
