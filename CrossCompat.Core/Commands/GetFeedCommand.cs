using System;
using System.Net.Http;
using System.Threading.Tasks;
using CrossCompat.Core.Models;

namespace CrossCompat.Core.Commands
{
	public class GetFeedCommand : IGetFeedCommand
	{
		const string FeedUrl = "https://www.majormojo.co.uk/feed.xml";

		readonly IFeedParser _feedParser;

		readonly HttpMessageHandler _httpMessageHandler;

		public GetFeedCommand(IFeedParser feedParser, HttpMessageHandler httpMessageHandler)
		{
			_feedParser = feedParser;
			_httpMessageHandler = httpMessageHandler;
		}

		public async Task<Feed> Execute()
		{
			var httpClient = new HttpClient(_httpMessageHandler);

			try
			{
				var responseString = await httpClient.GetStringAsync(FeedUrl)
					.ConfigureAwait(false);

				var feed = _feedParser.Parse(responseString);

				return feed;
			}
			catch
			{
				return null;
			}
		}
	}

	public interface IGetFeedCommand
	{
		Task<Feed> Execute ();
	}
}