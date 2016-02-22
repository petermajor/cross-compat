using PropertyChanged;

namespace CrossCompat.Core.ViewModels
{
	[ImplementPropertyChanged]
	public class PostItemViewModel
	{
		public string Title { get; set; }

		public string PublicationDate { get; set; }

		public string Description { get; set; }

		public string Link { get; set; }
	}
}