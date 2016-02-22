using MvvmCross.Core.ViewModels;
using PropertyChanged;

namespace CrossCompat.Core.ViewModels
{
	[ImplementPropertyChanged]
	public class PostViewModel : MvxViewModel
	{
		public string Link { get; set; }

		public void Init(string link)
		{
			Link = link;
		}
	}
}