using System.Net.Http;
using CrossCompat.Core.Models;
using CrossCompat.Core.ViewModels;
using ModernHttpClient;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

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
