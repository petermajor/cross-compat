using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace CrossCompat.Core.Models
{
	public class FeedParser : IFeedParser
	{
		public Feed Parse(string feedAsString)
		{
			try
			{
				var reader = new StringReader(feedAsString);

				var s = new XmlSerializer(typeof(Feed));
				var feed = (Feed)s.Deserialize(reader);

				return feed;
			}
			catch (XmlException)
			{
				return null;
			}
		}
	}

	public interface IFeedParser
	{
		Feed Parse(string feedAsString);
	}
}