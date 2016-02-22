using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using CrossCompat.Core.Commands;
using CrossCompat.Core.Models;
using PropertyChanged;

namespace CrossCompat.Core.ViewModels
{
	[ImplementPropertyChanged]
	public class PostsViewModel : MvxViewModel
	{
		public ObservableCollection<PostItemViewModel> Posts { get; private set; } = new ObservableCollection<PostItemViewModel>();

		public ICommand ShowPostCommand { get; private set; }

		readonly IGetFeedCommand _getFeedCommand;

		public PostsViewModel(IGetFeedCommand getFeedCommand)
		{
			_getFeedCommand = getFeedCommand;

			ShowPostCommand = new MvxCommand<PostItemViewModel> (OnShowPostCommand);
		}

		public Task Init()
		{
			return LoadPosts ();
		}

		async Task LoadPosts()
		{
			Posts.Clear ();

			var feed = await _getFeedCommand.Execute ();

			foreach (var entry in feed.Entry)
			{
				var model = MapEntryToPostItem(entry);
				Posts.Add (model);
			}
		}

		PostItemViewModel MapEntryToPostItem(Entry entry)
		{
			return new PostItemViewModel {
				Title = entry.Title,
				PublicationDate = entry.Published.ToLocalTime().ToString("g"),
				Description = entry.Summary,
				Link = entry.Link?.Href,
			};

		}

		void OnShowPostCommand (PostItemViewModel post)
		{
			ShowViewModel<PostViewModel> (new { link = post.Link });
		}
	}
}